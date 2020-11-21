using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Navigation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            radHexa.Checked = true;
        }

        private void btn_ClickA(object sender, EventArgs e)
        {
            picBackground.Refresh(); //Permet d'effacer les trajets précedemments dessinés

            SearchTree g = new SearchTree();
            string type = "";

            if (radCarre.Checked)
                type = "carre";
            else if (radHexa.Checked)
                type = "hexa";
            else if (radHexaInverse.Checked)
                type = "hexaInverse";
            else
                type = "triangle";

            PositionNode N0 = new PositionNode(100, 200, 200,100, (int)numPavage.Value, type) ;
            PositionNode.Cas = 'a';
            double tempsTotal = 0;
            

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);
            if (Lres.Count == 0)
            {
                lblSolution.Text = "Pas de chemin trouvé";
            }
            else
            {
                lblSolution.Text = "Un chemin a été trouvée";
                //Dessin du chemin sur la carte
                Dessin.TracePoint(N0.x, N0.y, picBackground);                
                for (int i = 0; i < Lres.Count; i++)
                {
                    if (i != Lres.Count - 1)
                    {
                        tempsTotal += PositionNode.time_estimation(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y);
                        Dessin.TraceSegment(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y, picBackground);
                    }
                    else
                        Dessin.TracePoint(Lres[i].x, Lres[i].y, picBackground);
                }                
                g.GetSearchTree(trvBranche);
            }

            txtTemps.Text = "Temps total :" + " " + Math.Truncate(tempsTotal) + "h " + Math.Round((tempsTotal - Math.Truncate(tempsTotal))*60) + "min";

        }

        private void btn_ClickB(object sender, EventArgs e)
        {
            picBackground.Refresh(); //Permet d'effacer les trajets précedemments dessinés

            SearchTree g = new SearchTree();
            string type = "";

            if (radCarre.Checked)
                type = "carre";
            else if (radHexa.Checked)
                type = "hexa";
            else if (radHexaInverse.Checked)
                type = "hexaInverse";
            else
                type = "triangle";

            PositionNode N0 = new PositionNode(100, 200, 200, 100, (int)numPavage.Value, type);
            PositionNode.Cas = 'b';
            double tempsTotal = 0;


            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);
            if (Lres.Count == 0)
            {
                lblSolution.Text = "Pas de chemin trouvé";
            }
            else
            {
                lblSolution.Text = "Un chemin a été trouvée";
                //Dessin du chemin sur la carte
                Dessin.TracePoint(N0.x, N0.y, picBackground);
                for (int i = 0; i < Lres.Count; i++)
                {
                    if (i != Lres.Count - 1)
                    {
                        tempsTotal += PositionNode.time_estimation(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y);
                        Dessin.TraceSegment(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y, picBackground);
                    }
                    else
                        Dessin.TracePoint(Lres[i].x, Lres[i].y, picBackground);
                }
                g.GetSearchTree(trvBranche);
            }

            txtTemps.Text = "Temps total :" + " " + Math.Truncate(tempsTotal) + "h " + Math.Round((tempsTotal - Math.Truncate(tempsTotal)) * 60) + "min";

        }

        private void btn_ClickC(object sender, EventArgs e)
        {
            picBackground.Refresh(); //Permet d'effacer les trajets précedemments dessinés

            SearchTree g = new SearchTree();
            string type = "";

            if (radCarre.Checked)
                type = "carre";
            else if (radHexa.Checked)
                type = "hexa";
            else if (radHexaInverse.Checked)
                type = "hexaInverse";
            else
                type = "triangle";

            PositionNode N0 = new PositionNode(200, 100, 100, 200, (int)numPavage.Value, type);
            PositionNode.Cas = 'c';
            double tempsTotal = 0;


            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);
            if (Lres.Count == 0)
            {
                lblSolution.Text = "Pas de chemin trouvé";
            }
            else
            {
                lblSolution.Text = "Un chemin a été trouvée";
                //Dessin du chemin sur la carte
                Dessin.TracePoint(N0.x, N0.y, picBackground);
                for (int i = 0; i < Lres.Count; i++)
                {
                    if (i != Lres.Count - 1)
                    {
                        tempsTotal += PositionNode.time_estimation(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y);
                        Dessin.TraceSegment(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y, picBackground);
                    }
                    else
                        Dessin.TracePoint(Lres[i].x, Lres[i].y, picBackground);
                }
                g.GetSearchTree(trvBranche);
            }

            txtTemps.Text = "Temps total :" + " " + Math.Truncate(tempsTotal) + "h " + Math.Round((tempsTotal - Math.Truncate(tempsTotal)) * 60) + "min";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
