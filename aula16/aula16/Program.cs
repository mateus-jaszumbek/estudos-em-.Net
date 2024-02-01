using System;

class aula16
{
    static void Main()
    {
        float hora = 0;
        int tempo = 0;
        char escolha;

    inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
        Console.WriteLine("Escolha o transporte: \n [a] - Avião \n [c] - Carro \n [O] - ônibus");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a': tempo = 50; break;
            case 'b': tempo = 460; break;
            case 'c': tempo = 660; break;
            default: Console.WriteLine("Escolha uma opção valida"); break;
        }

        hora = (float)tempo;

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponivel");
        }
        else
        {
            Console.WriteLine("O Tempo de viagem escolhido para o transposte é {0} e {1} hora(s)", tempo, (hora / 60));
        }

        Console.WriteLine("\n Calcular outro transporte? \n [S/Ñ]: ");

        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim de programa!!");
        }

    }
}