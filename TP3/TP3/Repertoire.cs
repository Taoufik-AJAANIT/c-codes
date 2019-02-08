using System;

namespace TP3{
    class Repertoir{

        private string nom;
        private int Nbr_fichiers;
        private Fichier[] fichiers = new Fichier[30];

        public void Afficher(){
            Console.WriteLine("######### " + nom + " ##########");
            for (int i = 0; i < Nbr_fichiers; i++) {
                Console.WriteLine(fichiers[i]);
            }

            Console.WriteLine("######################");
        }

        public Repertoir(string nom){
            this.nom = nom;
            Nbr_fichiers = 0;
        }

        public void inserer(Fichier file){
            if (Nbr_fichiers <30)
            fichiers[Nbr_fichiers++] = file;
        }

        public int Rechercher(string nom){
            string file;
            for (int i = 0; i < Nbr_fichiers ;i++) {
                file = fichiers[i].Nom + "." + fichiers[i].Extention;
                if (Equals(file,nom))
                    return i; 
            }
            return -1;
        }

        public void supprimer(string nom){
            int pos = Rechercher(nom);
            if (pos == 29)
                fichiers[pos] = null;
            else {
                for (int i = pos, j = pos + 1; i < Nbr_fichiers; i++, j++) {
                    fichiers[i] = fichiers[j];
                }

                fichiers[Nbr_fichiers] = null;
            }

            Nbr_fichiers--;
        }
        
        

    }
}