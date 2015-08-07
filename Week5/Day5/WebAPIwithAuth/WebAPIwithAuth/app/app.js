(function () {
    'use strict';

    angular
        .module('EuropeanImportsApp', ['ngRoute'])
        .config(['$routeProvider', '$httpProvider', Config]);

    function Config($routeProvider, $httpProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'app/views/home.html',
                controller: 'HomeController',
                controllerAs: 'vm'
            }).when('/login', {
                templateUrl: 'app/views/login.html',
                controller: 'LoginController',
                controllerAs: 'vm'
            }).when('/cars', {
                templateUrl: 'app/views/cars.html',
                controller: 'CarsController',
                controllerAs: 'vm'
            }).when('/register', {
                templateUrl: 'app/views/register.html',
                controller: 'RegisterController',
                controllerAs: 'vm'
            }).otherwise({
                redirectTo: '/'
            });

        $httpProvider.interceptors.push('authService');
    }
})();