using System;
using System.Security.Principal;

namespace Vetores {
    class Cliente {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Cliente(string nome, string email, int quarto) {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString() {
            return Quarto + "- " + Nome + ", " + Email;
        }
    }
}