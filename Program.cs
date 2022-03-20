using System;
using System.Collections.Generic;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1   = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1  = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;


            //T1 - Somar a idade de todos Ubuntus
            int somaIdade = idade1+idade2+idade3;
            Console.WriteLine(somaIdade);
            //T2 - Agrupar os nomes de todos Ubuntus
            List<string> nomesUbuntus = new List<string>();
            nomesUbuntus.Add(nome1);
            nomesUbuntus.Add(nome2);
            nomesUbuntus.Add(nome3);
            foreach (string nome in nomesUbuntus)
                {
                    Console.WriteLine(nome);
                }
            //T3 - Calcular Média dos IMC de todos Ubuntus
            double imc1 = peso1/(double)(altura1*altura1);
            double imc2 = peso2/(double)(altura2*altura2);
            double imc3 = peso3/(double)(altura3*altura3);
            double imcTotal = (imc1+imc2+imc3)/3;
            Console.WriteLine(imcTotal);
            //T4 - Contar quantos Ubuntus sao Devs
            int totalDevs = 0;
            if (EhDev1 == true)
                totalDevs++;
            if (EhDev2)
                totalDevs = totalDevs + 1;
            totalDevs+= EhDev3? 1 : 0;     
            Console.WriteLine(totalDevs);
            
            //T5 - Exibir somente Ubuntu com nome Silva
            PrintUbuntus(nome1);
            PrintUbuntus(nome2);
            PrintUbuntus(nome3);

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }
        static void PrintUbuntus(string nome)
        {
            if(nome.IndexOf("Silva")!= -1)
                Console.WriteLine(nome);
        }

    }
}
