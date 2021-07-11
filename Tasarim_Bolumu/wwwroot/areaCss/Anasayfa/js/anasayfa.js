$(function(){

    var sayac = 0;

    $("#menuAc").click(function(){

        if(sayac%2 == 0){

            $("#solMenu").animate({

                width: 'toggle'

            });
        

            $("#anaEkran").delay(0).queue(function (next) { 

                $(this).fadeOut(70).animate({'width': '100%'}).fadeIn(); 

                next(); 

            });

            sayac++;

        }else{

            $("#anaEkran").fadeOut(70).animate({

                width: "83.3333333333%"

            }).fadeIn();


            $("#solMenu").delay(100).queue(function (next){ 

                $(this).animate({width: 'toggle'}); 

                next(); 

            });

            sayac++;

        }       

    });


    $(".list-group > button").click(function(){

        $(".list-group > button").removeClass("active");

        $(this).addClass("active").css({
            "transition":"1s background-color, 500ms color"
        });

        var indis = $(this).index();

        indis--;

        $("#mobilSolMenuUl a").removeClass("active");

        $("#mobilSolMenuUl > li").eq(indis).find("a").addClass("active rounded-3"); 

    });

    $("#mobilSolMenuUl > li").click(function(){

        $("#mobilSolMenuUl a").removeClass("active");

        $(this).find("a").addClass("active").addClass("rounded-3").css({
            "transition":"1s background-color, 500ms color"
        });

        var indis = $(this).index();

        indis++;

        $(".list-group > button").removeClass("active");

        $(".list-group > button").eq(indis).addClass("active");  

    });

});