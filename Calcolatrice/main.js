
var primoValore = '0';
var secondoValore;
var operatore = '';

setDisplay(primoValore);

function setDisplay(textDisplay) {
    var display = document.getElementById("display");
    display.value = textDisplay;
}

function sendDigit(digit) {
    if (primoValore == '0') primoValore = digit;
    else primoValore += digit;
    setDisplay(primoValore);
}

function setOperator(op) {
    if (operatore != '' && primoValore != '0') setResult();
    operatore = op;
    secondoValore = primoValore;
    primoValore = '0';
    //setDisplay('0');
}

function setComma() {
    if (primoValore.indexOf('.') == -1) {
        primoValore += '.';
        setDisplay(primoValore);
    }
}

function cancelDigit() {
    console.log('1: <' + primoValore + '> 2: <' + secondoValore + '> o: <' + operatore + '>');
    if (primoValore.length == 1) primoValore = '0';
    else primoValore = primoValore.substring(0, primoValore.length - 1);
    setDisplay(primoValore);
}

function cancelAll() {
    primoValore = '0';
    secondoValore = '';
    operatore = '';
    setDisplay(primoValore);
}

function setResult() {
    if (operatore != '') {
        primo = Number(primoValore);
        secondo = Number(secondoValore);
        switch (operatore) {
            case '+':
                primo += secondo;
                break;
            case '-':
                primo = secondo - primo;
                break;
            case 'x':
                primo *= secondo;
                break;
            case '/':
                primo = secondo / primo;
                break;
            default:
                break;
        }
        secondoValore = '0';
        primoValore = primo + '';
        operatore = '';
        setDisplay(primo);
    }
}