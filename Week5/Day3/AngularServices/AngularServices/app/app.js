(function () {
    'use strict';

    angular
        .module('productApp', [])
        .constant('productServiceURLs', { get: '/api/products/', post: '/api/products/' });
})();