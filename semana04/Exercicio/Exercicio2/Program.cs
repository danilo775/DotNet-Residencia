using Namespace;

Veiculo Fusca = new Veiculo();

Fusca.Modelo = "gl";
Fusca.Cor = "vermelho";
Fusca.Ano = 2000;
Console.Clear();
Console.WriteLine(Fusca.Modelo, Fusca.Cor, Fusca.Ano);

Console.WriteLine(Fusca.geIdadeAtual());