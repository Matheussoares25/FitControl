using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FItcontrol
{
     class Menu
    {
        public string Unidades {  get; set; }
        public string Alunos { get; set; }

        public string Planos { get; set; }

        public void Hud()
        {
            Console.WriteLine("========= BEM VINDO AO FIT CONTROL =========\n");
            Console.WriteLine("Selecione a opcao:\n");
            Console.WriteLine("1. Planos\n");
            string res = Console.ReadLine();
        }
    }
}
