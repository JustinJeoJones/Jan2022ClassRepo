let nameNode = document.querySelector("#name");
let colorNode = document.querySelector("#color");
let messageNode = document.querySelector("#message");
let letterNode = document.querySelector(".letter");
let nameResultNode = document.querySelector("#nameResult");
let messageResultNode = document.querySelector("#messageResult");

function ChangeContent(){
    let name = nameNode.value;
    let message = messageNode.value;
    let color = colorNode.value;

    nameResultNode.innerText = name;
    messageResultNode.innerText = message;
    //letterNode.setAttribute("style", `background-color: ${color}`);
    letterNode.style.backgroundColor = color;
}