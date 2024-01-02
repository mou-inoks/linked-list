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
        Noeud ptr1 = null,
             ptr2 = null, dup = null;
        ptr1 = suivant;

        // Prendre chque éléments 1 par 1 
        while (ptr1 != null &&
               ptr1.suivant != null)
        {
            ptr2 = ptr1;

            /* Comparer l'élément avec le reste */
            while (ptr2.suivant != null)
            {
                // Si pareil enlever 
                if (ptr1.value == ptr2.suivant.value)
                {
                    dup = ptr2.suivant;
                    ptr2.suivant = ptr2.suivant.suivant;
                }
                else
                {
                    ptr2 = ptr2.suivant;
                }
            }
            ptr1 = ptr1.suivant;
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

//1 Remove Dups
//Write code to remove duplicates from an unsorted linked list, FOLLOW UP.
//How would you solve this problem if a temporary buffer is not allowed ?  

