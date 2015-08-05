(function () {
    'use strict';

    angular.module('myApp', []).filter('startsWith', startsWith);

    function startsWith() {
        return function (input, expression) {
            expression = expression.toLowerCase();
            return input.filter(function (item) {
                return item.toLowerCase().startsWith(expression);
            });
        };
    }

    function unique() {
        return function (input) {
            var filteredSet = new Set(input);
            var filteredArray = [];
            filteredSet.forEach(function (item) {
                filteredArray.push(item);
            });

            return filteredArray;
        };
    }
})();