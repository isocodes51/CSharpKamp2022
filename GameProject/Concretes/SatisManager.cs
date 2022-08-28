using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstracts;
using GameProject.Entities;

namespace GameProject.Concretes
{
    public class SatisManager : ISatisService
    {
        public void Add(Uye uye, Satis satis, Kampanya kampanya)
        {
            Console.WriteLine(uye.UyeAd+" adlı uyeye " + satis.SatisYapilanOyunAdi+" adlı oyun satıldı. Kampanya ID:" + kampanya.KampanyaId);
        }
    }
}
