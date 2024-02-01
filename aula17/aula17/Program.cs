using System;

class aula17
{
    static void Main()
    {
        int n1, n2, n3, n4, n5;
        int[] n = new int[5]; // a posição sempre vai começar po 0 (basico);
        // int[] num = new int[3] {55, 77, 99};
        // int[] num = { 55, 77, 99, 88, 43 };

        string[] veiculos = new string[5];

        veiculos[0] = "carro";
        veiculos[1] = "Barco";
        veiculos[2] = "Avião";
        veiculos[3] = "Bicicleta";
        veiculos[4] = "Moto";

        n[0] = 111;
        n[1] = 22;
        n[2] = 333;
        n[3] = 4;
        n[4] = 5555;

        Console.WriteLine(n[3]);
        Console.WriteLine(veiculos[3]);
        //Console.WriteLine(num[2]);
    }
}