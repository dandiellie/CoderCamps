(function () {
    angular.module('myApp').controller('FoodController', FoodController);

    function FoodController($http) {
        var vm = this;

        vm.fetch = fetch;

        function fetch() {
            if (vm.search) {
                $http.get('/api/food/' + vm.search)
                    .success(function (result) {
                        vm.items = result;
                    })
                    .error(function () {
                        console.error('Could not retrieve food!');
                    });
            }
        }
    }
})();