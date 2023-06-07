using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Exercícios
{
    class Program
    {
        static void Main(string[] args)

        {

            int resposta;



            Console.WriteLine("Digite um número de 1 a 10");
            resposta= int.Parse(Console.ReadLine());
            

            if(resposta <=10)
            {
                Console.WriteLine("- FIM DO PROGRAMA");
                
            }
            else
            {
                Console.WriteLine("Opa! Digite um número válido");
                Main(null);// reinicia o programa
                Console.WriteLine("- FIM DO PROGRAMA");
                
            }
            return; // para a execução do programa
            // os dois podem ser usados em conjunto para reiniciar o programa e cancelar os processos da fila
            


            Console.ReadKey();
            Console.Clear();
            Main(null);
































        }
    }
}
