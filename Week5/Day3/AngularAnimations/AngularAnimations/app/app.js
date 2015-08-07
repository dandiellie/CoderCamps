(function () {
    'use strict';

    angular
        .module('taskApp', ['ngAnimate', 'ngRoute'])
        .config(Config);

    function Config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/app/Views/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'vm'
            })
            .when('/viewA', {
                templateUrl: '/app/Views/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'vm'
            })
            .when('/viewB/:id', {
                templateUrl: '/app/Views/viewA.html',
                controller: 'ViewBController',
                controllerAs: 'vm'
            })
            .when('/taskList', {
                templateUrl: '/app/Views/taskView.html',
                controller: 'TasksController',
                controllerAs: 'vm'
            });
    }
})();