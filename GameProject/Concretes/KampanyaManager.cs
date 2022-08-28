using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    public class KampanyaManager : IKampanyaService
    {
        public void Add(Uye uye, Kampanya kampanya)
        {
            Console.WriteLine(uye.UyeAd+ " adlı kullanıcıya kampanya yapıldı. Kampanya ID: "+kampanya.KampanyaId);
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaId + " numaralı kampanya silindi");
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaId + " numaralı kampanya güncellendi");
        }
    }
}
