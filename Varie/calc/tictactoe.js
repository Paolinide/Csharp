var desk = $(".desk")
var strike = 0;


function someoneWin(){
    alert('controllo');
}

$('.tic').on("click", function () {
    strike++;
    var obj = $(this);
    //alert(desk.data('playerRed'))
    if (strike % 2 == 0) {
        obj.toggleClass('red')
    } else {
        obj.toggleClass('blu')
    }
    if (strike >= 5) {
        someoneWin()
    }
    if (strike == 9) {
        alert('GAME OVER----PATTA!')
        desk
    }
});
