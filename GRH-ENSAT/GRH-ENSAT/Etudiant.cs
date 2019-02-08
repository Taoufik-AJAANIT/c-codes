namespace GRH_ENSAT{
    public class Etudiant : Personne{
        
        private string niveau ;
        private float moyenne_annuele;

        

        public string Niveau {
            get => niveau;
            set => niveau = value;
        }

        public float MoyenneAnnuele {
            get => moyenne_annuele;
            set => moyenne_annuele = value;
        }

        public Etudiant(int code, string prenom, string nom, string niveau, float moyenneAnnuele) : base(code, prenom, nom){
            this.niveau = niveau;
            moyenne_annuele = moyenneAnnuele;
        }

        public override string ToString(){
            return base.ToString() + "  niveau " + niveau + "moyenne annuele : " + moyenne_annuele;
        }
    }
}