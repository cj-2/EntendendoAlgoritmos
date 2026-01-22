namespace AlgoritmosVariados;

public static class Algoritmos
{
    private static int[] RemoverPrimeiroItem(int[] array)
    {
        var novaLista = new int[array.Length - 1];
        Array.Copy(array, 1, novaLista, 0, array.Length - 1);
        return novaLista;
    }

    public static int? BuscaMaior(int[] array, int? maior = null)
    {
        if (array.Length == 0) return maior;

        var primeiro = array[0];
        var novaLista = RemoverPrimeiroItem(array);

        if (maior == null)
            return BuscaMaior(novaLista, primeiro);

        if (primeiro > maior)
            return BuscaMaior(novaLista, primeiro);

        return BuscaMaior(novaLista, maior);
    }

    public static int? BuscaMenor(int[] array)
    {
        if (array.Length == 0)
            return null;

        var idx = 1;
        var menor = array[0];

        while (idx < array.Length)
        {
            if (array[idx] < menor)
                menor = array[idx];

            idx++;
        }

        return menor;
    }

    public static int? BuscaIdxMenor(int[] array)
    {
        if (array.Length == 0)
            return null;

        var idxAtual = 1;
        var idxMenor = 0;

        while (idxAtual < array.Length)
        {
            if (array[idxAtual] < array[idxMenor])
                idxMenor = idxAtual;

            idxAtual++;
        }

        return idxMenor;
    }

    public static int Soma(int[] array)
    {
        if (array.Length == 0) return 0;

        var primeiro = array[0];
        var novaLista = RemoverPrimeiroItem(array);
        return primeiro + Soma(novaLista);
    }

    public static int TamanhoArray(int[] array)
    {
        if (array.Length == 0) return 0;

        var novaLista = RemoverPrimeiroItem(array);
        return 1 + TamanhoArray(novaLista);
    }

    public static List<int> OrdenacaoPorSelecao(List<int> list)
    {
        var ordenada = new List<int>();

        while (list.Count > 0)
        {
            var indexMenor = BuscaIdxMenor(list.ToArray());
            if (indexMenor == null) break;
            ordenada.Add(list[(int)indexMenor]);
            list.RemoveAt((int)indexMenor);
        }

        return ordenada;
    }
}