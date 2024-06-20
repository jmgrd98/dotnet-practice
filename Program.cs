Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Digite o ano do seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = DateTime.Now.Year - year;

Console.WriteLine($"Olá {name}, você possui {age} anos!");