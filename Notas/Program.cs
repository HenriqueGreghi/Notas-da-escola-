using OpenXmlPowerTools;
using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();


            Console.WriteLine("Entre com o nome do aluno : ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o endereço : ");
            aluno.Endereco = Console.ReadLine();
            Console.WriteLine("Entre com a idade do aluno :");
            aluno.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota de matemática : ");
            aluno.NotaMatematica = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota de português : ");
            aluno.NotaPortugues = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a nota de geografia: ");
            aluno.NotaGeografia = decimal.Parse(Console.ReadLine());


            aluno.ImprimirNota();
            Console.WriteLine();            
            aluno.ImprimirNota1();


        }
                      
    }
}