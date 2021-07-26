$(document).ready(function () {

})

$("#tuslar > button").bind("contextmenu", function (e) {

    $(".contextmenu").css({

        top: e.pageY -= "30", // .pageY : Mouse'un tıklandığı Y koordinatı

        left: e.pageX -= "-5", // .pageX : Mouse'un tıklandığı X koordinatı

        display: "block" // Menümüzü görünür hale getiriyoruz (isterseniz burada fadeIn, slideDown gibi olaylarda kullanabilirsiniz. Eğlenmek size kalmış :) )

    });

    return false; // Kullanılan browser'ın kendi menüsünü pasif duruma getiriyoruz. Yani false değeri döndürerek bu işlevi engelliyoruz.

});

$(document).click(function () {

    $(".contextmenu").hide(); // Dökümanın herhangi bir yerine tıklandığında menü kaybolsun.

})

$(document).contextmenu(function () {

    $(".contextmenu").hide(); // Dökümanın herhangi bir yerine tıklandığında menü kaybolsun.

})

$(".container-fluid").scroll(function () {

    $(".contextmenu").hide(); // Dökümanın herhangi bir yerine tıklandığında menü kaybolsun.

})

$(document).scroll(function () {

    $(".contextmenu").hide(); // Dökümanın herhangi bir yerine tıklandığında menü kaybolsun.

})