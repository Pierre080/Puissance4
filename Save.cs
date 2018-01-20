using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Puissance4Version2
{
   public class Saveload
    {
        #region données membres
        public int[,] Tableau { get; set;}
        public int Tour { get; set;}
        public string JoueurRouge { get; set;}
        public string JoueurJaune { get; set;}
        #endregion

        #region constructeur
        public Saveload() { }
        #endregion

        #region Methode

        public void Save()//Constructeur vide permet de créer une classe abstraite
        { }
        public void Save(int[,] tableau, int tour, string joueurrouge, string joueurjaune, string path)//Majuscule données de la classe et minuscules données que je reçois
        {
            for (int i = 0; i < tableau.GetLength(0); i++)
            {
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    Console.WriteLine(tableau[i, j]);
                }
            }
            this.Tableau = tableau;
            this.Tour = tour;
            this.JoueurRouge = joueurrouge;
            this.JoueurJaune = joueurjaune;

            XmlSerializer xml = new XmlSerializer(typeof(Saveload));
            using (TextWriter writer = new StreamWriter(path))
            {
                xml.Serialize(writer, this);
            }
        }

        public void Load(int[,] tableau, int tour, string joueurrouge, string joueurjaune, string path)//Majuscule données de la classe et minuscules données que je reçois
        {
            Saveload tmp;

            using (TextReader reader = new StreamReader(path))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Saveload));
                tmp = (Saveload)xml.Deserialize(reader);
            }
            for (int i = 0; i < tableau.GetLength(0); i++)
            {
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    Console.WriteLine(tableau[i, j]);
                }
            }
            tableau = tmp.Tableau;
            tour = tmp.Tour;
            joueurrouge = tmp.JoueurRouge;
            joueurjaune = tmp.JoueurJaune;
        }
        #endregion
    }
}
