using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        public decimal valorHora;

        public int  Cilindrada {get; set;}

        private Moto()
        {
            valorHora = 1000;
        }

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
    }
}
