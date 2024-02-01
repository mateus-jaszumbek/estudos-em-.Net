using System;

class aula22
{           
    // Aprendendo a usar FOREACH(){}
    static void Main()
    {
        int[] num = new int[3] { 11, 22, 33 };


        //for (int i = 0; i < num.Length; i++) // FOR para inciar e interar
        //{
        //    Console.WriteLine(num[i]);
        //}

        foreach (int n in num) { // Variavel de inteação e não atribuição 
            Console.WriteLine(n);
        }
    }
}