const int n = 18;
const int c = 0;

Console.WriteLine("escreva um numero para saber se impar ou par");


string resposta = Console.ReadLine();


bool ehValido = int.TryParse(resposta, out int numero);


   
    if (numero >= n)
    {
        Console.WriteLine("par.");
    }
    
    else  (numero < c)
    {
        Console.WriteLine("impar")
    }
 
