/*Ref. (15 pontos)7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg. 
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode doar sangue ou não; caso não possa, diga o(s) motivo(s).
Nome: Emilly Dias
*/
public static class Atividade7
{
    public static void Executar()
    {
        int idade;
        double peso;

        Console.WriteLine ("digite a sua idade");
        idade = int.Parse(Console.ReadLine()!);

        Console.WriteLine ("digite o seu peso");
        peso = double.Parse(Console.ReadLine()!);

        if (idade >= 18 && idade <= 67 && peso > 60)
        {
            Console.WriteLine ("você pode doar sangue");
        }
        else
        {
            Console.WriteLine ("você não pode doar sangue");
            if (idade < 18)
            {
                Console.WriteLine ("tem menos de 18 anos");
            }
            if (idade > 67)
            {
                Console.WriteLine ("tem mais de 67 anos");
            }
            if (peso <= 60)
            {
                Console.WriteLine ("tem 60 kg ou menos");
            }
        }
    }
}