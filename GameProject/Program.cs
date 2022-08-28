using System;
using GameProject.Entities;
using GameProject.Concretes;
using GameProject.Abstracts;
using GameProject.Adapters;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Uye uye = new Uye {UyeId =1, UyeAd="Kamil", UyeSoyad="Doğan", DogumYil="1985", TCKimlikNo="1234567897", UyelikUcreti=25 };
            IUyeService uyeManager = new StandartUyeManager(new MernisCheckService());
            //StandartUyeManager uyeManager = new StandartUyeManager(new MernisCheckService());

            uyeManager.Add(uye);

            IKampanyaService kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(uye, kampanya);

            Satis satis = new Satis { SatisId = 1, SatisYapilanOyunId = 115, SatisYapilanOyunAdi="Game of Thrones II", Aciklama = "Game of Thrones II ® 2022 Ensemble Studios", Fiyat = 125 };
            ISatisService satisManager = new SatisManager();
            satisManager.Add(uye, satis, kampanya);

            Kampanya kampanya = new Kampanya
            {
                KampanyaId = 1,
                KampanyaBitis = new DateTime(2022, 9, 12),
                Aciklama = "Yeni Oyunlarda %10 indirim",
                indirimOrani = 10
            };

            
            
        }
    }
}
