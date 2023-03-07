using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bau_36365
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Definição dos Objetos


            Bau bau1 = new Bau();
            
            
            bau1.QtdMoedas = 200;
            bau1.BauTrancado = false;
            bau1.EstadoBau = false;

            Bau bau2 = new Bau();


            bau2.QtdMoedas = 120;
            bau2.BauTrancado = true;
            

            Bau bau3 = new Bau();

           
            bau3.QtdMoedas = 0;
            bau3.EstadoBau = true;
            bau3.BauTrancado = false;

            Bau bau4 = new Bau();


            bau4.QtdMoedas = 34;
            bau4.EstadoBau = true;
            bau4.BauTrancado = false;



            #endregion

            #region Chamada dos Baús


            Console.WriteLine("Bem vindo ao programa ");

            Console.WriteLine("Possibilidade 1: Baú Destrancado e Fechado com moedas");

            Console.Write("\n");

            Console.WriteLine(bau1.TrancadoOuDestrancado());

            Console.Write("\n");

            Console.ReadKey();

            Console.WriteLine(bau1.Abrir());

            Console.Write("\n");

            Console.ReadKey();

            Console.WriteLine(bau1.ColetarMoedas());


            Console.Write("\n");

            Console.WriteLine("Aperte ENTER para prosseguir");

            Console.ReadKey();

            Console.Write("\n");

            Console.WriteLine("Possibilidade 2: Baú Trancado com moedas");

            Console.WriteLine();

            Console.WriteLine(bau2.TrancadoOuDestrancado());

            Console.Write("\n");

            Console.ReadKey();

            Console.WriteLine(bau2.Destrancar());

            Console.Write("\n");

            Console.ReadKey();

            Console.WriteLine(bau2.Abrir());

            Console.Write("\n");

            Console.ReadKey();

            Console.WriteLine(bau2.ColetarMoedas());

            Console.Write("\n");


            Console.WriteLine("Aperte ENTER para prosseguir");


            Console.ReadKey();



            Console.Write("\n");

            Console.WriteLine("Possibilidade 3: Baú Destrancado e Aberto possuindo 0 moedas");

            Console.Write("\n");

            Console.WriteLine(bau3.TrancadoOuDestrancado());

            Console.Write("\n");

            Console.Write("\n");


            Console.WriteLine("Aperte ENTER para prosseguir");

            Console.ReadKey();

            Console.Write("\n");

            Console.WriteLine("Possibilidade 4: Baú Destrancado e Aberto com moedas");

            Console.Write("\n");

            Console.WriteLine(bau4.TrancadoOuDestrancado());

            Console.Write("\n");

            Console.ReadKey();

            Console.WriteLine(bau4.ColetarMoedas());

            Console.Write("\n");

            Console.WriteLine("Obrigado por testar todas as possibilidades do meu baú");

            Console.ReadKey();

            #endregion
        }




    }
}
