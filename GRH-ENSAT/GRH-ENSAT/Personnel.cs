namespace GRH_ENSAT{
    
    public abstract class Personnel : Personne{
        
        private int bureau;
        private float salaire;


        public int Bureau {
            get => bureau;
            set => bureau = value;
        }

        public float Saliare {
            get => salaire;
            set => salaire = value;
        }


        protected Personnel(int code, string prenom, string nom, int bureau, float salaire) : base(code, prenom, nom){
            this.bureau = bureau;
            this.salaire = salaire;
        }

        public abstract float calculer_Salaire();

        public override string ToString(){
            return base.ToString()+ " bureau : " + bureau + "salaire : " + salaire ;
        }
    }
}