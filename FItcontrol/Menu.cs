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
            Console.WriteLine
            string res = Console.ReadLine();

            switch (res)
            {
                case 1:
                    Console.WriteLine("Você escolheu verificar os planos disponíveis!");
                    Console.WriteLine("1. Listar planos.");
                    Console.WriteLine("2. Sair.");
                    string res1 = Console.ReadLine();

                    if (res1 == "2"{
                        Console.WriteLine("ABCD");
                    })
                    res = Console.ReadLine();
                    

                case 2:
                    Console.WriteLine("Você escolhe"
            }

        }
    }
}
