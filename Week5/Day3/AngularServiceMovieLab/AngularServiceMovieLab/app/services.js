(function () {
    'use strict';

    angular
        .module('movieApp')
        .factory('movieService', ['$http', '$q', 'movieServiceURL', movieService]);

    function movieService($http, $q, movieServiceURL)
    {
        var service = {};
        var movies = [];

        service.getMovies = getMovies;
        service.createMovie = createMovie;

        function getMovies(movie) {
            var deferred = $q.defer();

            $http
                .get(movieServiceURL)
                .success(function (result) {
                    movies.length = 0;
                    result.forEach(function (movie) {
                        movies.push(movie);
                    });
                    deferred.resolve(movies);
                }).error(function () {
                    deferred.reject();
                });

            return deferred.promise;
        }

        function createMovie() {
            var deferred = $q.defer();

            $http
                .post(movieServiceURL, movie)
                .success(function () {
                    movies.push(movie);
                    deferred.resolve();
                }).error(function () {
                    deferred.reject();
                });

            return deferred.promise;
        }

        return service;
    }
})();