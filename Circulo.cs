﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_tls
{
    internal class Circulo
    {
        private float r;
        public Circulo(float r) 
        {
            this.r = r;
        }
        public float Area() => 3.14f * r * r;
    }
}
