using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Core.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public  string Telefone { get; set; }
        public string Documento { get; set; }

    }
}
