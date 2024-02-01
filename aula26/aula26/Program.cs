using System;

class aula26
{

    static void Main()
    {
        int divid, divs, quoc, rest;
        divid = 10;
        divs = 3;
        quoc = divide(divid, divs, out rest);

        Console.WriteLine(" {0} / {1}: quociente = {2} e resto: {3} ", divid, divs, quoc, rest);

    }

    static int divide(int dividendo, int divisor, out int resto)
    {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}