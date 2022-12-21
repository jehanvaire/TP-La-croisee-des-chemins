
public class Parser : IParser
{
    private readonly IPrinter _printer;
    private string separateur = "";

    public Parser(string separateur)
    {
        this.separateur = separateur;
    }


    public INoeud Parse(string[] input)
    {
        INoeud noeud = new Dossier();
        for(int i = 0; i < input.Length; i++)
        {
            var dossiers = input[i].Split(separateur);
            
        }



        return noeud;
    }
}
