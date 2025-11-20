Console.Write("Digite um número para ver a sua tabuada: ");
int numero = int.Parse(Console.ReadLine());


Console.WriteLine("\n--- Tabuada do " + numero + " ---");

for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;

   
    Console.WriteLine(numero + " x " + i + " = " + resultado);
}

Console.WriteLine("Pressione qualquer tecla para sair ");