using Entity.Concrete;
using Entity.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme.Areas.Admin.Models
{
    public class odemeSecenekleriFotograf
    {
        public static string FotografYukle(List<IFormFile> files, IWebHostEnvironment _env, out bool result, SqlDbContext context, odemeSecenekleri item)
        {
            //Resim yükleme işlemlerimizi gerçekleştiriyoruz.
            //Geriye resim yolunu veya hata mesajını döndürüyoruz.
            //Ayrıca dönen string'in başarı bilgisi mi veya hata mesajımı olduğunu
            //anlamamızı kolaylaştırması açısından bir değer fırlatıyoruz.
            result = false;
            var uploads = Path.Combine(_env.WebRootPath, "odemeSecenekleriFotograflar");

            foreach (var file in files)
            {
                if (file.ContentType.Contains("image"))
                {
                    if (file.Length <= 2097152)
                    {
                        string uniqueName = $"{Guid.NewGuid().ToString().Replace("-", "_").ToLower()}.{file.ContentType.Split('/')[1]}";
                        var filePath = Path.Combine(uploads, uniqueName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                            result = true;

                            var field = context.odemeSecenekleri.Find(item.Id);

                            var bir = field.odemeSecenekleriFoto.Split("/")[0]; 
                            var iki = field.odemeSecenekleriFoto.Split("/")[1];
                            var link = bir + "\\" + iki;

                            //odemeSecenekleriFotograflar/126456de_5746_422b_8225_1e1906d87fda.webp
                            var up = Path.Combine(_env.WebRootPath, link);

                            if (System.IO.File.Exists(up))
                            {
                                System.IO.File.Delete(up);
                            }
                            var uc = filePath.Split("\\")[8];
                            var dort = filePath.Split("\\")[9];
                            var yol = uc + "/" + dort;
                        //C: \Users\batu\source\repos\E_Ticaret_Projesi\Tasarim_Bolumu\wwwroot\odemeSecenekleriFotograflar\23e754cd_2370_43de_8231_b35036df389d.webp
                            //return filePath.Substring(filePath.IndexOf("odemeSecenekleriFotograflar/"));
                            return yol;
                        }
                    }
                    else
                    {
                        return $"2MB'dan büyük boyutta resim yükleyemezsiniz.";
                    }
                }
                else
                {
                    return $"Lütfen sadece resim dosyası yükleyin.";
                }
            }
            return "Dosya bulunamadı! Lütfen en az bir dosya seçin.";
        }
    }
}
