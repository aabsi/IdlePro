
var wood = 0;
var gold = 0;
var pop = 0;
var souls = 0;

document.getElementById("wood").innerHTML = wood;
document.getElementById("gold").innerHTML = gold;
document.getElementById("pop").innerHTML = pop;
document.getElementById("souls").innerHTML = souls;

function chopWood() {
    wood = wood + 2;
    document.getElementById("wood").innerHTML = wood;
}