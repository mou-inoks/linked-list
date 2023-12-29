//Exercice Linekd List page 92 Cracking the coding game 
//Créer un noeud basique 
class Noeud
{
    Noeud suivant = null;
    int value; 

    public Noeud(int data)
    {
        this.value = data;
    }

    void AjouterALaQueue(int data)
    {
        Noeud end = new Noeud(data);

        Noeud node = this;

        while(node.suivant != null)
        {
            node = node.suivant;
        }
        node.suivant = end;
    }
}