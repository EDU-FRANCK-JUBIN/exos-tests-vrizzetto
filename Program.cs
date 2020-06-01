using System;

namespace ExoTest
{
    class Program
    {
        private String m_nom;
        private String m_prenom;

        public Program(string Nom, string Prenom)
        {
            this.m_nom = Nom;
            this.m_prenom = Prenom;
            
        }
        public string nom
        {
            get { return m_nom; }
        }
        public string prenom
        {
            get { return m_prenom; }
        }

        public void AffichInit()
        {
            string chaine = this.nom.Substring(0, 1);
            string chaine2 = this.prenom.Substring(0, 1);
            Console.WriteLine("la première lettre de:" + this.m_nom + " est : " + chaine + " la première lettre du prenom :" + this.m_prenom + " est : " + chaine2);
        } 
        static void Main(string[] args)
        {
            Program test1 = new Program("rizzetto", "vincent");
            Console.WriteLine("Debut du test pour le nom rizzetto et le prenom vincent");
            test1.AffichInit();
        }
    }
}
