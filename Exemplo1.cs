public static class Exemplo1
{
    public static void Executar()
    {
        double nota;
        double frequencia;

        Console.WriteLine("Digite a nota do aluno:");
        nota = double.Parse(Console.ReadLine()!);
        
       Console.WriteLine("Digite a frequência do aluno:");
        frequencia = double.Parse(Console.ReadLine()!);

        if (nota>= 7)
        {
            if (frequencia>= 75)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado por frequência!");
            }
        }
        else
        {
            Console.WriteLine("Aluno Reprovado!");
        }
    }
}
