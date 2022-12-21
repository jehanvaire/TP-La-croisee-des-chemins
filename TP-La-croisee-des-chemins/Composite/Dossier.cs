public class Dossier : INoeud
{
    private string nom = "";
    private List<INoeud> enfants = new List<INoeud>();
    private INoeud parent = null;
    private Printer printer;

    public string GetNom()
    {
        return this.nom;
    }

    public INoeud GetParent()
    {
        return this.parent;
    }

    public void SetNom(string nom)
    {
        this.nom = nom;
    }

    public int GetProfondeur()
    {
        int niveau = 0;

        var par = this.parent;

        while (par != null)
        {
            niveau++;
            par = par.GetParent();
        }

        return niveau;
    }

    public bool IsRoot()
    {
        return this.parent == null;
    }

    public void Print()
    {
        this.printer.Print(this);
    }

    public void AddEnfant(INoeud enfant)
    {
        this.enfants.Add(enfant);
    }
    public void RemoveEnfant(INoeud enfant)
    {
        this.enfants.Remove(enfant);
        
    }
}