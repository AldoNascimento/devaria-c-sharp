﻿using System;

namespace ListaDeConvidados
{
    class Program
    {
        private static string[] ListaDeConvidados =
        {
            "Daniel",
            "Evandro",
            "MAtheus",
            "Ale",
            "Teresa",
            "Gabriel",
            "Cledson",
            "Giuseppe",

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado!");
            var nome = Console.ReadLine();

            if(nome == null || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não é valida para seguir com o programa!");
                return;
            }

            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não é valida para  seguir com o programa");
            }

            bool estaConvidado;
            switch (nome)
            {
                case "Daniel":
                    estaConvidado = true;
                    break;
                case "Evandro":
                    estaConvidado = true;
                    break;
                case "Matheus":
                    estaConvidado = true;
                    break;
                case "Ale":
                    estaConvidado = true;
                    break;
                case "Tereza":
                    estaConvidado = true;
                    break;
                case "Gabriel":
                    estaConvidado = true;
                    break;
                case "Cledson":
                    estaConvidado = true;
                    break;
                case "Giuseppe":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            }

            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Parabéns seja bem vindo a festa!!");
            }else if(estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados, favor  verificar com a pessoa que te convidou");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos  para entrar na festa");
            }
        } 
    }
}
