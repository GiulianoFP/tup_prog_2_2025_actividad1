using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
public class Rectangulo
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public Rectangulo(double ancho,double largo)
            {
                Ancho = ancho;
                Largo = largo;  
            }
        public double CalcularArea()
            {
                return Ancho * Largo;
            }
        public string Describir()
            {
                return $"Rectangulo:{Ancho},{Largo}";
            }
    }
}
