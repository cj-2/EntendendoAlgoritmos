namespace AlgoritmosVariados;

public static class Algoritmos
{
    private static int[] RemoverPrimeiroItem(int[] lista)
    {
        var novaLista = new int[lista.Length - 1];
        Array.Copy(lista, 1, novaLista, 0, lista.Length - 1);
        return novaLista;
    }

    public static int? BuscaMaior(int[] lista, int? maior = null)
    {
        if (lista.Length == 0) return maior;

        var primeiro = lista[0];
        var novaLista = RemoverPrimeiroItem(lista);

        if (maior == null)
            return BuscaMaior(novaLista, primeiro);

        if (primeiro > maior)
            return BuscaMaior(novaLista, primeiro);

        return BuscaMaior(novaLista, maior);
    }

    public static int? BuscaMenor(int[] lista)
    {
        if (lista.Length == 0)
            return null;

        var idx = 1;
        var menor = lista[0];

        while (idx < lista.Length)
        {
            if (lista[idx] < menor)
                menor = lista[idx];

            idx++;
        }

        return menor;
    }

    public static int? BuscaIdxMenor(int[] lista)
    {
        if (lista.Length == 0)
            return null;

        var idxAtual = 1;
        var idxMenor = 0;

        while (idxAtual < lista.Length)
        {
            if (lista[idxAtual] < lista[idxMenor])
                idxMenor = idxAtual;

            idxAtual++;
        }

        return idxMenor;
    }
    
    public static int Soma(int[] lista)
    {
        if (lista.Length == 0) return 0;

        var primeiro = lista[0];
        var novaLista = RemoverPrimeiroItem(lista);
        return primeiro + Soma(novaLista);
    }

    public static int TamanhoLista(int[] lista)
    {
        if (lista.Length == 0) return 0;

        var novaLista = RemoverPrimeiroItem(lista);
        return 1 + TamanhoLista(novaLista);
    }
}