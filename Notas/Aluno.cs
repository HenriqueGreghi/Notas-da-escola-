using System;
using System.Collections.Generic;
using System.Text;

namespace Notas
{
    class Aluno
    {
        public string Nome;
        public string Endereco;
        public int Idade;
        public decimal NotaMatematica;
        public decimal NotaPortugues;
        public decimal NotaGeografia;

        public Aluno()
        {
        }

        public Aluno(string nome, string endereco, int idade, decimal notaMatematica, decimal notaPortugues, decimal notaGeografia)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
            NotaMatematica = notaMatematica;
            NotaPortugues = notaPortugues;
            NotaGeografia = notaGeografia;

        }
        public void ImprimirNota()
        {
          

            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("Endereço :" + Endereco);
            Console.WriteLine("Idade : " + Idade);
            Console.WriteLine("Nota de Matemática : " + NotaMatematica);
            Console.WriteLine("Nota de  Português : " + NotaPortugues);
            Console.WriteLine("Nota de Geografia : " + NotaGeografia);
        }

        public void ImprimirNota1()
        {
          

            
            Console.WriteLine("Escolha qual matéria deseja imprimir : ");
            Console.WriteLine("M - Matemática : ");
            Console.WriteLine("P - Português : ");
            Console.WriteLine("G - Geografia");

            char nota = char.Parse(Console.ReadLine());

            if (nota == 'M'|| nota =='m')
            {
                Console.WriteLine("Nome : " + Nome);
                Console.WriteLine("Endereço :" + Endereco);
                Console.WriteLine("Idade : " + Idade);
                Console.WriteLine("Nota de Matemática : " + NotaMatematica);
            }

            else if (nota == 'p' || nota == 'P' )
            {
                Console.WriteLine("Nome : " + Nome);
                Console.WriteLine("Endereço :" + Endereco);
                Console.WriteLine("Idade : " + Idade);
                Console.WriteLine("Nota de Português : " + NotaPortugues);
            }

            else if (nota == 'g' || nota == 'G')
            {
                Console.WriteLine("Nome : " + Nome);
                Console.WriteLine("Endereço :" + Endereco);
                Console.WriteLine("Idade : " + Idade);
                Console.WriteLine("Nota de Geografia : " + NotaGeografia);


            }
            else
            {
                Console.WriteLine("Matéria não encontrada!");
            }

        }
    }
}

