var listaOrdenada = new[]
{
    2, 5, 8, 12, 16, 23, 38, 45, 56, 67, 78, 89, 91, 95, 102, 115, 128, 134, 147, 156,
    167, 178, 189, 192, 201, 215, 223, 234, 245, 256, 267, 278, 289, 291, 305, 312, 323,
    334, 345, 356, 367, 378, 389, 392, 401, 415, 423, 434, 445, 456, 467, 478, 489, 491,
    502, 515, 523, 534, 545, 556, 567, 578, 589, 592, 601, 615, 623, 634, 645, 656, 667,
    678, 689, 692, 701, 715, 723, 734, 745, 756, 767, 778, 789, 792, 801, 815, 823, 834,
    845, 856, 867, 878, 889, 892, 901, 915, 923, 934, 945, 956, 967, 978, 989, 992, 1001,
    1015, 1023, 1034, 1045, 1056, 1067, 1078, 1089, 1092, 1101, 1115, 1123, 1134, 1145,
    1156, 1167, 1178, 1189, 1192, 1201, 1215, 1223, 1234, 1245, 1256, 1267, 1278, 1289,
    1292, 1301, 1315, 1323, 1334, 1345, 1356, 1367, 1378, 1389, 1392, 1401, 1415, 1423,
    1434, 1445, 1456, 1467, 1478, 1489, 1492, 1501, 1515, 1523, 1534, 1545, 1556, 1567,
    1578, 1589, 1592, 1601, 1615, 1623, 1634, 1645, 1656, 1667, 1678, 1689, 1692, 1701,
    1715, 1723, 1734, 1745, 1756, 1767, 1778, 1789, 1792, 1801, 1815, 1823, 1834, 1845,
    1856, 1867, 1878, 1889, 1892, 1901, 1915, 1923, 1934, 1945, 1956, 1967, 1978, 1989,
    1992, 2000
};

var pesquisaBinaria = (int[] lista, int item) =>
{
    var indice = -1;
    var contador = 0;

    var inicio = 0;
    var fim = lista.Length - 1; // maior índice

    if (lista[inicio] == item) indice = inicio;
    if (lista[fim] == item) indice = fim;

    if (indice == -1)
    {
        inicio++;
        fim--;

        while (inicio <= fim)
        {
            var meio = (inicio + fim) / 2;
            var chute = lista[meio];
            contador++;

            if (chute == item)
            {
                indice = meio;
                break;
            }

            if (chute > item) fim = meio - 1;
            if (chute < item) inicio = meio + 1;
        }
    }

    int? itemArray = indice != -1 ? lista[indice] : null;
    return new
    {
        ItemBuscado = item,
        Indice = indice,
        LoopsFeitos = contador,
        ItemDoArray = itemArray?.ToString() ?? "Não existe",
        BateComArray = itemArray == item
    };
};

Console.WriteLine($"Tamanho: {listaOrdenada.Length}");
Console.WriteLine("---");
Console.WriteLine(pesquisaBinaria(listaOrdenada, 2));
Console.WriteLine(pesquisaBinaria(listaOrdenada, 2000));
Console.WriteLine("---");
Console.WriteLine(pesquisaBinaria(listaOrdenada, 5));
Console.WriteLine(pesquisaBinaria(listaOrdenada, 1992));
Console.WriteLine("---");
Console.WriteLine(pesquisaBinaria(listaOrdenada, 701));
Console.WriteLine(pesquisaBinaria(listaOrdenada, 1223));
Console.WriteLine(pesquisaBinaria(listaOrdenada, 1234));
Console.WriteLine("---");
Console.WriteLine(pesquisaBinaria(listaOrdenada, 702));
Console.WriteLine(pesquisaBinaria(listaOrdenada, 1144));