﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class Fyrkant : Form
    {
        public double Sida { get; private set; }
        public double Omkrets { get; private set; }

        public Koordinat kordinaterFörEnFykant;
        

        public double Ymin { get; private set; }
        public double Ymax { get; private set; }
        public double Xmax { get; private set; }
        public double Xmin { get; private set; }

        public override double GetArea()
        {
            return Sida * Sida;
        }
        public Fyrkant(string form,Koordinat koordinat, double omkrets, int shapeScore) : base(form, koordinat, omkrets, shapeScore, 4)
        {
            kordinaterFörEnFykant = koordinat;
            Sida = omkrets / 4;
            Xmax = kordinaterFörEnFykant.x + (Sida / 2);
            Xmin = kordinaterFörEnFykant.x - (Sida / 2);
            Ymax = kordinaterFörEnFykant.y + (Sida / 2);
            Ymin = kordinaterFörEnFykant.y - (Sida / 2);
        }
        override public bool IsInside (Koordinat punkt)
        {

            if (punkt.x < Xmax && punkt.x > Xmin && punkt.y < Ymax && punkt.y > Ymin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
