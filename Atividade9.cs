/*Ref. (5 pontos)9 - Escreva um programa que leia um número e verifique se ele é positivo,negativo ou zero.
Nome: Emilly Dias
*/
public static class Atividade9
    { 
    public static void Executar()
    {
        double numero;

        Console.WriteLine ("digite um numero");
      numero = double.Parse(Console.ReadLine()!);

      if (numero > 0)
        {
            Console.WriteLine ($"O número {numero} é positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine ($"O número {numero} é negativo");
        }
        else
        {
            Console.WriteLine ($"O número é zero");
        }
    }
}