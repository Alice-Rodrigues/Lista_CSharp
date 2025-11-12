/******************************************************************************
Números em Ordem Crescente Peça 5 números e mostre-os em ordem crescente. 
Objetivo: uso de arrays e método Array.Sort().
*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        string senha = "123";
        int tentativas = 0;
        while (tentativas < 3) 
        {
            Console.Write("Digite a senha: ");
            string tentativa = Console.ReadLine();
            if (tentativa == senha) 
            {
                Console.WriteLine("Acesso permitido!");
                return;
            }
            tentativas++;
            Console.WriteLine("Senha incorreta!");
         }
        Console.WriteLine("Número de tentativas excedido!"); 
    }
}
