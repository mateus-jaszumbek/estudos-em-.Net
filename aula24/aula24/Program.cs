using System;

class aula24
{
    static void Main()
    {
        int v1, v2, r;

        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());

        r = Soma(v1, v2);
        Console.WriteLine("Fim");
        Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, r);
    }

    static int Soma(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }
}