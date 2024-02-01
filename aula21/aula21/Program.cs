using System;

class aula21
{
    static void Main()
    {
        // do { } while() Inicializa pelo menos uma vez

        string senha = "123";
        string senhauser;
        int tentativas = 0;
        
        do
        {
            Console.Clear();
            Console.WriteLine("Digire a senha");
            senhauser = Console.ReadLine();
            tentativas++;
        } while (senha != senhauser);

        Console.WriteLine("Senha Correta!! tentativas de acesso {0}: ", tentativas);

    }
}