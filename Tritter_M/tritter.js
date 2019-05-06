var btnPosta = $('.btnPosta');
var sms = $('.sms');
var lblCounter = $('#NcharLeft');
var counter = 5;
lblCounter.val(counter);
lblCounter.on('click', function () { alert('countr'); });

// var a=alert(btnPosta.length);
// var b=alert(sms.value);
console.log('partito');

//alert('posta') 

$(function () {
    var pnl = $(".card");
    console.log('');


    $(".btnPosta").on("click", function () {
        // versione 1
        // pnl.append("<div class='panel'>ciao<button class='btnDelete'>Cancella</button></div>")
        

        // versione 2
        var div = $("<div class='panel'></div>");
        div.text(sms.val());
        div.append("<button class='btnDelete'>Cancella</button>");
        pnl.append(div);
        
        var btnDelete = $(".btnDelete");
        btnDelete.off("click");
        btnDelete.on("click", function () {
            var obj = $(this);
            if (confirm("Sicuro di voler cancellare?")) {
                obj.parent(".panel").remove();
        
            }
        });
    });
});





sms.on('keypress', function () {
    //    alert('sms')

    if (--counter < 0) {
        console.log('finiti');
        console.log(counter);
        sms.addClass('red');
        btnPosta.style.visibility = hidden;
        return false;
    } else {
        lblCounter.val(counter);
        return 'o';
        //console.log(counter)

    }
});
