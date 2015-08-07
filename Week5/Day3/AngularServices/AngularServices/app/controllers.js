(function () {
    'use strict';

    angular
        .module('productApp')
        .controller('ProductsController', ['productService', ProductsController])
        .controller('CreateProductController', ['productService', CreateProductController]);

    function ProductsController(productService) {
        var vm = this;

        vm.isLoaded = false;

        productService.getProducts().then(success, fail);

        function success(data) {
            vm.products = data;
            vm.isLoaded = true;
        }

        function fail() {

        }
    }

    function CreateProductController(productService) {
        var vm = this;

        vm.add = add;

        function add() {
            var product = {
                name: vm.name,
                price: vm.price
            };
            productService.createProduct(product).then(success, fail);
        }

        function success() {
            vm.name = '';
            vm.price = '';
        }

        function fail() {

        }
    }
})();