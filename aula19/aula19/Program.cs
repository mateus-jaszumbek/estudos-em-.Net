using System;

class aula19
{
    // Estudando sobre o FOR for() {}
    static void Main()
    {

        int[] num = new int[10];

        for(int i = 0 ; i < num.Length; i++) { // num = num + 1 || num += 1 || num++ 
            num[i] = i;
        }

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("Valor de num na pos{0}: {1}", i, num[i]);
        }

    }

}