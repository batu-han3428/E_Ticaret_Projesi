$(function(){

  
            var indexGeri = 0;
            var indexIleri = $(".topAlanDiv").length - 2;
            var mesafe = 11;

            $(".topAlanDiv").slice(indexGeri,7).show();
            $(".topAlanDiv").slice(7).hide();


            $("#geriKategori").click(function(){
                
                if(indexIleri < 9){
                
                    $(".topAlan").animate({

                        left:"-="+mesafe+"%"        
                            
                    },{duration: 'fast'});
                
                    $(".topAlanDiv").eq(indexGeri).fadeOut(300);
                   
                    $(".topAlanDiv").eq(indexIleri).show();

                    indexGeri++;
                
                    indexIleri++;
                }
            

            });


            $("#ileriKategori").click(function(){
                
                if(indexGeri != 0){

                    indexGeri--;

                    $(".topAlanDiv").eq(indexGeri).show();

                    $(".topAlan").animate({

                            left:"+="+mesafe+"%"        

                    },{duration: 'fast'});

                    
                    indexIleri--;

                    $(".topAlanDiv").eq(indexIleri).fadeOut(300);


                }
            

            });

    
});