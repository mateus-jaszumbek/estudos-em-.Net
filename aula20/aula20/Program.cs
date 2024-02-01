using System;

class aula20
{
    //WHILE não sei quando quero repetir
    static void Main()
    {
        int[] num = new int[10];

        int i = num.Length - 1;
        while (i > 0)
        {            
            num[i] = i;
            Console.WriteLine("Mateus Jaszumbek {0}: ", num[i]);
            i--;                
        }
        Console.WriteLine("Fim do loop");

    }

}