/*Ref (5 pontos)1 - Faça um programa que calcule e apresente o valor do volume de uma lata, sabendo que PI é um valor constante de 3.14159,
 o programa deve pedir os valores de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome: Emilly Dias
*/

public static class Atividade1
{
    public static void Executar()
    {
        double volume;
        double pi = 3.14159;
        double altura;
        double raio;

      Console.WriteLine ("digite o valor do raio");
      raio = double.Parse(Console.ReadLine()!);

      Console.WriteLine ("digite o valor da altura");
      altura = double.Parse(Console.ReadLine()!);

      volume = pi * (raio * raio) * altura;

      Console.WriteLine ($"O volume da lata é {volume}");

     
    }
}
