(function () {
    'use strict';

    angular
        .module('productApp')
        .factory('productService', productService);

    productService.$inject = ['$http', 'productServiceURLs', '$q'];

    function productService($http, productServiceURLs, $q) {
        var service = {};
        var products = [];

        service.getProducts = getProducts;
        service.createProduct = createProduct;
        service.update = update;
        service.delete = deleteProduct;

        function getProducts(callback) {
            var deferred = $q.defer();
            $http.get(productServiceURLs.get)
                .success(function (result) {
                    products.length = 0;
                    result.forEach(function (product) {
                        products.push(product);
                    });

                    deferred.resolve(products);
                }).error(function () {
                    deferred.reject();
                });

            return deferred.promise;
        }

        function createProduct(product) {
            var deferred = $q.defer();

            $http.post(productServiceURLs.post, product).success(function () {
                products.push(product);
                deferred.resolve();
            }).error(function () {
                deferred.reject();
            });

            return deferred.promise;
        }

        function update() {

        }

        function deleteProduct() {

        }

        return service;
    }
})();