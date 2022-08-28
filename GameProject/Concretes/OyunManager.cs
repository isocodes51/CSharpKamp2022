using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstracts;
using GameProject.Entities;

namespace GameProject.Concretes
{
    public class OyunManager : IOyunService
    {
        public void Add(Oyun oyun)
        {
            Console.WriteLine(oyun +" adlı oyun eklendi");
        }
    }
}
