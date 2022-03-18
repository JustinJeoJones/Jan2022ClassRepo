"use strict";
exports.__esModule = true;
//starting example
//normal arrow function
var greeter = function (person) { return "Hello ".concat(person); };
//optional parameter
var greeter2 = function (person) {
    if (person === void 0) { person = "Steve"; }
    return "Hello ".concat(person);
};
var user = "Ivan";
console.log(greeter(user));
console.log(greeter2("Justin"));
//variables
var done = true;
var num = 10;
var word = "Hi";
var nums = [1, 2];
var something = 1;
something = "HI";
function print() {
    console.log('something');
}
var Justin = {
    firstName: "Justin",
    lastName: "Jones"
};
var Garfield = {
    name: "Garfield",
    age: 34,
    isFurry: true
};
function DisplayAnimalName(a) {
    console.log(a.name);
}
DisplayAnimalName(Garfield);
//Classes
var Student = /** @class */ (function () {
    // adding public to constructor param makes it a property
    function Student(firstName, middleInitial, lastName) {
        this.firstName = firstName;
        this.middleInitial = middleInitial;
        this.lastName = lastName;
        this.fullName = "".concat(firstName, " ").concat(middleInitial, " ").concat(lastName);
    }
    Student.prototype.DisplayName = function () {
        console.log(this.fullName);
    };
    return Student;
}());
var myStudent = new Student("Justin", "S", "Jones");
myStudent.DisplayName();
//conditionals
if (myStudent.firstName == "Justin") {
    console.log("Hi Justin");
}
else if (myStudent.firstName == "Tommy") {
    console.log("Oh hi friend");
}
else {
    console.log("get off my computer");
}
//loops
for (var i = 0; i < 10; i++) {
    console.log(i);
}
var counter = 10;
while (counter >= 0) {
    console.log(counter);
    counter--;
}
var items = ["Cola", "Chips", "Red Bull", "Candy"];
items.forEach(function (item) { return console.log(item); });
items.forEach(function (item) {
    console.log();
    console.log(item);
});
//challenge
var population = [
    {
        firstName: "Lucas",
        lastName: "Bandy"
    },
    {
        firstName: "Justin",
        lastName: "Jones"
    },
    {
        firstName: "Alex",
        lastName: "Weber"
    },
    {
        firstName: "Jon",
        lastName: "Jordan"
    },
    {
        firstName: "Tarik",
        lastName: "Belkouchi"
    },
    {
        firstName: "Josh",
        lastName: "Carolin"
    }
];
function DisplayPopulation(people) {
    people.forEach(function (p) {
        var fName = "".concat(p.firstName, " ").concat(p.lastName);
        console.log(fName);
    });
}
DisplayPopulation(population);
var data = [
    {
        y: 2
    },
    {
        y: 123
    },
    {
        y: 567
    },
    {
        y: 0
    },
];
var max = data.reduce(function (prev, current) {
    return (prev.y > current.y) ? prev : current;
});
console.log(max);
