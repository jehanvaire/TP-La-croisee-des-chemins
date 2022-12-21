public interface INoeud
{
    void Print();
    int GetProfondeur();
    string GetNom();
    INoeud GetParent();
    bool IsRoot();
}