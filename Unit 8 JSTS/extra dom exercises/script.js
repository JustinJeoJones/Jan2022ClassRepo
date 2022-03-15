// vending machine
let total = 0;
function BuyItem(price){
    total += price;
    document.querySelector("#total").innerText = total;
}

//Make money
function MakeMoney(){
    let amount = parseInt(document.querySelector("#quantity").value);
    let type = document.querySelector("#coin").value;

    for(let i = 0; i<amount; i++){
        let newCoin = document.createElement("p");
        newCoin.innerText = type;
        document.querySelector("#coinContainer").appendChild(newCoin);
    }
}

//lightbulb
function TurnOn(){
    document.querySelector("#lightbulb").style.backgroundColor = "yellow";
}

function TurnOff(){
    document.querySelector("#lightbulb").style.backgroundColor = "gray";
}

function toggle(){
    if(document.querySelector("#lightbulb").style.backgroundColor == "yellow"){
        document.querySelector("#lightbulb").style.backgroundColor = "gray";
    }
    else{
        document.querySelector("#lightbulb").style.backgroundColor = "yellow";
    }
}

function disable(){
    document.querySelector("#on").disabled = true;
    document.querySelector("#off").disabled = true;
    document.querySelector("#toggle").disabled = true;
    document.querySelector("#end").disabled = true;
}