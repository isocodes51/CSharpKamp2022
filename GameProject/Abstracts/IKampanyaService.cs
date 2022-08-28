using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Concretes;

namespace GameProject.Abstracts
{
    public interface IKampanyaService
    {
        void Add(Uye uye, Kampanya kampanya);
        void Update(Kampanya kampanya);
        void Delete(Kampanya kampanya);
    }
}
