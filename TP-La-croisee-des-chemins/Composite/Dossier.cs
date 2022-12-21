public class Dossier implements INoeud
{
    private sousDossiers: List<INoeud>;
    private Printer printer = new Printer();

    public void Print()
    {
        printer.Print(this);
    }

    public void Add(INoeud noeud)
    {
        sousDossiers.Add(noeud);
    }

    public void Remove(INoeud noeud)
    {
        sousDossiers.Remove(noeud);
    }

    public List<INoeud> GetSousDossiers()
    {
        return sousDossiers;
    }

}