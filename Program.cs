string Espécie;
Console.WriteLine("Digite a Espécie do seu animal:");
Espécie=Console.ReadLine()!;

string  Raça;
Console.WriteLine("Digite a Raça do seu animal:");
Raça=Console.ReadLine()!;

string Nome;
Console.WriteLine("Digite o nome do seu animal:");
Nome=Console.ReadLine()!;

string Idade;
Console.WriteLine("Digite a idade do seu animal:");
Idade=Console.ReadLine()!;

string Cor;
Console.WriteLine("Digite a Cor do pelo do seu animal:");
Cor=Console.ReadLine()!;

Console.WriteLine(" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
Console.WriteLine("|                    Pet Hotel Bom pra cachorro                 |");
Console.WriteLine("|///////////////////////////////////////////////////////////////|");
Console.WriteLine($"|Espécie:{Espécie.PadLeft(24, '.')}|Raça:{Raça.PadLeft(25, '.')}|");
Console.WriteLine("|///////////////////////////////////////////////////////////////|");
Console.WriteLine($"|Atende pela alcunha de:{Nome.PadLeft(40, '.')}|");            
Console.WriteLine($"|Idade: {Idade} ano(s)|Pelagem/cor:{Cor.PadLeft(34,'.')}|");
Console.WriteLine("|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|");