using System;

namespace GRH_ENSAT{
    public class Directeur : Personnel{
        
        private float prim_diplacement;
        private static Boolean isInstancied = false;

        private Directeur(int code, string prenom, string nom, int bureau, int salaire, float primDiplacement) : base(code, prenom, nom, bureau, salaire){
            prim_diplacement = primDiplacement;
        }

        public static Directeur instatcie(int code, string prenom, string nom, int bureau, int salaire, float primDiplacement){
            if (!isInstancied) {
                return new Directeur(code, prenom, nom, bureau, salaire, primDiplacement);
            }
            throw new Exception("already exists");
        }

        public override float calculer_Salaire(){
            return base.Saliare + prim_diplacement;
        }

        public override string ToString(){
            return base.ToString()+"  prime de deplacement : " + prim_diplacement ;
        }
    }
}