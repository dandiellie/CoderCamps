(function () {
    'use strict';

    angular
        .module('EuropeanImportsApp')
        .controller('HomeController', [HomeController])
        .controller('LoginController', ['loginService', '$location', LoginController])
        .controller('CarsController', ['carsService', CarsController])
        .controller('HeaderController', ['loginService', '$location', HeaderController])
        .controller('RegisterController', ['loginService', '$location', RegisterController]);

    function HomeController() {

    }

    function LoginController(loginService, $location) {
        var vm = this;
        vm.login = login;
        vm.isLoading = false;

        function login() {
            vm.isLoading = true;
            loginService.login(vm.username, vm.password).then(success, fail);
        }

        function success(data) {
            vm.isLoading = false;
            $location.path('/cars');
        }
        function fail(data) {
            vm.isLoading = false;
            console.log("Failed in controller.");
        }
    }

    function CarsController(carsService) {
        var vm = this;

        carsService.getCars().then(success, fail);

        function success(data) {
            vm.cars = data;
        }
        function fail(data) {
            console.log("Failed in CarsController");
        }
    }

    function HeaderController(loginService, $location) {
        var vm = this;

        vm.isLoggedIn = isLoggedIn;
        vm.logout = logout;

        function isLoggedIn() {
            return loginService.isLoggedIn();
        }

        function logout() {
            loginService.logout();
            $location.path('/');
        }
    }

    function RegisterController(loginService, $location) {
        var vm = this;
        vm.isLoading = false;
        vm.register = register;

        function register() {
            vm.isLoading = !vm.isLoading;
            loginService.register(vm.email, vm.password, vm.confirmPassword).then(success, fail);

            function success(data) {
                vm.isLoading = !vm.isLoading;
                $location.path('/login');
            }
            function fail(data) {
                vm.isLoading = !vm.isLoading;
                console.log(data.message);
            }
        }
    }
})();