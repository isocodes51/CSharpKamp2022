using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstracts;

namespace GameProject.Concretes
{
    public class StandartUyeManager : IUyeService
    {
        IUyeCheckService _uyeCheckService;

        public StandartUyeManager(IUyeCheckService uyeCheckService)
        {
            _uyeCheckService = uyeCheckService;

        }

        public StandartUyeManager()
        {
        }

        public void Add(Uye uye)
        {
            if(_uyeCheckService.KimlikDogrula(uye))
              Console.WriteLine(uye.UyeAd + " adli Yeni Üye Eklendi.." );
           
            else
                Console.WriteLine("Doğrulama Başarısız Kayıt Başarısız");
        }

        public void Update(Uye uye)
        {
            Console.WriteLine(uye.UyeAd+" isimli Üye bilgileri güncellendi");
        }

        

        public void Delete(Uye uye)
        {
            Console.WriteLine(uye.UyeAd+" isimli üyenin bilgileri silindi");
        }
    }
}
