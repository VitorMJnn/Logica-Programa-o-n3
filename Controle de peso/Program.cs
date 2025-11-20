int pessoasMaisDe90Kg = 0;
int somaIdades = 0;
const int numeroDePessoas = 7;

for (int i = 1; i <= numeroDePessoas; i++)
{
    Console.WriteLine($"\nDados da pessoa {i}:");

    Console.Write("Digite a idade: ");
    int idade = int.Parse(Console.ReadLine());
    somaIdades += idade;

    Console.Write("Digite o peso (em kg): ");
    double peso = double.Parse(Console.ReadLine());

    if (peso > 90)
    {
        pessoasMaisDe90Kg++;
    }
}

double mediaIdades = (double)somaIdades / numeroDePessoas;

Console.WriteLine($"\nQuantidade de pessoas com mais de 90 kg: {pessoasMaisDe90Kg}");
Console.WriteLine($"Média das idades: {mediaIdades:F2}");

