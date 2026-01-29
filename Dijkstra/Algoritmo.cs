namespace Dijkstra;

public static class Algoritmo
{
    public static void Handle(Dictionary<string, Dictionary<string, int>> grafo, string partida, string chegada)
    {
        var processados = new List<string>();
        var custos = new Dictionary<string, int?>();
        var pais = new Dictionary<string, string>();

        foreach (var v in grafo.Keys)
            custos[v] = null;

        custos[partida] = 0;

        var vertice = AcharVerticeComMenorCustoNaoProcessado(custos, processados);
        while (vertice != null)
        {
            if (vertice == chegada) break;

            var custo = custos[vertice]; // Custo atual para chegar onde estamos.
            var vizinhos = grafo[vertice];

            foreach (var key in vizinhos.Keys)
            {
                // O novo custo dos vizinhos pode ser o custo de chegar onde estamos mais o custo para chegar nos vizinhos.
                var novoCusto = custo + vizinhos[key];

                // Se ficou mais "barato" chegar no vizinho, comparado com a tabela de custos, atualiza:
                if (custos[key] > novoCusto || !custos[key].HasValue)
                {
                    custos[key] = novoCusto;
                    pais[key] = vertice;
                }
            }

            processados.Add(vertice);
            vertice = AcharVerticeComMenorCustoNaoProcessado(custos, processados);
        }

        ImprimirResultado(custos, pais, chegada);
    }

    private static string? AcharVerticeComMenorCustoNaoProcessado(Dictionary<string, int?> custos,
        List<string> processados)
    {
        string? veritce = null;
        int? custoVertice = null;

        foreach (var key in custos.Keys)
        {
            if (processados.Contains(key) || custos[key] == null)
                continue;

            if (custoVertice < custos[key])
                continue;

            veritce = key;
            custoVertice = custos[key];
        }

        return veritce;
    }

    private static void ImprimirResultado(Dictionary<string, int?> custos, Dictionary<string, string> pais,
        string chegada)
    {
        Console.WriteLine("Custos:");
        foreach (var keyValue in custos)
            Console.WriteLine(keyValue.Key + ": " + keyValue.Value);

        Console.WriteLine();
        Console.WriteLine("Pais:");
        foreach (var keyValue in pais)
            Console.WriteLine(keyValue.Key + ": " + keyValue.Value);

        Console.WriteLine();
        var melhorCaminho = "";
        var proximo = chegada;

        while (true)
        {
            melhorCaminho = proximo + melhorCaminho;
            if (pais.TryGetValue(proximo, out var v))
            {
                proximo = v;
                melhorCaminho = " => " + melhorCaminho;
            }
            else break;
        }

        Console.WriteLine("Melhor caminho até a chegada:");
        Console.WriteLine(melhorCaminho);
        Console.WriteLine();
    }
}