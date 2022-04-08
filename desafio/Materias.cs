using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    class Materias
    {
        public string NomeMateria { get; set; }
        public string Periodo { get; set; }
        public  int Grau { get; set; }
    

        public Materias()
        {

        }


        public Materias(string nomeMateria, string periodo, int grau)
        {
            NomeMateria = nomeMateria;
            Periodo = periodo;
            Grau = grau;
        }
        public override string ToString()
        {
            return "Nome: "+ NomeMateria+ " , Periodo: "+ Periodo+" , Grau: "+Grau;
        }
    }
}
