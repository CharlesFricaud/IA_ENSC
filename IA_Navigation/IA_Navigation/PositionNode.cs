using System;
using System.Collections.Generic;
using System.Text;

namespace IA_Navigation
{
    class PositionNode : GenericNode
    {
        public double xf;
        public double yf;

        public PositionNode(double x1, double y1)
        {
            x = x1;
            y = y1;
        }

        public PositionNode(double x1, double y1, double x1f, double y1f)
        {
            x = x1;
            y = y1;
            xf = x1f;
            yf = y1f;

        }

        public override bool IsEqual(GenericNode N)
        {
            PositionNode Node = (PositionNode)N;
            return (x == Node.x && y == Node.y);
        }

        public override double GetArcCost(GenericNode N)
        {
            PositionNode Node = (PositionNode) N;
            return time_estimation(x, y, Node.x, Node.y);
        }

        public override bool EndState()
        {
            return (x == xf && y == yf);
        }

        public override List<GenericNode> GetListSucc()
        {
            // pavage hexagonal régulier de côté 5, en partant par la gauche, sens horaire
            List<GenericNode> lsucc = new List<GenericNode>();
            PositionNode s1 = new PositionNode(x - (5 * Math.Sqrt(3)),y) ;
            PositionNode s2 = new PositionNode(x - (5 * Math.Sqrt(3) / 2), 15 / 2 + y);
            PositionNode s3 = new PositionNode(x + (5 * Math.Sqrt(3) / 2), 15 / 2 + y);
            PositionNode s4 = new PositionNode(x + (5 * Math.Sqrt(3)), y);
            PositionNode s5 = new PositionNode(x + (5 * Math.Sqrt(3) / 2), y - 15 / 2 );
            PositionNode s6 = new PositionNode(x - (5 * Math.Sqrt(3) / 2), y - 15 / 2 );

            lsucc.Add(s1);
            lsucc.Add(s2);
            lsucc.Add(s3);
            lsucc.Add(s4);
            lsucc.Add(s5);
            lsucc.Add(s6);

            return lsucc;
        }

        public override double CalculeHCost()
        {
            return 0;
        }

        public double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) 
                return 1000000;
            
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed; double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) 
                boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection -winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) 
                alpha = 360 -alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α/ 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 -0.2 * (alpha -45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v  */
                boatspeed = 0.7 * (1 -(alpha -90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        public char cas = 'a'; 
        // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        public double get_wind_speed ( double x, double y)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else
                    return 20;
            else if (y > 150) 
                return 50; 
            else 
                return 20;
        }
        public double get_wind_direction(double x, double y) 
        { 
            if (cas == 'a')
                return 30;
            else if (cas == 'b') 
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
