$(function () {


    var indexGeri = 0;
    var indexIleri = $(".topAlanDiv").length - 3;
    var mesafe = 11;

    $(".topAlanDiv").slice(indexGeri, 6).show();
    $(".topAlanDiv").slice(6).hide();


    $("#geriKategori").click(function () {

        if (indexIleri < 9) {

            $(".topAlan").animate({

                left: "-=" + mesafe + "%"

            }, { duration: 'fast' });
           
            $(".topAlanDiv").eq(indexGeri).fadeOut(300);

            $(".topAlanDiv").eq(indexIleri).show(100);

            indexGeri++;

            indexIleri++;
        }


    });


    $("#ileriKategori").click(function () {

        if (indexGeri != 0) {

            indexGeri--;

            $(".topAlanDiv").eq(indexGeri).show(200);

            $(".topAlan").animate({

                left: "+=" + mesafe + "%"

            }, { duration: 'fast' });


            indexIleri--;

            $(".topAlanDiv").eq(indexIleri).fadeOut(300);


        }


    });


});