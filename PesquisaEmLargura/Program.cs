using PesquisaEmLargura;

var friends = new Dictionary<string, string[]>();
// ponto de partida, que no caso sou eu.
friends["eu"] = ["jose", "vitor", "rodrigo"]; // meus vizinhos
// primeiro grau
friends["jose"] = ["germania"]; // vizinhos de jose
friends["vitor"] = ["alice", "germania"];
friends["rodrigo"] = ["eu"];
// segundo grau
friends["germania"] = [];
friends["alice"] = ["tom"];
// terceiro grau
friends["tom"] = ["eu"];

Console.WriteLine(Search.Handle(friends, "eu", "t")); // tom
Console.WriteLine(Search.Handle(friends, "eu", "t")); // germania