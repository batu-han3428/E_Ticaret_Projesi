$(function(){

  
            var indexGeriMobil = 0;
            var indexIleriMobil = $(".topAlanDivMobil").length - 6;
            var mesafeMobil = 11;

            $(".topAlanDivMobil").slice(indexGeriMobil,3).show();
            $(".topAlanDivMobil").slice(3).hide();


            $("#geriKategoriMobil").click(function(){
                
                if(indexIleriMobil < 9){
                
                    $(".topAlanMobil").animate({

                        left:"-="+mesafeMobil+"%"        
                            
                    },{duration: 150});
                
                    $(".topAlanDivMobil").eq(indexGeriMobil).fadeOut(150);

                    $(".topAlanDivMobil").eq(indexIleriMobil).show(300);

                    indexGeriMobil++;
                
                    indexIleriMobil++;
                }
            

            });


            $("#ileriKategoriMobil").click(function(){
                
                if(indexGeriMobil != 0){

                    indexGeriMobil--;

                    $(".topAlanDivMobil").eq(indexGeriMobil).show(300);

                    $(".topAlanMobil").animate({

                            left:"+="+mesafeMobil+"%"        

                    },{duration: 150});

                    
                    indexIleriMobil--;

                    $(".topAlanDivMobil").eq(indexIleriMobil).fadeOut(150);


                }
            

            });

    
});