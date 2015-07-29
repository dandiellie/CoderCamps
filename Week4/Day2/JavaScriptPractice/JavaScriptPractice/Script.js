'use strict';

//#region Project1 Arrays
//var teams = [
//    'Astros',
//    'Dynamo',
//    'Texans',
//    'Rockets'
//];

//teams.forEach(function (team) {
//    console.log(team);
//});

//var products = new Array();

//products.push({ name: 'Cheese', price: 7.00 });
//products.push({ name: 'Milk', price: 3.00 });
//products.push({ name: 'Wine', price: 97.30 });
//products.push({ name: 'Grapes', price: 4.00 });

//var filteredProducts = products.filter(function (product) {
//    return product.price > 5.00;
//});

//filteredProducts.forEach(function (product) {
//    console.log(product);
//});

//var total = products.reduce(function (previous, current, index, arr) {
//    return { price: previous.price + current.price };
//});

//console.log(total.price);
//#endregion

//#region Project2 Maps
//var userInput = prompt("Please enter a string you would like to check for uniqueness.").toLowerCase();
//var uniqueWords = new Map();

//var words = userInput.split(" ");
//words.forEach(function(word) {
//    if (uniqueWords.has(word)) {
//        uniqueWords.set(word, uniqueWords.get(word)+1);
//    }
//    else {
//        uniqueWords.set(word, 1);
//    }
//});

//alert("There are " + uniqueWords.size + " unique words in the string you entered.");

//for (let item of uniqueWords) {
//    console.log("Key: " + item[0] + " and Value: " + item[1]);
//}

//var mostUsedWord = "";
//var mostUsedTimes = 0;
//for (let key of uniqueWords.keys()) {
//    if (mostUsedTimes < uniqueWords.get(key)) {
//        mostUsedTimes = uniqueWords.get(key);
//        mostUsedWord = key;
//    }
//}

//alert("The most used word '" + mostUsedWord + "' was used " + mostUsedTimes + " times.");
//#endregion

//#region Project3 Functions (doesn't work right now)
//var listOfNumbers = [17, 2, 3, 78, 4, 5, 12];

//function sortAscending(myArray) {
//    var currentLowestPlace = 0;
//    var currentLowestValue = 0;
//    for (var i = 0; i < arguments.length; i++) {
//        currentLowestPlace = i;
//        for (var j = i; j < arguments.length; j++) {
//            if (myArray[j] < myArray[currentLowestPlace]) {
//                currentLowestPlace = j;
//            }
//        }
//        currentLowestValue = myArray[currentLowestPlace];
//        myArray[currentLowestPlace] = myArray[i];
//        myArray[i] = currentLowestValue;
//    }
//}

//function sortDesceding(myArray) {
//    sortAscending(myArray);
//    var newArray = [];
//    var j = myArray.length;
//    for (var i = 0; i < myArray.length; i++) {
//        newArray[i] = myArray[j - 1];
//        j--;
//    }
//    myArray = newArray;
//}

//function printArray(myArray) {
//    for (var i = 0; i < myArray.length; i++) {
//        console.log(myArray[i]);
//    }
//}

//printArray(listOfNumbers);
//console.log(" ");
//sortAscending(listOfNumbers);
//printArray(listOfNumbers);
//console.log(" ");
//sortDesceding(listOfNumbers);
//printArray(listOfNumbers);
//#endregion

//#region Project4 "this"
////  Function Invocation Pattern
//function addCount() {
//    this._count++;
//    console.log(this, this._count);
//}

//addCount();                                 //THIS refers to the global window object

////  Method Invocation Pattern
//var counter = {
//    _count: 0,
//    addCount: addCount
//}

//counter.addCount();                         //THIS refers to the counter object

////  Apply/Call Invocation Pattern
//var somethingElse = {
//    _count: 9
//}

//addCount.call(somethingElse);               //THIS refers to the somethingElse object

//// Array, Object, Function, Date
//function AddCount2(count) {
//    this.count = count;
//}

//var someObj = new AddCount2(4);             //THIS refers to a new someObj object
//#endregion

//#region Project5 Revealing Module Pattern
//var module = (function () {

//    //private methods
//    function _calculatePrice(price) {
//        return price + _calculateTax(price);
//    }

//    function _calculateTax(price) {
//        return price * 0.08;
//    }

//    return {
//        calculatePrice: _calculatePrice
//    };
//})();
//#endregion

//#region Project6 Closure
//var buttons = document.getElementsByTagName("button");
//addClickHandlers(buttons);

//function addClickHandlers(buttons) {
//    for (var i = 0; i < buttons.length; i++) {
//        addClickHandler(buttons[i], i);
        
//        //buttons[i].addEventListener('click', function () {
//        //    alert('You clicked button ' + i);
//        //});
//    }
//}

//function addClickHandler(button, index) {
//    button.addEventListener('click', function () {
//        alert('You clicked button ' + index);
//    });
//}
//#endregion

//#region Project7 More Closure
//(function getFunction() {
//    var message = 'Hello World';

//    //inner function
//    return function () {
//        console.log(message);
//    }
//})()();
//#endregion