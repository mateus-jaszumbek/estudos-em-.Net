using System;

class aula15
{
    static void Main()
    {
        int tempo = 0;
        float hora = 0;
        char escolha;

        Console.WriteLine(" Belo horizonte/MG a Vitoria/ES");
        Console.WriteLine("\n Escolha o transporte: \n [a] - Avião \n [c] - CArro \n [O] - Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                tempo = 50;
                break;
            case 'c':
                tempo = 480;
                break;
            case 'o':
                tempo = 660;
                break;
            default:
                Console.WriteLine("Escolha uma opção valida");
                break;
        }

        hora = (float)tempo;

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponivel");
        } else
        {
            Console.WriteLine("\n Tempo para o transporte escolhido é: {0} minutos ou {1} hora(s) ", tempo, (hora / 60));
        }
    }
}