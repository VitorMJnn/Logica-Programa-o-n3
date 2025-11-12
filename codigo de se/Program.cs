const int DEZOITO = 18;
const int ZERO = 0;

// 

Console.WriteLine("Qual e seua idade");

string resposta = Console.ReadLine();

bool enValido = int.TryParse(resposta, out int idade );

if ( enValido )


if (idade == DEZOITO)
{
    Console.WriteLine("usuario e maior de idade");

}
else if(idade  <ZERO)
{
    Console.WriteLine("idade invalida");
}
else
{
    Console.WriteLine("USUARIO MENOR DE IDADE");
}
else
{
    Console.WriteLine("Valor informado nao correponde a numero intero");
}    