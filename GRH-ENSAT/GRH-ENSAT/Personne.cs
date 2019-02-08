namespace GRH_ENSAT{
    
    public abstract  class Personne{
        private int code;
        private string prenom;
        private string nom;

        public Personne(int code, string prenom, string nom){
            this.code = code;
            this.prenom = prenom;
            this.nom = nom;
        }

        public int Code {
            get => code;
            set => code = value;
        }

        public string Prenom {
            get => prenom;
            set => prenom = value;
        }

        public string Nom {
            get => nom;
            set => nom = value;
        }

        public override string ToString(){
            return "code : "+code + " prenom :  " + prenom + " nom :  " + nom;
        }
    }
}