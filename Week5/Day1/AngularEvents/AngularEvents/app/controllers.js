(function () {
    'use strict';

    angular.module('MyApp').controller('FavoriteColorController', FavoriteColorController);

    function FavoriteColorController() {
        var vm = this;
        vm.color = '';
        vm.btnClass = 'btn btn-primary btn-lg';

        function changeColor(color) {
            vm.color = color;
        }
        
        function changeBtnClass(color) {
            if(color == 'Red') { vm.btnClass = 'btn btn-danger btn-lg'; }
            else if (color == 'Yellow') { vm.btnClass = 'btn btn-warning btn-lg'; }
            else if (color == 'Green') { vm.btnClass = 'btn btn-success btn-lg'; }
            else { vm.btnClass = 'btn btn-info btn-lg'; }
        }

        vm.pickColor = function (color) {
            changeColor(color);
            changeBtnClass(color);
        };
    }
})();

(function () {
    'use strict';

    angular.module('MyApp').controller('CalculatorController', CalculatorController);

    function CalculatorController() {
        var vm = this;
        vm.num1 = '';
        vm.num2 = '';
        vm.result = '';
        vm.operation = '';

        function getResult(operation) {
            if (operation == '+') { vm.result = vm.num1 + vm.num2;}
            else if (operation == '-') { vm.result = vm.num1 - vm.num2; }
            else if (operation == '*') { vm.result = vm.num1 * vm.num2; }
            else if (operation == '/') { vm.result = vm.num1 / vm.num2; }
            else if (operation == '%') { vm.result = vm.num1 % vm.num2; }
            else { vm.result = Math.pow(vm.num1,vm.num2); }
        }

        vm.calculate = function (operation) {
            vm.operation = operation;
            getResult(operation);
        };
    }
})();