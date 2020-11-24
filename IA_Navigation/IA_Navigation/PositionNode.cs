using System;
using System.Collections.Generic;
using System.Text;

namespace IA_Navigation
{
    class PositionNode : GenericNode
    {
        static double xf;
        static double yf;
        static int pavage;
        static string typePavage;

        public PositionNode(double x1, double y1)
        {
            x = x1;
            y = y1;
        }

        public PositionNode(double x1, double y1, double x1f, double y1f, int pav, string type)
        {
            x = x1;
            y = y1;
            xf = x1f;
            yf = y1f;
            pavage = pav;
            typePavage = type;

        }

        public override bool IsEqual(GenericNode N)
        {
            PositionNode Node = (PositionNode)N;

            //Vu que le pavage carré ne manipule pas de racines on met une condition d'égalité plus stricte
            if(typePavage == "carre")
                return (Math.Round(x) == Math.Round(Node.x) && Math.Round(y) == Math.Round(Node.y));
            else                
                return ((x >= Node.x - pavage && x <= Node.x + pavage) && (y > Node.y - pavage && y <= Node.y + pavage));
        }

        public override double GetArcCost(GenericNode N)
        {
            PositionNode Node = (PositionNode)N;
            return time_estimation(x, y, Node.x, Node.y);
        }

        public override bool EndState()
        {
            if (typePavage == "hexa" || typePavage == "hexaInverse")
                return ((x >= xf - pavage && x <= xf + pavage) && (y > yf - pavage && y <= yf + pavage));

            return ((x >= xf - pavage / 2.0 && x <= xf + pavage / 2.0) && (y > yf - pavage / 2.0 && y <= yf + pavage / 2.0));
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            if (typePavage == "hexa")
            {
                //Pavage hexagonal régulier de côté "pavage", en partant par la gauche, sens horaire, fonctionne pour cas A et C mais pas B
                PositionNode s1 = new PositionNode(x - (pavage * Math.Sqrt(3)), y);
                PositionNode s2 = new PositionNode(x - (pavage * Math.Sqrt(3) / 2), 1.5 * pavage + y);
                PositionNode s3 = new PositionNode(x + (pavage * Math.Sqrt(3) / 2), 1.5 * pavage + y);
                PositionNode s4 = new PositionNode(x + (pavage * Math.Sqrt(3)), y);
                PositionNode s5 = new PositionNode(x + (pavage * Math.Sqrt(3) / 2), y - 1.5 * pavage);
                PositionNode s6 = new PositionNode(x - (pavage * Math.Sqrt(3) / 2), y - 1.5 * pavage);

                if (s1.x >= 0 && s1.y >= 0 && s1.x <= 300 && s1.y <= 300)
                    lsucc.Add(s1);
                if (s2.x >= 0 && s2.y >= 0 && s2.x <= 300 && s2.y <= 300)
                    lsucc.Add(s2);
                if (s3.x >= 0 && s3.y >= 0 && s3.x <= 300 && s3.y <= 300)
                    lsucc.Add(s3);
                if (s4.x >= 0 && s4.y >= 0 && s4.x <= 300 && s4.y <= 300)
                    lsucc.Add(s4);
                if (s5.x >= 0 && s5.y >= 0 && s5.x <= 300 && s5.y <= 300)
                    lsucc.Add(s5);
                if (s6.x >= 0 && s6.y >= 0 && s6.x <= 300 && s6.y <= 300)
                    lsucc.Add(s6);
            }

            if (typePavage == "hexaInverse")
            {
                //Autre pavage hexagonal régulier de côté "pavage", renversement de l'hexagone, départ du bas, sens horaire
                PositionNode s1 = new PositionNode(x, y - (pavage * Math.Sqrt(3)));
                PositionNode s2 = new PositionNode(x - (pavage * 1.5), y - (pavage * Math.Sqrt(3) / 2));
                PositionNode s3 = new PositionNode(x - (pavage * 1.5), y + (pavage * Math.Sqrt(3) / 2));
                PositionNode s4 = new PositionNode(x, y + (pavage * Math.Sqrt(3)));
                PositionNode s5 = new PositionNode(x + (pavage * 1.5), y - (pavage * Math.Sqrt(3) / 2));
                PositionNode s6 = new PositionNode(x + (pavage * 1.5), y + (pavage * Math.Sqrt(3) / 2));

                if (s1.x >= 0 && s1.y >= 0 && s1.x <= 300 && s1.y <= 300)
                    lsucc.Add(s1);
                if (s2.x >= 0 && s2.y >= 0 && s2.x <= 300 && s2.y <= 300)
                    lsucc.Add(s2);
                if (s3.x >= 0 && s3.y >= 0 && s3.x <= 300 && s3.y <= 300)
                    lsucc.Add(s3);
                if (s4.x >= 0 && s4.y >= 0 && s4.x <= 300 && s4.y <= 300)
                    lsucc.Add(s4);
                if (s5.x >= 0 && s5.y >= 0 && s5.x <= 300 && s5.y <= 300)
                    lsucc.Add(s5);
                if (s6.x >= 0 && s6.y >= 0 && s6.x <= 300 && s6.y <= 300)
                    lsucc.Add(s6);
            }

            if (typePavage == "triangle")
            {
                //pavage triangulaire
                PositionNode s1 = new PositionNode(x - pavage, y);
                PositionNode s2 = new PositionNode(x + pavage, y);
                PositionNode s3 = new PositionNode(x + pavage / 2, y + Math.Sqrt(3) / 2 * pavage);
                PositionNode s4 = new PositionNode(x - pavage / 2, y + Math.Sqrt(3) / 2 * pavage);
                PositionNode s5 = new PositionNode(x + pavage / 2, y - Math.Sqrt(3) / 2 * pavage);
                PositionNode s6 = new PositionNode(x - pavage / 2, y - Math.Sqrt(3) / 2 * pavage);

                if (s1.x >= 0 && s1.y >= 0 && s1.x <= 300 && s1.y <= 300)
                    lsucc.Add(s1);
                if (s2.x >= 0 && s2.y >= 0 && s2.x <= 300 && s2.y <= 300)
                    lsucc.Add(s2);
                if (s3.x >= 0 && s3.y >= 0 && s3.x <= 300 && s3.y <= 300)
                    lsucc.Add(s3);
                if (s4.x >= 0 && s4.y >= 0 && s4.x <= 300 && s4.y <= 300)
                    lsucc.Add(s4);
                if (s5.x >= 0 && s5.y >= 0 && s5.x <= 300 && s5.y <= 300)
                    lsucc.Add(s5);
                if (s6.x >= 0 && s6.y >= 0 && s6.x <= 300 && s6.y <= 300)
                    lsucc.Add(s6);
            }


            if (typePavage == "carre")
            {
                //Pavage carré
                PositionNode s1 = new PositionNode(x - pavage, y);
                PositionNode s2 = new PositionNode(x + pavage, y);
                PositionNode s3 = new PositionNode(x + pavage, y + pavage);
                PositionNode s4 = new PositionNode(x - pavage, y + pavage);
                PositionNode s5 = new PositionNode(x + pavage, y - pavage);
                PositionNode s6 = new PositionNode(x - pavage, y - pavage);
                PositionNode s7 = new PositionNode(x, y + pavage);
                PositionNode s8 = new PositionNode(x, y - pavage);

                if (s1.x >= 0 && s1.y >= 0 && s1.x <= 300 && s1.y <= 300)
                    lsucc.Add(s1);
                if (s2.x >= 0 && s2.y >= 0 && s2.x <= 300 && s2.y <= 300)
                    lsucc.Add(s2);
                if (s3.x >= 0 && s3.y >= 0 && s3.x <= 300 && s3.y <= 300)
                    lsucc.Add(s3);
                if (s4.x >= 0 && s4.y >= 0 && s4.x <= 300 && s4.y <= 300)
                    lsucc.Add(s4);
                if (s5.x >= 0 && s5.y >= 0 && s5.x <= 300 && s5.y <= 300)
                    lsucc.Add(s5);
                if (s6.x >= 0 && s6.y >= 0 && s6.x <= 300 && s6.y <= 300)
                    lsucc.Add(s6);
                if (s7.x >= 0 && s7.y >= 0 && s7.x <= 300 && s7.y <= 300)
                    lsucc.Add(s7);
                if (s8.x >= 0 && s8.y >= 0 && s8.x <= 300 && s8.y <= 300)
                    lsucc.Add(s8);
            }                                 
            
            return lsucc;
        }

        public override double CalculeHCost()
        {
            //Vitesse maximale atteinte pour 45° et vaut 0.9*Vvent
            return (Math.Sqrt((x - xf) * (x - xf) + (y - yf) * (y - yf)))/(0.9*50) ;
            //return 0;

        }

        public override string ToString()
        {
            return "x = " + x + " ; y = " + y;
        }
        public static double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10)
                return 1000000;

            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed; 
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0)
                boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180)
                alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α/ 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v  */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        public static char Cas { get; set; } 
        // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public static double get_wind_speed ( double x, double y)
        {
            if (Cas == 'a')
                return 50;
            else if (Cas == 'b')
                if (y > 150)
                    return 50;
                else
                    return 20;
            else if (y > 150) 
                return 50; 
            else 
                return 20;
        }
        public static double get_wind_direction(double x, double y) 
        { 
            if (Cas == 'a')
                return 30;
            else if (Cas == 'b') 
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else 
                return 65;
        }
    }
}
