using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FItcontrol
{

    public enum genero
    {
        Masculino,
        Feminino
    }
    public class Aluno
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public genero Genero { get; set; }
        public string Matricula { get; set; }

    }
}
