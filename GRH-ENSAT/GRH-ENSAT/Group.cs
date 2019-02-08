using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace GRH_ENSAT{
    
    public class Group : IComparable<Group>{
        private string label;
        private List<Etudiant> lesEtudiant;
        private int nbrEtudiant;

        public Group(string label){
            this.label = label;
            this.lesEtudiant = new List<Etudiant>();
            this.nbrEtudiant = 0;
        }


        public void ajouterEtudiant(Etudiant etd){
            lesEtudiant.Add(etd);
            nbrEtudiant++;
        }

        public int rechercher(int c){
            foreach (var etd in lesEtudiant) {
                if (etd.Code == c) {
                    return lesEtudiant.IndexOf(etd);
                }

                
            }
            return -1;
        }

        public void supprimer(int code){
            int indice = rechercher(code);
            
            if (indice != -1) {
                lesEtudiant.RemoveAt(indice);
            }
        }

        public string Label {
            get => label;
            set => label = value;
        }

        public List<Etudiant> LesEtudiant {
            get => lesEtudiant;
            set => lesEtudiant = value;
        }

        public int NbrEtudiant {
            get => nbrEtudiant;
            set => nbrEtudiant = value;
        }

        public void trier(){
            lesEtudiant.Sort();
                
        }


        public int CompareTo(Group other){
            if (nbrEtudiant < other.NbrEtudiant)
                return -1;
            return 1;

        }
    }
}