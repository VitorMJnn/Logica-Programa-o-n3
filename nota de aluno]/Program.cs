Double nota;
Console.WriteLine("\"Por favor, insira uma nota entre 0 e 10:\"");
nota = Convert.ToDouble(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota inválida. Por favor, insira uma nota entre 0 e 10:");
    nota = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Nota válida: {nota}");


