// See https://aka.ms/new-console-template for more information
double x = 1;
int y = 1;
int z = 2;

double resutado = ((x + y) * z);


Console.WriteLine("Hello, World!");
Console.WriteLine(resutado);

Console.WriteLine("\n----\n");

string nome = "vitor";
string sobrenome = "lima";
Console.WriteLine(nome + sobrenome);

char lestraA = '0';
char letrasB = '1';
Console.WriteLine(lestraA +0);
Console.WriteLine(letrasB +0);

Console.WriteLine("\n----\n");

Console.WriteLine("EScreva seu nome");
string nomeUsuario = Console.ReadLine();
Console.WriteLine("O seu nome é:" +  nomeUsuario);

Console.WriteLine("Em qual ano vc nasceu?");
string anoNascimentoidadeUsuarioString= Console.ReadLine();
Console.WriteLine("A sua idade é: + anoNascimentoidadeUsuarioString");
int idadeUsuario = 2025 - int.Parse(anoNascimentoidadeUsuarioString);
Console.WriteLine("A sua iadae é:" + idadeUsuario);