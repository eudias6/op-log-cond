/*Ref. (10 pontos)3 - Escreva um programa que receba três números inteiros e mostre eles em ordem crescente.
Nome: Emilly Dias
*/
public static class Atividade3
{
    public static void Executar()
    {
        int num1; //menor
        int num2; //medio
        int num3; //maior
        int menorN = 0;
        int medioN = 0;
        int maiorN = 0;
     
     Console.WriteLine("Digite o 1º número:");
        num1 = int.Parse(Console.ReadLine()!);

     Console.WriteLine("Digite o 2º número:");
        num2 = int.Parse(Console.ReadLine()!);

     Console.WriteLine("Digite o 3º número:");
        num3 = int.Parse(Console.ReadLine()!);            
     
     if ( num1 > num2 || num1 > num3 )
        {
            if ( num1 > num2 && num1 > num3 )
            {
                maiorN = num1;
            }
            else
            {
                medioN = num1;
            }
        }
        else
        {
            menorN = num1;
        }


        if ( num2 > num1 || num2 > num3 )
        {
            if ( num2 > num1 && num2 > num3 )
            {
                maiorN = num2;
            }
            else
            {
                medioN = num2;
            }
        }
        else
        {
            menorN = num2;
        }

        if ( num3 > num2 || num3 > num1 )
        {
            if ( num3 > num2 && num3 > num1 )
            {
                maiorN = num3;
            }
            else
            {
                medioN = num3;
            }
        }
        else
        {
            menorN = num3;
        }

        Console.WriteLine($"Os numeros digitados em ordem crescente sao: {menorN}, {medioN}, {maiorN}");
    }
}