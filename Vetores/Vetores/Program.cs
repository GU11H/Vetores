using System;
using System.Diagnostics.CodeAnalysis;

namespace Vetores {
    class Programa {
        public static void Main(String[] args) {

            Console.Write("Quantos quartos serão alugados?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Cliente[] VetorAluguel = new Cliente[10];
            for (int i = 1; i <= qtdQuartos; i++) {

                Console.WriteLine("Aluguel " + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Qual quarto?");
                int quarto = int.Parse(Console.ReadLine());

                VetorAluguel[quarto] = new Cliente(nome, email, quarto);

            }
            Console.WriteLine();
            Console.WriteLine("Os quartos ocupados são:");

            for (int i = 0; i < 10; i++) {
                if (VetorAluguel[i] != null) {
                    Console.WriteLine(VetorAluguel[i]);

                   
                }
            }
        }
    }
}