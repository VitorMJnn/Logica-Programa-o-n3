//01.Conversão de Temperatura -> Difícil

//    Crie um programa que peça ao usuário uma temperatura em graus Celsius.
//    Converta para Fahrenheit usando a fórmula: F = (Cx9 / 5) + 32
//    Exiba o resultado.
//Console.WriteLine("Digite a temperatura em graus Celsius:");
//float celsius = Convert.ToSingle(Console.ReadLine());
//float fahrenheit = (celsius * 9 / 5) + 32;
//Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");



//02. Operações Matemáticas -> Fácil

//    Solicite dois números inteiros ao usuário.
//    Armazene-os em variáveis.
//    Calcule e exiba a soma, subtração, multiplicação e divisão.

//int soma, subtracao, multiplicacao;
//float divisao;
//Console.WriteLine("Digite o primeiro número inteiro:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite o segundo número inteiro:");
//int num2 = Convert.ToInt32(Console.ReadLine());
//soma = num1 + num2;
//subtracao = num1 - num2;
//multiplicacao = num1 * num2;
//divisao = (float)num1 / num2;
//Console.WriteLine($"Soma: {soma}");
//Console.WriteLine($"Subtração: {subtracao}");
//Console.WriteLine($"Multiplicação: {multiplicacao}");
//Console.WriteLine($"Divisão: {divisao}");

//03. Estrutura de Decisão (if/else) -> Fácil

//    Peça ao usuário um número inteiro.
//    Informe se ele é múltiplo de 3, de 5 ou de ambos.
//
//Console.WriteLine("Digite um número inteiro:");
//int numero = Convert.ToInt32(Console.ReadLine());
//if (numero % 3 == 0 && numero % 5 == 0)
//{
//    Console.WriteLine("O número é múltiplo de 3 e de 5.");
//}
//else if (numero % 3 == 0)
//{
//    Console.WriteLine("O número é múltiplo de 3.");
//}
//else if (numero % 5 == 0)
//{
//    Console.WriteLine("O número é múltiplo de 5.");
//}
//else
//{
//    Console.WriteLine("O número não é múltiplo de 3 nem de 5.");
//}



//04. Estrutura de Decisão (switch) -> Fácil

//    Solicite ao usuário um número de 1 a 7.
//    Exiba o dia da semana correspondente (1 = Domingo, 2 = Segunda, etc.)

//int domingo = 1;
//int segunda = 2;
//int terca = 3;
//int quarta = 4;
//int quinta = 5;
//int sexta = 6;
//int sabado = 7;
//string dia;
//Console.WriteLine("Digite um número de 1 a 7:");
//dia = Console.ReadLine();
//switch (dia)
//{
//    case "1":
//        Console.WriteLine("Domingo");
//        break;
//    case "2":
//        Console.WriteLine("Segunda");
//        break;
//    case "3":
//        Console.WriteLine("Terça");
//        break;
//    case "4":
//        Console.WriteLine("Quarta");
//        break;
//    case "5":
//        Console.WriteLine("Quinta");
//        break;
//    case "6":
//        Console.WriteLine("Sexta");
//        break;
//    case "7":
//        Console.WriteLine("Sábado");
//        break;
//    default:
//        Console.WriteLine("Número inválido. Por favor, digite um número de 1 a 7.");
//        break;
//}

//05. Laço de Repetição (for) -> Fácil

//    Crie um programa que exiba todos os números de 1 a 20 usando for.


//for (int i = 1; i <= 20; i++)
//{
//    Console.WriteLine(i);
//}

//06. Laço de Repetição (while) -> Fácil

//    Solicite ao usuário um número.
//    Continue pedindo novos números até que ele digite 0.
//    Ao final, mostre quantos números foram digitados.

//int contador = 0;
//int numero;
//while (true)
//{
//    Console.WriteLine("Digite um número (0 para sair):");
//    numero = Convert.ToInt32(Console.ReadLine());
//    if (numero == 0)
//    {
//        break;
//    }
//    contador++;
//}
//Console.WriteLine($"Total de números digitados: {contador}");



//07. Contagem de Vogais -> Difícil

//    Peça ao usuário para digitar uma palavra.
//    Use um laço de repetição para percorrer cada letra.
//    Conte quantas vogais (a, e, i, o, u) existem na palavra.
//    Exiba o total de vogais encontradas.

//Console.WriteLine("Digite uma palavra:");
//string palavra = Console.ReadLine();
//int contadorVogais = 0;
//for (int i = 0; i < palavra.Length; i++)
//{
//    char letra = char.ToLower(palavra[i]);
//    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
//    {
//        contadorVogais++;
//    }
//}
//Console.WriteLine($"Total de vogais na palavra '{palavra}': {contadorVogais}");



//08. Lista Simples (Array) -> Médio

//    Crie um programa que armazene 5 nomes em um array.
//    Depois, exiba todos os nomes na tela.[

//string[] nomes = new string[5];
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Digite um nome:");
//    nomes[i] = Console.ReadLine();
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Nome {nomes[i]}");
//}


//09. Lista com Inteiros -> Médio

//    Crie uma lista de números inteiros.
//    Peça ao usuário para digitar 5 números e armazene-os na lista.
//    Exiba o maior e o menor número digitado.

//List<int> numeros = new List<int>();
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Digite um número inteiro:");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    numeros.Add(numero);
//}
//int maior = numeros[0];
//int menor = numeros[0];
//for (int i = 1; i < numeros.Count; i++)
//{
//    if (numeros[i] > maior)
//    {
//        maior = numeros[i];
//    }
//    if (numeros[i] < menor)
//    {
//        menor = numeros[i];
//    }
//}



//10. Média de Notas -> Médio

//    Solicite ao usuário 4 notas (armazenadas em uma lista).
//    Calcule a média.
//    Use if/else para informar se o aluno está aprovado (média ≥ 7) ou reprovado.

List<double> notas = new List<double>();
int totalDeNotas = 4;
for (int i = 0; i < totalDeNotas; i++)
{
    Console.WriteLine($"Digite a nota {i + 1}:");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas.Add(nota);
}
double soma = 0;
for (int i = 0; i < totalDeNotas; i++)
{
    soma += notas[i];
}
double media = soma / totalDeNotas;
Console.WriteLine($"A média das notas é: {media}");
if (media >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}
