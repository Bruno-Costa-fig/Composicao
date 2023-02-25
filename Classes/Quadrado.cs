using Composicao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao.Classes
{
    public class Quadrado : IFiguraGeometrica
    {
        public double TamanhoLado { get; set; }
        public double Area()
        {
            return TamanhoLado * TamanhoLado;
        }

        public double Perimetro()
        {
            return TamanhoLado * 4;
        }
    }
}
