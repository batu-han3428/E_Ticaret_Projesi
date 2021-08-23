$(document).ready(function () {

})

$(".urunKategorileriAlanAdlari > span, .KategorilerAdlari > span").bind("contextmenu", function (e) {

    $(".sagTikMenuKategori").css({

        top: e.pageY -= "0", // .pageY : Mouse'un tıklandığı Y koordinatı

        left: e.pageX -= "-10", // .pageX : Mouse'un tıklandığı X koordinatı

        display: "block" // Menümüzü görünür hale getiriyoruz (isterseniz burada fadeIn, slideDown gibi olaylarda kullanabilirsiniz. Eğlenmek size kalmış :) )

    });

    return false; // Kullanılan browser'ın kendi menüsünü pasif duruma getiriyoruz. Yani false değeri döndürerek bu işlevi engelliyoruz.

});

$(document).click(function () {

    $(".sagTikMenuKategori").hide(); // Dökümanın herhangi bir yerine tıklandığında menü kaybolsun.

})

$(document).contextmenu(function () {

    $(".sagTikMenuKategori").hide(); // Dökümanın herhangi bir yerine sağ tıklandığında menü kaybolsun.

})

$(".container-fluid").scroll(function () {

    $(".sagTikMenuKategori").hide(); // container-fluid scrollu hareket ettiğinde menü kaybolsun.

})

$(document).scroll(function () {

    $(".sagTikMenuKategori").hide(); // Dökümanın scrollu hareket ettiğinde menü kaybolsun.

})