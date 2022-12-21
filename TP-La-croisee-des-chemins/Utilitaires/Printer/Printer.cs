public class Printer : IPrinter
{
    public void Print(INoeud noeud)
    {
        Console.WriteLine("noeud : ", noeud);
    }
}