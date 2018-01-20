using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance4Version2
{
    public partial class ChargementTab : Form
    {
        private Rectangle[] ColonnesTab;
        public int[,] Tab;
        public int Tour;
        Saveload test = new Saveload();
        public string JoueurRouge;
        public string JoueurJaune;

        public ChargementTab()
        {
            InitializeComponent();
            this.ColonnesTab = new Rectangle[7];

            this.Tab = new int[6, 7];
            this.Tour = 1;
            //MessageBox.Show(this.Tab[0, 0].ToString());
            Saveload test = new Saveload();

        }

        private void PlateauJeu(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 24, 24, 340, 300);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0)
                    {
                        this.ColonnesTab[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
                    }
                    e.Graphics.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            e.Graphics.FillRectangle(Brushes.Blue, 24, 24, 340, 300);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0)
                    {
                        this.ColonnesTab[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
                    }
                    e.Graphics.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                }
            }
        }
        public void ChargementTab_MouseClick(object sender, MouseEventArgs e)
        {
            int NumColonne = this.NbColonnes(e.Location);
            if (NumColonne != -1)
            {
                int NumRang = this.RangVide(NumColonne);
                if (NumRang != -1)
                {
                    this.Tab[NumRang, NumColonne] = this.Tour;
                    if (this.Tour == 1)
                    {
                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Red, 32 + 48 * NumColonne, 32 + 48 * NumRang, 32, 32);
                        //MessageBox.Show("NbColonne" + NumColonne + " NRang" + NumRang + ".");
                    }
                    else if (this.Tour == 2)
                    {
                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Yellow, 32 + 48 * NumColonne, 32 + 48 * NumRang, 32, 32);
                       // MessageBox.Show("NbColonne" + NumColonne + " NRang" +NumRang+ ".");
                    }

                    int findepartie = this.Gagnant(this.Tour);
                    if (findepartie != -1)
                    {
                        string joueur = (findepartie == 1) ? "Rouge" : "Jaune";//pareil que mettre if findepartie = 1 joueur rouge gagne, else joueur jaune
                        MessageBox.Show("Felicitations ! Joueur " + joueur +" a gagné!");
                        Application.Restart();
                    }
                    if (this.Tour == 1)
                    {
                        this.t_mouvement.Text = "Coup précédent : Joueur Rouge  Colonne " + ( NumColonne + 1 ) + " Rang " + ( NumRang + 1 );
                        this.Tour = 2;
                    }
                    else
                    {
                        this.t_mouvement.Text = "Coup précédent : Joueur Jaune  Colonne " + ( NumColonne + 1 )+ " Rang "+( NumRang +1 );
                        this.Tour = 1;
                    }
                }
                if (CheckEgalite())
                {
                    MessageBox.Show("Egalite !");
                    Application.Restart();
                }
              }
                
        }

        private int Gagnant(int VerifJoueur)
        {
            //verticalement verif
            for (int rang = 0; rang < this.Tab.GetLength(0) -3; rang++)
            {
            for(int col = 0; col <this.Tab.GetLength(1);col++ )
                {
                    if (this.NumEgaux(VerifJoueur,  this.Tab[rang, col], this.Tab[rang + 1, col], this.Tab[rang + 2, col], this.Tab[rang + 3, col]))
                        return VerifJoueur;
                }
            }

            // horizontalement verif
            for (int rang = 0; rang < this.Tab.GetLength(0); rang++)
            {
                for (int col = 0; col < this.Tab.GetLength(1)-3; col++)
                {
                    if (this.NumEgaux(VerifJoueur, this.Tab[rang, col], this.Tab[rang, col +1], this.Tab[rang, col +2], this.Tab[rang , col +3]))
                        return VerifJoueur;
                }
            }
            //Diagonalement en haut à gauche
            for (int rang = 0; rang < this.Tab.GetLength(0) - 3; rang++)
            {
                for (int col = 0; col < this.Tab.GetLength(1) - 3; col++)
                {
                    if (this.NumEgaux(VerifJoueur, this.Tab[rang, col], this.Tab[rang + 1, col +1], this.Tab[rang + 2, col +2], this.Tab[rang + 3, col+3]))
                        return VerifJoueur;
                }
            }
            //Diagonalement en haut à droite
            for (int rang = 0; rang < this.Tab.GetLength(0) - 3; rang++)
            {
                for (int col = 3; col < this.Tab.GetLength(1); col++)
                {
                    if (this.NumEgaux(VerifJoueur, this.Tab[rang, col], this.Tab[rang + 1, col - 1], this.Tab[rang + 2, col - 2], this.Tab[rang + 3, col - 3]))
                        return VerifJoueur;
                }
            }
            return -1;
        }

       
        private bool NumEgaux(int Verif, params int [] nombres)
        {
            foreach (int num in nombres)
            {
                if (num != Verif)
                    return false;
            }
            return true;
        }

        private int NbColonnes(Point souris)
        {
            for (int i = 0; i < this.ColonnesTab.Length; i++)
            {
                if ((souris.X >= this.ColonnesTab[i].X) && (souris.Y >= this.ColonnesTab[i].Y))
                {
                    if ((souris.X <= this.ColonnesTab[i].X + this.ColonnesTab[i].Width) && (souris.Y <= this.ColonnesTab[i].Y + this.ColonnesTab[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private int RangVide(int col)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (this.Tab[i, col] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        private bool CheckEgalite()
        {
            int [,]tab = this.Tab;
            for(int i =0;i<tab.GetLength(0);i++)
            {
                if (tab[0,i]==0) return false;
            }
            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            JoueurRouge = t_JoueurRouge.Text;
            JoueurJaune = t_JoueurJaune.Text;
            test.Save(Tab, Tour, JoueurRouge, JoueurJaune, "D:/Documents/Visual Studio 2015/Projects/Puissance4Version2/Puissance4Version2/Save_test.xml");
        }

        private void btn_charger_Click(object sender, EventArgs e)
        {
            test.Load(Tab, Tour, JoueurRouge, JoueurJaune, "D:/Documents/Visual Studio 2015/Projects/Puissance4Version2/Puissance4Version2/Save_test.xml");
        }
    }
}

