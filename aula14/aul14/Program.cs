﻿using System;

class aula12
{
    static void Main()
    {

        // IF() {} else if() {} else {};

        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;


        Console.WriteLine("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        // >= 60 - Aprovado
        // 59 a 40 - Recuperação
        // <40 - Reprovado

        string resultado;

        if (res >= 60)
        {
            if (res >= 90)
            {
                if (res >= 99)
                {
                    resultado = "Aprovado com super louvor";
                }
                else
                {
                    resultado = "Aprovado com louvor";
                }
            }
            else
            {
                resultado = "Aprovado";
            }
        }
        else
        {
            if (res >= 40)
            {
                resultado = "Recuperação";
            } else
            {
                resultado = "Aprovado"; 
            }
        }
               
   

Console.WriteLine("Nota: {0} -  Resultado:{1}", res, resultado);
    }
}