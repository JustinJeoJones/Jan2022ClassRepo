// document.write("Javascript all of the things!")
// document.body.innerHTML = "hi";

//return array of all matching html elements
let listItems = document.getElementsByClassName("food");
for(let i = 0; i< listItems.length; i++){
    let listItem = listItems[i];
    console.log(listItem.innerText);
}

//return a single matching html element
let happyNode = document.getElementById("happy");
console.log(happyNode.innerText);

//used to select any element

//"p" to target the p element
//".food" to target the food class
//"#happy" to target the happy id

//querySelector return single matching html element
let happyNode2 = document.querySelector("#happy");

//querySelectorAll returns array of all matching html elements
let listItems2 = document.querySelectorAll(".food");



//Adjusting html attribute
let catNode = document.querySelector("#catImage");
catNode.setAttribute("src", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/close-up-of-cat-wearing-sunglasses-while-sitting-royalty-free-image-1571755145.jpg");

//Creating new HTML
let newNode = document.createElement('p');
newNode.innerText = "I made a new tag!";
document.body.appendChild(newNode);
