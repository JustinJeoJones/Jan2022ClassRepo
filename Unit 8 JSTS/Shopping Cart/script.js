class Product {
    constructor(name, price){
        this.name = name;
        this.price = price;
    }
}
let Cart = [];

//adding items to cart
function AddToCart(name, price){
    let count = prompt("How many would you like?");

    for(let i = 0; i < count; i++){
        let newProduct = new Product(name, price);
        Cart.push(newProduct);
    }
    
}

function DisplayReceipt(){
    document.getElementById("cart").innerHTML = "";
    let total = 0;
    Cart.forEach(I => {
        console.log(`${I.name} $${I.price}`);
        //document.getElementById("cart").innerText += `${I.name} $${I.price}\n`;
        document.getElementById("cart").innerHTML += `<div class="row">
        <h2 class="col-2">${I.name}</h2>
        <p class="col text-end">${I.price}</p>
        </div>`;
        total += I.price;
    });
    console.log(`Your total is: ${total.toFixed(2)}`);
    let tax = 0.06;
    let grandtotal = total + (total * tax);
    console.log(`Your tax is ${(total * tax).toFixed(2)}`);
    console.log(`Your grand total is ${grandtotal.toFixed(2)}`);

    document.getElementById("cart").innerHTML += `<div>
    <h3>Total: ${total.toFixed(2)}</h3>
    <h3>Tax: ${(total * tax).toFixed(2)}</h3>
    <h2>Grand Total: ${grandtotal.toFixed(2)}</h2>
    </div>`;

    Cart = [];
}
