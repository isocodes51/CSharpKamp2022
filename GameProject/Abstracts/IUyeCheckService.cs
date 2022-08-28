using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Concretes;
using GameProject.Adapters;

namespace GameProject.Abstracts
{
    public interface IUyeCheckService
    {
       bool KimlikDogrula(Uye uye);
    }
}
