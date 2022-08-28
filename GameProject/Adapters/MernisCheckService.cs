 using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceAdapterReference;
using GameProject.Abstracts;
using GameProject.Entities;
using GameProject.Concretes;
using System.Threading.Tasks;
namespace GameProject.Adapters
{
    public class MernisCheckService : IUyeCheckService
    {
        public bool KimlikDogrula(Uye uye)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(uye.TCKimlikNo), uye.UyeAd, uye.UyeSoyad, Convert.ToInt32(uye.DogumYil)).Result.Body.TCKimlikNoDogrulaResult; 
            return true;
        }
    }
}
