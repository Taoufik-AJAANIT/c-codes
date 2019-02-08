using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace GRH_ENSAT.Properties{
    public class RessourceHumains{
        
        private List<Personne> GRH;

        public RessourceHumains(){
            
            GRH = new List<Personne>();
            
        }

//        public void afficher_Enseignants();

        public void ajouterPersonne(Personne p){
            GRH.Add(p);
        }

        public void afficherEnseignants(){

            foreach (var p in GRH) {
                if(p is Perso_enseignant)
                    Console.WriteLine(p);
            }
        }

        public int rechercher(int code){

            for (int i = 0; i < GRH.Count; i++) {
                if (GRH[i].Code == code)
                    return i;
            }

            return -1;
        }

        public void Trier_Etudiants_groups(Group g){
            g.trier();
        }
        
        public void 
        
        
        
    }
}