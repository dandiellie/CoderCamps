'use strict';

//#region Project1
//var firstNumber = 12;
//var secondNumber = 3;

//var result = addNumbers(firstNumber, secondNumber);
//console.assert(result == 15, "result is not 15");

//function addNumbers(val1, val2) {
//    var oops = val1 + val2;
//    return oops;
//}
//#endregion

//#region Project2
//var userInput = prompt("Enter your favorite number: ");

//if (isNaN(userInput) || userInput == '') {
//    alert('You didn\'t enter a number.');
//}
//else {
//    alert('Your new number is ' + (100 + parseFloat(userInput)));
//}
//#endregion

//#region Project3
//console.assert(calculateTax(20) === 21.6, "calculateTax(20) failed");
//console.assert(calculateTax(20, .05) === 21, "calculateTax(20, .05) failed");
//console.assert(calculateTax(20, 0) === 20, "calculateTax(20, 0) failed");

//function calculateTax(price, taxRate) {
//    if (taxRate == null) { taxRate = 0.08 };
//    return parseFloat(price + (price * taxRate));
//}

//function calculateTax(price, taxRate) {
//    var rate = taxRate || 0.08;
//    (taxRate == 0) ? rate = 0 : rate = rate;
//    return parseFloat(price + (price * rate));
//}
//#endregion

//#region Project4
//function CatStrings(p1, p2, p3) {
//    var s = p1;
//    if (p2 != null) { s += p2; }
//    if (p3 != null) { s += p3; }
//    return s;
//};

//console.log(CatStrings("one"));             // result = one
//console.log(CatStrings("one", 2));          // result = one2
//console.log(CatStrings("one", 2, true));    // result = one2true
//#endregion

//#region Project5
//console.log(addIntegers(2, 4));         // 6
//console.log(addIntegers(2));            // Error: One or more of the addends is not a number.
//console.log(addIntegers("apple"));      // Error: One or more of the addends is not a number.
//console.log(addIntegers("",2));         // Error: One or more of the addends is not a number.
//console.log(addIntegers("1", 2));       // Error: One or more of the addends is not a number.
//console.log(addIntegers(3.4, 1));       // Error: One or more of the addends is not an integer.

//function addIntegers(val1, val2) {
//    try {
//        if (!(typeof val1 === 'number' && typeof val2 === 'number')) {
//            throw new Error('One or more of the addends is not a number.');
//        }
//        else if (!(val1 % 1 === 0 && val2 % 1 === 0)) {
//            throw new Error('One or more of the addends is not an integer.');
//        }
//        else {
//            console.log(val1 + val2); }
//    }
//    catch (ex) {
//        console.log(ex.name + ': ' + ex.message);
//    }
//}
//#endregion

//#region Project6 Customer Object
//var customer = {
//    _firstName: 'Danielle',
//    _lastName: 'Frederick',
//    get fullName() {
//        return this._firstName + ' ' + this._lastName;
//    },
//    set firstName(value) {
//        if (value || value == '') { throw new Error('First name required.'); }
//        this._firstName = value;
//    },
//    set lastName(value) {
//        if (value || value == '') { throw new Error('Last name required.'); }
//        this._lastName = value;
//    }
//};
//#endregion

//#region Project7 Dump All (depends on Project6)
//function dumpAll(object)
//{
//    var result = '';
//    for (var index in object) {
//        result += 'Name: ' + index + ' Value: ' + object[index] + '\r\n';
//    }
//    alert(result);
//}
//#endregion

//#region Project8 Validate All (didn't get it to work)
var customer = {
    required_firstName: '',
    required_lastName: '',
    favoriteColor: ''
};

var valCustomer = addRequiredValidation(customer);
valCustomer.firstName = '';  // should throw error
console.log(valCustomer.firstName);

function addRequiredValidation(object) {
    var newObject = {};
    for (var index in object) {
        if (index.indexOf('required') != -1) {
            (function (index) {
                var fieldName = index.substring(8);
                newObject[fieldName] = '';
                Object.defineProperty(newObject, index.substring(9), {
                    set: function (value) {
                        if (!value) { throw new Error(fieldName.substring(1) + ' is required.'); }
                        this[fieldName] = value;
                    },
                    get: function () {
                        return this[fieldName];
                    }
                });
            })(index);
        }
        else {
            (function (index) {
                var fieldName = '_' + index;
                newObject[fieldName] = '';
                Object.defineProperty(newObject, index, {
                    set: function (value) {
                        this[fieldName] = value;
                    },
                    get: function () {
                        return this[fieldName];
                    }
                });
            })(index);
        }
    }
    return newObject;
}
//#endregion