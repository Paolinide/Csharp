var display = document.getElementById("display");
var btnEqual = document.getElementById("equal");
var operators = document.getElementsByClassName("operator");
var num1 = num2 = display.value = op = "";
resetCalculator();

function concatNum(cifra) {
    console.log('operator ' + op)
    if (op) {
        hideOperators()
        showEqual()
    } else {
        if (btnEqual.style.visibility === "hidden") {
        //alert('hhhhhhhhhhhhhhh')
            resetDisplay()
            hideEqual()
            showOperators()
        } else {
            showOperators()
            alert('equal:  ' + btnEqual.style.visibility)
        }
    }
    display.value = display.value + cifra;

}
function setNum1(operation) {
    operators.visibility = "hidden"
    num1 = parseInt(display.value);
    op = operation;
    hideOperators()
    resetDisplay();
}
function showEqual() {
    btnEqual.style.visibility = "visible";
}
function hideEqual() {
    btnEqual.style.visibility = "hidden";
}
function hideOperators() {

    for (let btn of operators) {
        btn.style.visibility = "hidden";
    }
}
function showOperators() {
    for (let btn of operators) {
        btn.style.visibility = "visible";
    }
}

function resetDisplay() {
    display.value = "";
}
function resetCalculator() {
    num1 = num2 = display.value = op = "";
    hideEqual()
    hideOperators()
}
function setResult() {
    var num2 = parseInt(display.value);
    switch (op) {
        case '+':
            display.value = num1 + num2;
            break;
        case '-':
            display.value = num1 - num2;
            break;
        case 'x':
            display.value = num1 * num2;
            break;
        case '/':
            display.value = num1 / num2;
            break;
        default:
            break;
    }
    hideEqual()

}
