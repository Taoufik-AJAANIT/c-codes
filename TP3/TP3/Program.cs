using System;
using System.CodeDom;

namespace TP3
{
    internal class Program
    {
        public static void Main(string[] args){
            
            Repertoir Repo = new Repertoir("progs");
            Fichier file1 = new Fichier("test","c",10);
            Fichier file2 = new Fichier("test", "py",9);
            
            Repo.inserer(file1);
            Repo.inserer(file2);
            
            Console.WriteLine(Repo.Rechercher("test.py"));
            Repo.Afficher();
            
            Repo.supprimer("test.c");
            
            Repo.Afficher();
            
            Console.WriteLine(Repo.Rechercher("test.py"));
            
            
        }
    }

    


    
        
        
    
}