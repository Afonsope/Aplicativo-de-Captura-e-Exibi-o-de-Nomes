/* Codigo feito pelo Afonsope */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_de_Captura_e_Exibi_o_de_Nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[15];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write($"Entre com o {i + 1}° nome : ");
                nome[i] = Console.ReadLine();
            }

            int t = 1;

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"O {t}° nome digitado era : {nome[i]}");
                t++;
            }
            Console.Read();
        }
    }
}
