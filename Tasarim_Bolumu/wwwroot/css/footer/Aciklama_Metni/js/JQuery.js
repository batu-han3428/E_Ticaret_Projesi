$(function(){

        $(".hr").css("display", "none");
        $(".cizgiSil").last().find("hr").css("display", "none");

        $('#aciklamaMetniLink').mouseup(function(){

            if($("#devaminiGoster").css("display") == "none"){
                $(".hr").css("display", "block");
                $(this).text("Devamını Gizle");

            }else if($("#devaminiGoster").css("display") == "inline"){
                $(".cizgiSil").eq(0).next().css("display", "none");
                $(this).text("Devamını Göster");

            }
                 
        });
        
});