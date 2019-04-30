
// $(document).ready(function () {

// });


$(function () {
    var pnl = $("#pnlOutput");


    $("#btnExec").on("click", function () {
        // versione 1
        // pnl.append("<div class='panel'>ciao<button class='btnDelete'>Cancella</button></div>")

        // versione 2
        var div = $("<div class='panel'></div>");
        div.text("ciao");
        div.append("<button class='btnDelete'>Cancella</button>")
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

    $(".texBox").on("keypress", function(){
        alert($(".texBox").value.lenght);
    });

    

});
