export{}
//starting example

//normal arrow function
const greeter = (person: string): string => `Hello ${person}`;
//optional parameter
const greeter2 = (person: string = "Steve"): string => `Hello ${person}`;
const user: string = "Ivan";
console.log(greeter(user));
console.log(greeter2("Justin"));

//variables
let done: boolean = true;
let num: number = 10;
let word: string = "Hi";
let nums: number[] = [1,2];
let something: any = 1;
something = "HI";
function print():void{
    console.log('something');
}

//interface
interface Person {
    firstName: string;
    lastName: string;
}

let Justin: Person = {
    firstName : "Justin",
    lastName: "Jones"
}

interface Animal {
    name: string;
    age:number;
    isFurry:boolean;
}

let Garfield: Animal = {
    name:"Garfield",
    age: 34,
    isFurry: true
}

function DisplayAnimalName(a:Animal):void{
    console.log(a.name);
}

DisplayAnimalName(Garfield);

//Classes
class Student {
    public fullName:string;
    // adding public to constructor param makes it a property
    constructor(public firstName:string, public middleInitial:string, public lastName:string){
        this.fullName = `${firstName} ${middleInitial} ${lastName}`;
    }

    DisplayName():void{
        console.log(this.fullName);
    }
}

let myStudent:Student = new Student("Justin", "S", "Jones");
myStudent.DisplayName();

//conditionals
if(myStudent.firstName == "Justin"){
    console.log("Hi Justin");
}
else if(myStudent.firstName == "Tommy"){
    console.log("Oh hi friend");
}
else{
    console.log("get off my computer");
}

//loops
for(let i:number = 0; i<10; i++){
    console.log(i);
}

let counter:number = 10;
while(counter >=0){
    console.log(counter);
    counter--;
}

let items: string[] = ["Cola", "Chips", "Red Bull", "Candy"];
items.forEach(item => console.log(item));
items.forEach((item:string) => {
    console.log();
    console.log(item);
});

//challenge
let population:Person[] = [
    {
        firstName: "Lucas",
        lastName:"Bandy"
    },
    {
        firstName: "Justin",
        lastName: "Jones"
    },
    {
        firstName:"Alex",
        lastName:"Weber"
    },
    {
        firstName:"Jon",
        lastName:"Jordan"
    },
    {
        firstName:"Tarik",
        lastName:"Belkouchi"
    },
    {
        firstName:"Josh",
        lastName:"Carolin"
    }
];

function DisplayPopulation(people:Person[]):void{
    people.forEach((p) => {
        let fName = `${p.firstName} ${p.lastName}`;
        console.log(fName);
    } );
}

DisplayPopulation(population);

interface value {
    y:number;
}

let data:value[] = [
    {
        y:2
    },
    {
        y:123
    },
    {
        y:567
    },
    {
        y:0
    },
]

const max = data.reduce(function(prev, current) {
    return (prev.y > current.y) ? prev : current
})

console.log(max)