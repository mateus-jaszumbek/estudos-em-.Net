using System;


class aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o sehundo numero: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1, v2, soma);

        Console.Write("\n Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome Digitado: {0}", nome);
    }
}