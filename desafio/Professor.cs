using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    class Professor
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Materias> Materiasl { get; set; } = new List<Materias>();
        public double Aumento { get; set; }
        
        public Professor()
        {
        }

        public Professor(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
        public Professor(double aumento)
        {
            Aumento = aumento;
        }
        public void AddMateria(Materias materia)
        {
            Materiasl.Add(materia);
        }
        public double AumentoSalario(double aumento)
        {
            return Salario + aumento;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + Nome+" , Salario: R$"+Salario.ToString("F2"));
            sb.AppendLine("Materias: ");
            foreach (Materias materia in Materiasl)
            {
                sb.AppendLine(materia.ToString());
            } 
            return sb.ToString();
        }
    }
}
