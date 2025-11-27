// See Exercício 1 – Validação de Senha
//Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas.
//A senha correta é "12345".
//Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado.
//Caso contrário, o programa informa que o acesso foi negado.

//Console.WriteLine("Exercício 1 – Validação de Senha");
//const int dezoto = 18;
//const int zero = 0;

//Console.WriteLine("Qual a sua idade?");


//string resposta = Console.ReadLine();


//bool ehValido = int.TryParse(resposta, out int idade);
//int tentativas = 3;
//while (tentativas > 0)
//{
//    Console.WriteLine("Digite a senha:");
//    string senha = Console.ReadLine();
//    if (senha == "12345")
//    {
//        Console.WriteLine("Senha correta.");
//        break;
//    }
//    else
//    {
//        tentativas--;
//        Console.WriteLine($"Senha incorreta. Você tem {tentativas} tentativas restantes.");
//    }
//}
//if (ehValido)
//{

//    if (idade >= 18)
//    {
//        Console.WriteLine("o acesso é liberado");
//    }
//    else  (idade < 0)
//    {
//        Console.WriteLine("Acesso negado. Você deve ter mais de 18 anos");

//    }













//Exercício 2 – Números Pares e Ímpares
//Peça ao usuário um número inteiro positivo. O programa deve imprimir todos os números de 1 até esse número.
//Para cada número, informe se ele é par ou ímpar.
//Se o número for par e múltiplo de 5 ao mesmo tempo, destaque com a mensagem "Par e múltiplo de 5".



//Console.WriteLine("escreva um numero para saber se impar ou par");


//string resposta = Console.ReadLine();


//bool ehValido = int.TryParse(resposta, out int numero);


//if (numero % 2 == 0 && numero % 5 == 0)
//{
//    Console.WriteLine("Par e múltiplo de 5");
//}
//else
//{
//    Console.WriteLine("O número não atende a ambas as condições.");
//}

//Exercício 3 – Caixa Registradora
//Simule uma caixa registradora simples.
//O programa deve pedir o valor de cada produto até que o usuário digite 0 para encerrar.
//Ao final, mostre o total da compra.
//Se o total for maior que R$ 100 OU o cliente tiver um cupom de desconto (informado como CUPOM10), aplique 10% de desconto.

//int valor = -1;
//int total = 0;

//while (valor != 0)
//{
//    Console.WriteLine("Digite o valor do produto (ou 0 para encerrar):");
//    string resposta = Console.ReadLine();
//    bool ehValido = int.TryParse(resposta, out valor);
//    if (ehValido && valor > 0)
//    {
//        total += valor;
//    }
//}

//Console.WriteLine($"Total da compra: R$ {total}");
//Console.WriteLine("Você possui um cupom de desconto? (Digite CUPOM10 para sim)");
//string cupom = Console.ReadLine();
//if (total > 100 || cupom == "CUPOM10")
//{
//    double desconto = total * 0.10;
//    total -= (int)desconto;
//    Console.WriteLine($"Desconto aplicado! Novo total: R$ {total}");
//}
//else
//{
//    Console.WriteLine("Nenhum desconto aplicado.");
//}