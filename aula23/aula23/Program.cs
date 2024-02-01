﻿using System;

class aula23
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elemento do vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        //public static int binarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} esta na posição {1}", procurado, pos);
        Console.WriteLine("------------------------------------------------");

        //public static void copy(ar_origem,Ar_destino,qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");

        //public void copyTp(Ar_destino,a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdElementoVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elemento {0}", qtdElementoVetor);
        Console.WriteLine("---------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do valor1 {0}", MenorIndiceVetor);
        Console.WriteLine("---------------------------------------");

        //public int GetUpperBound(dimessão);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int maiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor {0}", MaiorIndiceVetor);
        Console.WriteLine("---------------------------------------------");

        //public object GetValeu(long indice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor de posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("--------------------------------------------------");

        //public static int indexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("----------------------------------------------");

        //public static int LastIndexOf(array, valor);
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do   valor 33:{0}", indice2);
        Console.WriteLine("----------------------------------------------");

        //public static void reverse(array);
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        //public void setValue(object valor, long pos);
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }

        //public static void sort(array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
    }
}