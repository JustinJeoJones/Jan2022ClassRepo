class Employee{
    constructor(role, name){
        this.role = role;
        this.name = name
    }
    getRole(){
        //return this.role;
        return `${this.name} is a ${this.role}`;
    }
}

//This is where i'm storing employees
let Staff = [];

function AddEmployee(_role){
    let name = prompt("Please enter your name");
    let newEmployee = new Employee(_role, name);
    Staff.push(newEmployee);
    console.log(Staff);
}

function displayTeam(){
    Staff.forEach(e => console.log(e.getRole()));
}
