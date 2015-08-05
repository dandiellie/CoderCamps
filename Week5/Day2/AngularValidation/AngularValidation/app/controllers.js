(function () {
    'use strict';

    angular.module('carApp').controller('CarController', CarController);

    function CarController() {
        var vm = this;
        var model = '';
        var price = 0;
        var message = '';

        vm.add = function () {
            vm.message = 'You entered Model: ' + vm.model + ' Price: ' + vm.price;
        }
    }
})();

(function () {
    'use strict';

    angular.module('carApp').controller('EmployeeController', EmployeeController);

    function EmployeeController() {
        var vm = this;
        var firstName = '';
        var lastName = '';
        var age = 0;
        vm.selectedType = '';
        vm.types = ['FullTime', 'PartTime'];
        var yearlySalary = 0;
        var monthlySalary = 0;
        vm.isFullTime = isFullTime;

        function isFullTime() {
            return vm.selectedType === 'FullTime';
        }
    }
})();