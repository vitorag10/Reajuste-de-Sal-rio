double[] salarios = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o salário da {i + 1}° pessoa: ");
    salarios[i] = double.Parse(Console.ReadLine());

    if (salarios[i] < 1000)
    {
        salarios[i] *= 1.1;
    }
}

Console.WriteLine("\nSalários atualizados:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Pessoa {i + 1}: R${salarios[i]}");
}

Console.ReadKey();

