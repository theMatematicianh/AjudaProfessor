using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    class Aluno
    {
        public string  NomeAluno { get; set; }
        public int Matricula { get; set; }
        public double Nota1 { get; set; }
        public double  Nota2 { get; set; }
        public string Aprovado { get; set; }

        public Aluno(string nomeAluno, int matricula, double nota1, double nota2)
        {
            NomeAluno = nomeAluno;
            Matricula = matricula;
            Nota1 = nota1;
            Nota2 = nota2;
         
        }
        public double Media()
        {
            return (Nota1 + Nota2) / 2;
        }
        public string AvaliarMedia()
        {
           
            if (Media() < 4)
            {
              return  "Aluno Reprovado" ;
            }
            else if (Media() > 4 && Media() <6) 
            {
                return "Aluno de recuperação";
            }
            else if(Media() >= 6)
            {
                return "Parabéns, você passou";
            }
            return "nada";
        }
        public override string ToString()
        {
            return "Nome do aluno: "+NomeAluno+" ,Matricula: "+Matricula+" ,Primeira nota: "+Nota1+ " ,Segunda nota: " + Nota1 +" ,Media do aluno: " + Media().ToString("F1")+" ,Avaliação da media do aluno: "+AvaliarMedia();
        }
    }
}
