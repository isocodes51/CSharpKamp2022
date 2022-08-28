using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Concretes;

namespace GameProject.Abstracts
{
    public interface ISatisService
    {
        void Add(Uye uye, Satis satis, Kampanya kampanya );
    }
}
