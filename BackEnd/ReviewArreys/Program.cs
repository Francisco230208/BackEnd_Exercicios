//Arrays
string nome = "Hugo";
Console.WriteLine($"Nome: {nome}");


string[] nomes = new string[4];

nomes[0] = "Marcos";
nomes[1] = "Matheus";
nomes[2] = "Elden";
nomes[3] = "Ringue";

Console.WriteLine();
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
