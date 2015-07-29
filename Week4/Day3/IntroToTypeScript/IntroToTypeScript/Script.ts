"use strict";

class Product {
    private _name
    private _price

    constructor(name, price) {
        this._name = name;
        this._price = price;
    }

    calculateTax() {
        return this._price * 0.0825;
    }
};

class Car extends Product {
    private _model;

    constructor(name, price, model) {
        super(name, price);
        this._model = model;
    }
};

var car1 = new Car("Mini Cooper", 12000.00, "Mini S");
var car2 = new Car("Tesla", 70000.00, "Tesla S");