//const int n1 = 1
//const int n2 = 0


Console.WriteLine("digite numero para saber se par ou impar");


string resposta = Console.ReadLine();


bool ehValido = int.TryParse(resposta, out int numero);



if (numero % 2 == 0)
{
    Console.WriteLine("par");
}
else
{ Console.WriteLine("impar"); }
