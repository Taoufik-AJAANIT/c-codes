namespace TP3{
    class Fichier{
        private string nom;
        private string extention;
        private float taille;

        public override string ToString(){
            return nom + "." + extention + "    " + taille + "KO";
        }

        public Fichier(string nom, string extention, float taille){
            this.nom = nom;
            this.extention = extention;
            this.taille = taille;
        }

        public string Nom => nom;

        public string Extention => extention;

        public void Renommer(string nom){
            this.nom = nom;
        }

        public void ModifTaille(int taille){
            this.taille = taille;
        }

        public float getTaille(){
            return taille/1000;
        }
    }
}