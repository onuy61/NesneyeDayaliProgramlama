﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3_b201210500
{
    class Mandalina : Fruit
    {
        public override int Vitamina { get; set; }
        public override string Tur { get; set; }
        public override int Vitaminc { get; set; }
        public override int Agirlik { get; set; }
      // public override Image Image { get; set; }
        public Mandalina(int agirlik, Image image)
        {
            Agirlik = agirlik;
            Image = image;
            Vitamina = 681;
            Vitaminc = 26;
            Tur = "Narenciye";

        }

        
    }
}