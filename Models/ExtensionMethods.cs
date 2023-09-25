namespace DebtorsHW.Models;

static class ExtensionMethods 
{
    static public void Print<T>(this IEnumerable<T> debts)
    {
        foreach (var debtor in debts)
            Console.WriteLine(debtor);
    }
}