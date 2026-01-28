namespace PesquisaEmLargura;

public static class Search
{
    public static string? Handle(Dictionary<string, string[]> grafo, string start, string search)
    {
        var myQueue = new Queue<string>();
        var alreadyVerified = new Dictionary<string, bool>();
        alreadyVerified[start] = true;

        foreach (var friend in grafo[start])
        {
            myQueue.Enqueue(friend);
        }

        while (true)
        {
            myQueue.TryDequeue(out var nextPerson);

            if (nextPerson != null)
            {
                if (alreadyVerified.ContainsKey(nextPerson)) continue;
                if (IsMangoSeller(nextPerson, search)) return nextPerson;

                alreadyVerified[nextPerson] = true;

                foreach (var nextFriends in grafo[nextPerson])
                {
                    myQueue.Enqueue(nextFriends);
                }
            }
            else
            {
                break;
            }
        }

        return "Not Found";
    }

    private static bool IsMangoSeller(string person, string search)
    {
        return person.StartsWith(search);
    }
}