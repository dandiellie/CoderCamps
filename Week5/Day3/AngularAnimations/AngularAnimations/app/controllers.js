(function () {
    angular.module('taskApp').controller('TasksController', TasksController);

    function TasksController() {
        var vm = this;
        vm.addTask = addTask;

        vm.tasks = [
            { name: 'Feed Dog' },
            { name: 'Take Out Garbage' },
            { name: 'Water Lawn' }
        ];

        function addTask() {
            vm.tasks.push({ name: vm.newTask });
            vm.newTask = '';
        }
    }
})();

//function Food() {
//    this.name = '';
//}

//var apple = new Food();     //Constructor invocation pattern
//console.log(apple.name);    //name is a field on apple. Apple is an object {}
//var apple2 = Food();        //Function invocation pattern
//console.log(apple2.name);   //ERROR: appl2 is undefined

//var obj = {
//    food: Food
//}

//var apple3 = obj.food();    //Method invocation pattern
//console.log(apple3.name);   //ERROR: apple3 is undefined.
//console.log(obj.name);      //will return ''

//food.call(obj);             //Apply/Call invocation patter