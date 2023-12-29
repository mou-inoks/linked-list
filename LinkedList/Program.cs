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
        Noeud fin = new Noeud(data);

        Noeud noeud = this;

        while(noeud.suivant != null)
        {
            noeud = noeud.suivant;
        }
        noeud.suivant = fin;
    }
}

//1 Remove Dups
//Write code to remove duplicates from an unsorted linked list, FOLLOW UP.
//How would you solve this problem if a temporary buffer is not allowed ?  