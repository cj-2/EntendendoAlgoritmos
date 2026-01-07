namespace QuickSort;

public static class QuickSortInt
{
    public static List<int> Run(List<int> list)
    {
        // Casos de base, onde temos um item na lista ou dois.
        if (list.Count <= 1) return list;
        if (list.Count == 2)
        {
            var (a, b) = (list[0], list[1]);
            return a > b ? [b, a] : [a, b];
        }

        var maiorQue = new List<int>();
        var menorQue = new List<int>();

        var pivoIdx = (list.Count - 1) / 2;
        var pivo = list[pivoIdx];
        list.RemoveAt(pivoIdx);

        foreach (var i in list)
        {
            if (i > pivo)
                maiorQue.Add(i);
            else
                menorQue.Add(i);
        }

        // Dividir para conquistar!
        var result = new List<int>();
        result.AddRange(Run(menorQue)); // Passamos "metade" para cá.
        result.Add(pivo);
        result.AddRange(Run(maiorQue)); // E "metate" pra cá.

        return result;
    }

    public static void Print(List<int> list)
    {
        foreach (var i in list)
            Console.Write(i + " ");

        Console.WriteLine();
    }
}