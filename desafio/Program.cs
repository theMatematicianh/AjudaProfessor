using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do Aluno:");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("Matricula:");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Primeira Nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            
          
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("A nota é invalida, digite outra nota:");
                    nota1 = double.Parse(Console.ReadLine());
                }
            
            
            Console.WriteLine("Segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

           
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("A nota é invalida, digite outra nota:");
                    nota2 = double.Parse(Console.ReadLine());
                }
            

            Console.WriteLine("");

            Aluno aluno = new Aluno(nomeAluno, matricula, nota1, nota2);

            Console.WriteLine("Nome do professor:");
            string nome = Console.ReadLine();
            Console.WriteLine("Salario: R$");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de materias do professor:");
            int n = int.Parse(Console.ReadLine());

            Professor professor = new Professor(nome, salario);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nome da materia:");
                string nomeMateria = Console.ReadLine();
                Console.WriteLine("O periodo:");
                string periodo = Console.ReadLine();
                Console.WriteLine("Para qual série e dada a matéria:");
                int grau = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                Materias materias = new Materias(nomeMateria, periodo, grau);

                professor.AddMateria(materias);

            }
        


            Console.WriteLine("Informações do aluno:");
            Console.WriteLine(aluno);
            Console.WriteLine("Informaçoes do Professor:");
            Console.WriteLine(professor);
            Console.WriteLine("Deseja dar um aumento de salario para o professor?(s/n)");
            char x = char.Parse(Console.ReadLine());
            
            if(x == 's')
            {
                Console.WriteLine("Qual o valor do aumento?");
                Console.Write("R$");
                double aumento = double.Parse(Console.ReadLine());

                Professor mais = new Professor(aumento);

                Console.WriteLine("Novo Salario:");
                Console.WriteLine(professor.AumentoSalario(aumento).ToString("F2"));
            }
            
           

          



        }
    }
}
