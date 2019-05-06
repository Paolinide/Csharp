
var textBox = $('.textBox');
var lblCounter = $('#charsLeft');
console.log(textBox);
console.log(lblCounter);
var counter = {

    massimo: 10,
    get val() {
        return textBox.text.length - this.massimo;
    },
    set val(newValue) {
        this.massimo = newValue;
    }
};

$(function () {



    textBox.on('keypress', function () {
        //    alert('sms')

        if (counter < 0) {
            textBox.addClass('red');
            btnPosta.style.visibility = hidden;
            return false;
        } else {
            lblCounter.val(counter);
            return true;
            //console.log(counter)

        }
    });



});