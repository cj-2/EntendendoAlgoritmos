using AlgoritmosVariados;

Console.WriteLine(Algoritmos.Soma([]));
Console.WriteLine(Algoritmos.Soma([0]));
Console.WriteLine(Algoritmos.Soma([5, 10, 15, -2, 2]));
Console.WriteLine("---");
Console.WriteLine(Algoritmos.TamanhoLista([]));
Console.WriteLine(Algoritmos.TamanhoLista([5, 10, 15, -2, 2]));
Console.WriteLine("---");
Console.WriteLine(Algoritmos.BuscaMaior([]));
Console.WriteLine(Algoritmos.BuscaMaior([42]));
Console.WriteLine(Algoritmos.BuscaMaior([-2]));
Console.WriteLine(Algoritmos.BuscaMaior([5, 10, 15, -2, 2]));
Console.WriteLine("---");
Console.WriteLine(Algoritmos.BuscaMenor([]));
Console.WriteLine(Algoritmos.BuscaMenor([-42]));
Console.WriteLine(Algoritmos.BuscaMenor([42]));
Console.WriteLine(Algoritmos.BuscaMenor([5, 10, 15, -2, 2]));
