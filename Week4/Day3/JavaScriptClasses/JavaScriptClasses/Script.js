"use strict";

//#region Project1 Classes
//class Product {
//    constructor(name, price) {
//        this._name = name;
//        this._price = price;
//    }

//    calculateTax() {
//        return this._price * 0.08;
//    }
//};

//var product1 = new Product('Milk', 2.33);
//var product2 = new Product('Cheese', 4.33);

//class Car extends Product {
//    constructor(name, price, model) {
//        super(name, price);
//        this._model = model;
//    }

//    static listModels() {
//        return new Set(["Mini S", "Tesla S", "BMW 328i"]);
//    }
//}

//var car1 = new Car('Mini Cooper', 12000.00, 'Mini S');
//var car1 = new Car('Tesla', 70000.00, 'Tesla S');

//var models = Car.listModels();
//#endregion

//#region Project2A Private Methods and Fields Using Classes
//class Product {
//    constructor(name, price, stateTax) {
//        this._name = name;
//        this._total = this.calculateTotalPrice(price, stateTax);
//    }

//    calculateTotalPrice(p, t) {
//        function calculateTaxPrice(p, t) {
//            return p*t;
//        }

//        return p + calculateTaxPrice(p, t);
//    }
//};

//var Basketball = new Product("Jordan Ball", 25.99, 0.0825);
//#endregion

//#region Project2B Private Methods and Fields Using a Constructor Function (not working yet)
//function Product(name, price, stateTax) {
//    this.name = name;
//    var _price = price;
//    var _stateTax = stateTax;
//    var that = this;

//    function _calculateTax() {
//        return that._price * that._stateTax;
//    };
//    this.calculateTotal = function () {
//        return this._price + _calculateTax();
//    };

//    this.total = this.calculateTotal();
//};

//var Basketball = new Product("Jordan Ball", 25.99, 0.0825);
//console.log(Basketball.total);
//#endregion