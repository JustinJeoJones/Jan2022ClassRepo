console.log("Hello world");
// Variables
let myVariable;
myVariable = 10; //number

let name = "Justin"; //string
let stringAge = "24"; //string
let AmCaffinated = true; //bool
let amNull = null; //null or no value
let amUndefined; //undefined

//math operators
let total = 1 + 2; //adding
console.log(total);

total = 1 - 2; //subbing
console.log(total);

total = 1 / 2; //dividing
console.log(total);

total =  1 * 2; //multiplying
console.log(total);

total = 1 % 2; //modulus
console.log(total);

total++; //increment
console.log(total);

total--;//decrement
console.log(total)

//Assignment
total = 10; //standard
console.log(total);

total += 5; //plus equals
console.log(total);

total -= 10;//minus equals
console.log(total);

total *=10;//multiply equals
console.log(total);

total /= 5;//divide equals
console.log(total);

//Compaisons
//There are 2 versions of equals. Use ===
console.log("2" == 2); //true
console.log("2" === 2);//false

console.log(true == "1");//true
console.log(true === "1");//false
//this applies to !==
console.log(2 != "2"); //false
console.log(2 !== "2"); //true

console.log(2 > 1);
console.log(3 >= 3);

console.log(2 < 1);
console.log(3 <= 3);

let num = 5;
console.log(num > 1);

//If/Else
if(num >5){
    console.log("the number is greater then 5");
}
else if(num === 5){
    console.log("the number is equal to 5");
}
else
{
    console.log("the number is less to 5");
}

let myClass = "C# Full Stack";
if(myClass === "C# Full Stack"){
    console.log("I am in the right class");
}
else{
    console.log("I am in the wrong class");
}

//loops
//for loop
for(let i = 0; i < 10; i++){
    console.log(i);
}

//while loop
let x = 20;
while(x>0){
    console.log(x);
    x--;
}

//do while
do{
    console.log(x);
    x++;
}while(x<=20)

//Arrays
let numbers = [1,5,9,10];
let students = ["Jon", "Tarik", "Lucas", "Alex"];
console.log(numbers);
console.log(students);

//foreach
students.forEach(s => console.log(s));

students.forEach((s) => {
    console.log(s);
    console.log("is cool");
});

//Functions
function Multipler(x,y){
    return x*y;
}

console.log(Multipler(3,4));

function GreetUser(){
    console.log("Hello");
}

GreetUser();

function Scope(){
    let letVariable = true;
    var varVariable = false;
}

//Don't have access to these because of { } / Scope
//console.log(letVariable);
//console.log(varVariable);

//Classes
class Rectangle {
    constructor(height, width){
        this.height = height;
        this.width = width;
    }
    getArea(){
        return this.height * this.width;
    }
    getPerimeter(){
        return (this.height + this.width) * 2;
    }
}

let myRectangle = new Rectangle(4,5);
console.log(myRectangle.getArea());
console.log(myRectangle.getPerimeter());

