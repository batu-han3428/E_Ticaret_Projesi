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
    public class tusFotograf
    {
        public static string FotografYukle(List<IFormFile> files, IWebHostEnvironment _env, out bool result, SqlDbContext context, slider item)
        {
            //Resim yükleme işlemlerimizi gerçekleştiriyoruz.
            //Geriye resim yolunu veya hata mesajını döndürüyoruz.
            //Ayrıca dönen string'in başarı bilgisi mi veya hata mesajımı olduğunu
            //anlamamızı kolaylaştırması açısından bir değer fırlatıyoruz.
            result = false;
            var uploads = Path.Combine(_env.WebRootPath, "sliderFotograflar");

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

                            var field = context.slider.Find(item.Id);

                            var yeni = field.fotografAdiTus.Substring(1);

                            var up = Path.Combine(_env.WebRootPath, yeni);
                          
                            if (System.IO.File.Exists(up))
                            {
                                System.IO.File.Delete(up);
                            }


                            return filePath.Substring(filePath.IndexOf("\\sliderFotograflar\\"));
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
