using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Concretes;

namespace GameProject.Abstracts
{
    public interface IUyeService 
    {
        void Add(Uye uye);
        void Update(Uye uye);
        void Delete(Uye uye);
    }
}
