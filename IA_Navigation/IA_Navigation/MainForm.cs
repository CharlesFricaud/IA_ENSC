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
        }

        private void btn_ClickA(object sender, EventArgs e)
        {
            SearchTree g = new SearchTree();

            PositionNode N0 = new PositionNode(100, 200, 200,100) ;
            

            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);
            if (Lres.Count == 0)
            {
                lblSolution.Text = "Pas de chemin trouvé";
            }
            else
            {
                lblSolution.Text = "Une chemin a été trouvée";
                //Dessin du chemin sur la carte
                Dessin.TracePoint(N0.x, N0.y, picBackground);
                for (int i = 0; i < Lres.Count; i++)
                {
                    
                    if (i != Lres.Count - 1)                        
                        Dessin.TraceSegment(Lres[i].x, Lres[i].y, Lres[i + 1].x, Lres[i + 1].y, picBackground);
                    else
                        Dessin.TracePoint(Lres[i].x, Lres[i].y, picBackground);
                }                
                g.GetSearchTree(trvBranche);
            }

        }
    }
}
