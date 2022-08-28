
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Kampanya
    {
        public int KampanyaId { get; set; }
        public string Aciklama { get; set; }

        public int indirimOrani { get; set; }
        public DateTime KampanyaBitis { get; set; }
    }
}
