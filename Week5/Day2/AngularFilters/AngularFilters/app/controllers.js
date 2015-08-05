(function () {
    'use strict';

    angular
        .module('myApp')
        .controller('FoodController', FoodController)
        .controller('StringController', StringController);

    function FoodController() {
        var vm = this;
        vm.food = [
            'Milk',
            'Marzipan',
            'Mustard',
            'Eggs',
            'Milk',
            'Eggs',
            'Eggs',
            'Marzpan',
            'Milk'
        ];
    }

    function StringController() {
        var vm = this;

        //vm.entry = 'hey hey you you this is dani';
        vm.entryArray = ['hey', 'hey', 'you', 'you', 'i', 'dont', 'like', 'your', 'girl', 'friend'];

        //function entryArray() {
        //    return vm.entry.split(' ');
        //}
    }
})();