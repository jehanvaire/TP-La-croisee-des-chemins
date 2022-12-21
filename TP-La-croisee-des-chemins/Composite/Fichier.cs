public class Fichier : INoeud
{
    private INoeud parent;
    private string nom;
    private Printer printer;

    public string GetNom()
    {
        return this.nom;
    }

    public INoeud GetParent()
    {
        return this.parent;
    }

    public void Print()
    {
        this.printer.Print(this);
    }

    public int GetProfondeur()
    {
        int niveau = 0;

        var par = this.parent;

        while(par != null)
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
}