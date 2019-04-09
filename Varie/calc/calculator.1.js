
//var display = document.getElementById("txtDisplay");
var display = document.querySelector("#txtDisplay");
//var keyList = document.querySelector(".key");

var prevNum;
var currentOp;

function exec(){
  
    var currentNum = parseInt(display.value);
    var result;

    switch (currentOp) {
        case "+":
            result = prevNum + currentNum;
            break;
        case "-":
            result = prevNum - currentNum;
            break;
        case "*":
            result = prevNum * currentNum;
            break;
        case "/":
            result = prevNum / currentNum;
            break;
    }
    display.value = result;
}

function pressNum(num){
    display.value += num;
}

function pressOp(op){

    currentOp = op;
    prevNum = parseInt(display.value);
    display.value = "";
}



$('.key-num').on("click", function(){
    var obj = $(this);
    pressNum(obj.data("key"));
});

$('.key-op').on("click", function(){
    
    pressOp($(this).data("key"));
});

$('.key-equal').on("click", function(){
    exec()});
