/* Ref (5 pontos) 2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.
Nome:Emilly Dias
*/
public static class Atividade2
{
    public static void Executar()

    {
        Console.Clear();

        Console.WriteLine ("Digite a Letra");
        string letra = Console.ReadLine()!;

        
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" ||letra == "u")
        { 
          Console.WriteLine ("A letra é uma Vogal");
        }
        else
        {
          Console.WriteLine ("A letra é uma Consoante");
        }

        }
}