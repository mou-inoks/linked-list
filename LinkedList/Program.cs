//Exercice Linekd List page 92 Cracking the coding game 
//1 Remove Dups
//Write code to remove duplicates from an unsorted linked list, FOLLOW UP.
//How would you solve this problem if a temporary buffer is not allowed ?  

var noeud = new Noeud(1);




//Créer un noeud basique 

class Noeud
{
    Noeud suivant = null;
    int value; 

    public Noeud(int data)
    {
        this.value = data;
    }
    //AJouter noeud à un autre noeud 
    void AddToQueue(int data)
    {
        Noeud fin = new Noeud(data);

        Noeud noeud = this;

        while(noeud.suivant != null)
        {
            noeud = noeud.suivant;
        }
        noeud.suivant = fin;
    }

    void RemoveDuplicate()
    {
        Noeud noeud1 = null;

        Noeud noeud2 = null;

        Noeud duplicate = null;

        noeud1 = suivant;

        // Prendre chque éléments 1 par 1 
        while (noeud1 != null &&
               noeud1.suivant != null)
        {
            noeud2 = noeud1;

            /* Comparer l'élément avec le reste */
            while (noeud2.suivant != null)
            {
                // Si pareil enlever 
                if (noeud1.value == noeud2.suivant.value)
                {
                    duplicate = noeud2.suivant;
                    noeud2.suivant = noeud2.suivant.suivant;
                }
                //Sinon passer au suivant
                else
                {
                    noeud2 = noeud2.suivant;
                }
            }
            noeud1 = noeud1.suivant;
        }
    }

    void PrintList(Noeud noeud)
    {
        while (noeud != null)
        {
            Console.Write(noeud.value + " ");
            noeud = noeud.suivant;
        }
    }
}

