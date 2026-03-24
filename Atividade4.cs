/*Ref (15 pontos)4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente, tal que 0 é a menor nota e 10 a maior,
 e imprimir o conceito equivalente (A, B, C, D ou E), conforme a seguinte tabela: A - nota >= 8,5 e nota <= 10 B - nota >= 7 e 
 nota < 8,5 C - nota >= 5 e nota < 7 D - nota >= 3 e nota < 5 E - nota < 3
 Nome:Emilly Dias
 */

 public static class Atividade4
{
    public static void Executar()
    {
      double N1;
      double N2;
      double media;
      double notaA = 0;
      double notaB= 0;
      double notaC = 0;
      double notaD = 0;
      double notaE =0;
      double notaFinal;

        Console.WriteLine ("digite a nota Primeira Nota");
       N1 = double.Parse(Console.ReadLine()!);

       Console.WriteLine ("digite a Segunda Nota");
       N2 = double.Parse(Console.ReadLine()!);

    media = (N1+N2)/2;

    if ( media <= 10 && media >= 8.5)

        {
            notaFinal =  notaA;
            Console.WriteLine ($"A media é de {media}, logo nota: A ");
        }

    else if (media < 8.5 && media >= 7)
     
        {
            notaFinal =  notaB;
            Console.WriteLine ($"A media é de {media}, logo nota: B");
        }
     

    else if(media < 7 && media >= 5)
     
        {
            notaFinal =  notaC;
            Console.WriteLine ($"A media é de {media}, logo nota: C");
        }
     

    else if(media < 5 && media >= 3)

        {
            
        notaFinal =  notaD;
            Console.WriteLine ($"A media é de {media}, logo nota: D");
        
        }

    else if(media < 3 )


        {
            notaFinal =  notaE;
            Console.WriteLine ($"A media é de {media}, logo nota: E");
        }
    }
}