using System;

class aula25
{

    static void Main()
    {
        int num = 30;

        Dobrar1(num);
        Dobrar(ref num);
        Console.WriteLine(num);
     

    }

    static void Dobrar(ref int valor)
    {
        valor *= 2;
    }
    static void Dobrar1(int valor)
    {
        valor *= 2;
    }

}