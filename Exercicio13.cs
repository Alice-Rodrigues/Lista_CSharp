
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
