using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FItcontrol
{
     class Menu:Aluno
    {


        public void Hud()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("========= BEM VINDO AO FIT CONTROL =========\n");
                Console.WriteLine("Selecione a opcao:\n");
                Console.WriteLine("1. Planos\nQ. Sair.");
                string res = Console.ReadLine();
                Console.Clear();
                res = res.ToUpper();

                switch (res)
                {
                    case "1":
                        Console.WriteLine("Você escolheu verificar os planos disponíveis! Selecione a opcao deseja: \n\n");
                        Console.WriteLine("1. Listar planos.\nQ. Sair.");
                        string res1 = Console.ReadLine();
                        res1 = res1.ToUpper();
                        Console.Clear();
                        switch (res1)
                        {
                            case "1":
                                Console.WriteLine("Selecione a opcao deseja: \n\n1. Cadastrar Plano Basico.\n2. Cadastrar Plano Premium.\nQ. Sair.");
                                string res2 = Console.ReadLine();
                                res2 = res2.ToUpper();
                                switch (res2)
                                {
                                    case "1":

                                        MySqlConnection conexao;
                                        conexao = new MySqlConnection("server=127.0.0.1;uid=root;pwd='';database=academia; Port=3306");

                                        try
                                        {
                                            conexao.Open();
                                        }
                                        catch (MySqlException erro)
                                        {
                                            Console.WriteLine("Erro ao conectar ao banco de dados. \n" + erro.Message);
                                        }


                                        Console.Clear();
                                        Cadastrar();
                                        Console.Clear();

                                        string sqlInsert = "INSERT INTO alunos (Nome_al, CPF_al, Idade_al, Genero_al) VALUES (@nome, @cpf, @idade, @genero)";
                                        MySqlCommand cmdCa = new MySqlCommand(sqlInsert, conexao);
                                        cmdCa.Parameters.AddWithValue("@nome", this.Nome);
                                        cmdCa.Parameters.AddWithValue("@cpf", this.Cpf);
                                        cmdCa.Parameters.AddWithValue("@idade", this.Idade);
                                        cmdCa.Parameters.AddWithValue("@genero", this.Genero);

                                        Console.WriteLine("Aluno Cadastrado no Plano Basico!! \n\nPressione ENTER para continuar...");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;

                                    case "2":

                                        conexao = new MySqlConnection("server=127.0.0.1;uid=root;pwd='';database=academia; Port=3306");

                                        try
                                        {
                                            conexao.Open();
                                        }
                                        catch (MySqlException erro)
                                        {
                                            Console.WriteLine("Erro ao conectar ao banco de dados. \n" + erro.Message);
                                        }


                                        Console.Clear();
                                        Cadastrar();
                                        Console.Clear();

                                        string sqlInsert1 = "INSERT INTO alunos (Nome_al, CPF_al, Idade_al, Genero_al) VALUES (@nome, @cpf, @idade, @genero)";
                                        MySqlCommand cmdCa1 = new MySqlCommand(sqlInsert1, conexao);
                                        cmdCa1.Parameters.AddWithValue("@nome", this.Nome);
                                        cmdCa1.Parameters.AddWithValue("@cpf", this.Cpf);
                                        cmdCa1.Parameters.AddWithValue("@idade", this.Idade);
                                        cmdCa1.Parameters.AddWithValue("@genero", this.Genero);

                                        Console.WriteLine("Aluno Cadastrado no Plano Premium!! \n\nPressione ENTER para continuar...");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.WriteLine("Opcao Invalida!");
                                        Console.ReadLine();
                                        break;
                                }
                                break;

                        }
                        break;
                    case "Q":
                        Console.WriteLine("Pressione ENTER para sair...");
                        Console.ReadLine();
                        con = false;
                        break;

                    default:
                        Console.WriteLine("Opcao Invalida");
                        Console.WriteLine("Pressione ENTER para sair...");
                        Console.ReadLine();
                        con = false;
                        break;
                }
            }
        }
        
        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a tela de cadastro! Responda as informações abaixo:\n\nDigite seu nome:");
            this.Nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu CPF:");
            this.Cpf = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite sua idade:");
            this.Idade = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Informe seu genero (Feminino/Masculino)");
            this.Genero = Console.ReadLine();
        }
    }
}
