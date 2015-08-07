(function () {
    'use strict';

    angular
        .module('movieApp')
        .controller('GetMoviesController', ['movieService', GetMoviesController])
        .controller('CreateMovieController', ['movieService', CreateMovieController]);
    
    function GetMoviesController(movieService) {
        var vm = this;

        vm.isLoaded = false;

        movieService.getMovies().then(success, fail);

        function success(data) {
            vm.movies = data;
            vm.isLoaded = true;
        }

        function fail() {
            console.log('failed');
        }
    }

    function CreateMovieController(movieService) {
        var vm = this;

        vm.add = add;

        function add() {
            var movie = {
                title: vm.title,
                year: vm.year,
                director: vm.director
            };
            movieService.createMovie(movie).then(success, fail);
        }


        function success() {
            vm.title = '';
            vm.year = '';
            vm.director = '';
        }

        function fail() {

        }
    }
})();