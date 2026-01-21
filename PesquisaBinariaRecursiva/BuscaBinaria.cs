namespace PesquisaBinariaRecursiva;

public static class BuscaBinaria
{
    public static int? Handle(int[] lista, int item, int? inicio = null, int? fim = null)
    {
        inicio ??= 0;
        fim ??= lista.Length - 1;

        if (inicio > fim) return null;

        var meio = (inicio + fim) / 2 ?? 0;

        if (lista[meio] > item)
            return Handle(lista, item, inicio, meio - 1);

        if (lista[meio] < item)
            return Handle(lista, item, meio + 1, fim);

        return meio;
    }
}