// Um grafo de grafos.

using Dijkstra;

var grafo = new Dictionary<string, Dictionary<string, int>>
{
    ["inicio"] = new()
    {
        ["a"] = 6,
        ["b"] = 2
    },
    ["a"] = new()
    {
        ["fim"] = 1
    },
    ["b"] = new()
    {
        ["a"] = 3,
        ["fim"] = 5,
    },
    ["fim"] = new()
};

Algoritmo.Handle(grafo, "inicio", "fim");

var grafo2 = new Dictionary<string, Dictionary<string, int>>
{
    ["inicio"] = new()
    {
        ["a"] = 5,
        ["b"] = 2
    },
    ["a"] = new()
    {
        ["c"] = 4,
        ["d"] = 2
    },
    ["b"] = new()
    {
        ["a"] = 8,
        ["d"] = 7,
    },
    ["c"] = new()
    {
        ["fim"] = 3,
        ["d"] = 6,
    },
    ["d"] = new()
    {
        ["fim"] = 1,
    },
    ["fim"] = new()
};

Algoritmo.Handle(grafo2, "inicio", "fim");
