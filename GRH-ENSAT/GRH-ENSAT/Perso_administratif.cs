using System.Collections.Generic;

namespace GRH_ENSAT{
    public class Perso_administratif : Personnel{
        public Perso_administratif(int code, string prenom, string nom, int bureau, float salaire) : base(code, prenom, nom, bureau, salaire){
        }


        public override float calculer_Salaire(){

            return base.Saliare;
        }
        
        
        
        
    }
}