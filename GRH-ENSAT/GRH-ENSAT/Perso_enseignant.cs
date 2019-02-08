using System.Collections.Generic;

namespace GRH_ENSAT{
    public class Perso_enseignant : Personnel{
        
        private float prim_diplacement;
        private string grade;
        private int heures_sup;
        private Dictionary<string, List<Etudiant>> groups;

        public float PrimDiplacement {
            get => prim_diplacement;
            set => prim_diplacement = value;
        }

        public string Grade {
            get => grade;
            set => grade = value;
        }

        public int HeuresSup {
            get => heures_sup;
            set => heures_sup = value;
        }

        public Dictionary<string, List<Etudiant>> Groups {
            get => groups;
            set => groups = value;
        }

        public Perso_enseignant(int code, string prenom, string nom, int bureau, float salaire, float primDiplacement, string grade, int heuresSup) : base(code, prenom, nom, bureau, salaire){
            prim_diplacement = primDiplacement;
            this.grade = grade;
            heures_sup = heuresSup;
            groups = new Dictionary<string, List<Etudiant>>();
        }

        public void ajouterGroup(Group g){
            groups.Add(g.Label ,g.LesEtudiant);
        }

        public override float calculer_Salaire(){

            return base.Saliare + prim_diplacement + heures_sup;
        }
        
        
    }
}