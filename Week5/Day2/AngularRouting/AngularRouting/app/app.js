(function () {
    'use strict';

    angular.module('myApp', ['ngRoute']).config(Config);

    function Config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/app/views/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'vm'
            })
            .when('/viewA', {
                templateUrl: '/app/views/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'vm'
            })
            .when('/viewB/:id', {
                templateUrl: '/app/views/viewB.html',
                controller: 'ViewBController',
                controllerAs: 'vm'
            })
            .otherwise({
                templateUrl: '/app/views/notfound.html'
            });
        $locationProvider.html5Mode(true);
    }
})();