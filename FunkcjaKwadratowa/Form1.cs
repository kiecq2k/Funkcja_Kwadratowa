using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkcjaKwadratowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // wspolczynniki funkcji kwadratowej
        double a;
        double b;
        double c;
        double delta;
        double x1;
        double x2;
        double x0;
        double p;
        double q;
        double sqrtDelta;
        // znak rownania lub nierownosci
        string znak;

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            string wprowadzone = "";
            // skopiowanie do zmiennych a,b,c,znak wartosci z pol tekstowych
             a = Convert.ToDouble(tbA.Text);
             b = Convert.ToDouble(tbB.Text);
             c = Convert.ToDouble(tbC.Text);
            znak = Convert.ToString(tbZnak.Text);
            delta = b * b - 4 * a * c; // obliczenie delty
            p = -b / (2 * a);
            q = -delta / (4 * a);
            sqrtDelta = Math.Sqrt(delta);

            string aa = (a == 1) ? "x2 " : Convert.ToString(Math.Round(a,1)) + "x2 ";
            if(a == -1)
            {
                aa = "-x2 ";
            }
            string bb="", cc="";
            if(b == 0)
            {
                bb = "";
            }
            else if(b<0)
            {
                bb = Convert.ToString(Math.Round(b, 1)) + "x ";
            }
            else if(b>0)
            {
                bb = " + " + Convert.ToString(Math.Round(b, 1)) + "x ";
            }
            if(c == 0)
            {
                cc = "";
            }
            else if(c>0)
            {
                cc = " + " + Convert.ToString(Math.Round(c, 1));
            }
            else
            {
                cc = Convert.ToString(Math.Round(c, 1)) + "";
            }
           

            if (znak != "")
            {
                wprowadzone = aa + bb + cc + znak + " 0";
            }
            else
            {
                wprowadzone = aa + bb + cc + " = " + " 0";
            }
            labelWpr.Text += "Wprowadzilas:  ";
            labelWpr.Text += wprowadzone;

            // wyswietlenie wierzcholka
            labelW.Text += String.Format("\nWIERZCHOLEK\n");
            labelW.Text += String.Format("\n\np = {0} / {1}\n", Math.Round(-b,1),Math.Round(2*a,1));
            labelW.Text += String.Format("p = {0}\n", Math.Round(p,1));
            labelW.Text += String.Format("q = {0} / {1}\n", Math.Round(-delta,1), Math.Round(4*a,1));
            labelW.Text += String.Format("q = {0}\n", Math.Round(q,1));
            labelW.Text += String.Format("W = ({0} ; {1})\n", Math.Round(p,1), Math.Round(q,1));
           
            
            if (delta>0)
            {
                // wyswietlenie miejsc zerowych i delty
                x1 = (-b - sqrtDelta) / (2 * a);
                x2 = (-b + sqrtDelta) / (2 * a);
                labelX.Text += String.Format("\nMIEJSCA ZEROWE\n");
                labelX.Text += String.Format("\ndelta = {0} - {1}", Math.Round(b * b,1), Math.Round(4 * a * c,1));
                labelX.Text += String.Format("\ndelta = {0}", Math.Round(delta,1));
                labelX.Text += String.Format("\nx1 = ({0}{1})/{2}", Math.Round(-b,1), Math.Round(-Math.Sqrt(delta),1), Math.Round(2*a,1));
                labelX.Text += String.Format("\nx1 = {0}/{1}", Math.Round(-b - sqrtDelta, 1), Math.Round(2 * a, 1));
                labelX.Text += String.Format("\nx1 = {0}", Math.Round(x1,1));
                labelX.Text += String.Format("\nx2 = ({0}+{1})/{2}", Math.Round(-b,1), Math.Round(Math.Sqrt(delta),1), Math.Round(2*a,1));
                labelX.Text += String.Format("\nx1 = {0}/{1}", Math.Round(-b + sqrtDelta, 1), Math.Round(2 * a, 1));
                labelX.Text += String.Format("\nx2 = {0}", Math.Round(x2,1));
                // wyswietlenie nierownosci


            }
            else if(delta == 0)
            {
                // wyswietlenie miejsc zerowych i delty
                x0 = -b / 2 * a;
                labelX.Text += String.Format("\nMIEJSCA ZEROWE\n");
                labelX.Text += String.Format("\ndelta = {0}  {1}", Math.Round(b * b, 1), Math.Round(-4 * a * c, 1));
                labelX.Text += String.Format("\ndelta = {0}", Math.Round(delta, 1));
                labelX.Text += String.Format("\nx = {0}/{1}", -b, 2*a);
                labelX.Text += String.Format("\nx = {0}",x0);

            }
            else
            {
                // wyswietlenie miejsc zerowych i delty
                labelX.Text += String.Format("\nMIEJSCA ZEROWE\n");
                labelX.Text += String.Format("\ndelta = {0}  {1}", Math.Round(b * b, 1), Math.Round(-4 * a * c, 1));
                labelX.Text += String.Format("\ndelta = {0}", Math.Round(delta, 1));
                labelX.Text += String.Format("\nBrak miejsc zerowych!");
            }
            nierownosc();

        }

        // zresetowanie
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";
            tbZnak.Text = "";
            labelW.Text = "";
            labelX.Text = "";
            labelNier.Text = "";
            labelWpr.Text = "";
        }

        private void nierownosc()
        {
            labelNier.Text += String.Format("\nNIEROWNOSC\n\n");
            // ew. zamiana x1 z x2
            string x11 = "x1";
            string x22 = "x2";
            
            if(delta > 0)
            {
                if(x1 > x2)
                {
                    double temp = x1;
                    x1 = x2;
                    x2 = temp;
                    string tempX = x11;
                    x11 = x22;
                    x22 = tempX;
                }
            }
  
            // 1 przyp.
            if (delta>0 && a>0)
            {

                if(znak == "<")
                {
                    labelNier.Text += String.Format("\nx naleza do ({0} , {1})\n", x11, x22);
                    labelNier.Text += String.Format("x naleza do ({0} , {1})", Math.Round(x1,1), Math.Round(x2,1));
                }
                else if(znak == "<=")
                {
                    labelNier.Text += String.Format("\nx naleza do <{0} , {1}>\n", x11, x22);
                    labelNier.Text += String.Format("x naleza do <{0} , {1}>", Math.Round(x1, 1), Math.Round(x2, 1));
                }
                else if(znak == ">")
                {
                    labelNier.Text += String.Format("\nx naleza do (-niesk , {0}) U ({1} , +niesk)\n", x11, x22);
                    labelNier.Text += String.Format("x naleza do (-niesk , {0}) U ({1} , +niesk)",Math.Round(x1,1),Math.Round(x2,1));
                }
                else if(znak == ">=")
                {
                    labelNier.Text += String.Format("\nx naleza do (-niesk , {0}> U <{1} , +niesk)\n",x11, x22);
                    labelNier.Text += String.Format("x naleza do (-niesk , {0}> U <{1} , +niesk)", Math.Round(x1, 1), Math.Round(x2, 1));
                }
            }
            // 2 przyp.
            else if(delta>0 && a<0)
            {
                if (znak == "<")
                {
                    labelNier.Text += String.Format("\nx naleza do (-niesk , {0}) U ({1} , +niesk)\n",x11, x22);
                    labelNier.Text += String.Format("x naleza do (-niesk , {0}) U ({1} , +niesk)", Math.Round(x1, 1), Math.Round(x2, 1));
                }
                else if (znak == "<=")
                {
                    labelNier.Text += String.Format("\nx naleza do (-niesk , {0}> U <{1} , +niesk)\n", x11, x22);
                    labelNier.Text += String.Format("x naleza do (-niesk , {0}> U <{1} , +niesk)", Math.Round(x1, 1), Math.Round(x2, 1));
                }
                else if (znak == ">")
                {
                    labelNier.Text += String.Format("\nx naleza do ({0} , {1})\n", x11, x22);
                    labelNier.Text += String.Format("x naleza do ({0} , {1})", Math.Round(x1, 1), Math.Round(x2, 1));
                }
                else if (znak == ">=")
                {
                    labelNier.Text += String.Format("\nx naleza do <{0} , {1}>\n", x11, x22);
                    labelNier.Text += String.Format("x naleza do <{0} , {1}>", Math.Round(x1, 1), Math.Round(x2, 1));
                }
            }
            //3 przyp.
            else if(delta==0 && a>0)
            {
                if (znak == "<")
                {
                    labelNier.Text += String.Format("x naleza do zbioru pustego");
                }
                else if (znak == "<=")
                {
                    labelNier.Text += String.Format("x naleza do {0}{1}{2}", "{",Math.Round(x0, 1),"}");
                }
                else if (znak == ">")
                {
                    labelNier.Text += String.Format("x naleza do R / {0}{1}{2}","{", Math.Round(x0,1),"}");
                }
                else if (znak == ">=")
                {
                    labelNier.Text += String.Format("x naleza do R");
                }
            }
            //4 przyp.
            else if(delta==0 && a<0)
            {
                if (znak == "<")
                {
                    labelNier.Text += String.Format("x naleza do R / {0}{1}{2}", "{",Math.Round(x0, 1), "}");
                }
                else if (znak == "<=")
                {
                    labelNier.Text += String.Format("x naleza do R");
                }
                else if (znak == ">")
                {
                    labelNier.Text += String.Format("x naleza do zbioru pustego");
                }
                else if (znak == ">=")
                {
                    labelNier.Text += String.Format("x naleza do {0}{1}{2}", "{",Math.Round(x0, 1),"}");
                }
            }
            //5 przyp.
            else if(delta<0 && a>0)
            {
                if (znak == "<")
                {
                    labelNier.Text += String.Format("x naleza do zbioru pustego");
                }
                else if (znak == "<=")
                {
                    labelNier.Text += String.Format("x naleza do zbioru pustego");
                }
                else if (znak == ">")
                {
                    labelNier.Text += String.Format("x naleza do R");
                }
                else if (znak == ">=")
                {
                    labelNier.Text += String.Format("x naleza do R");
                }
            }
            //6 przyp.
            else if(delta<0 && a<0)
            {
                if (znak == "<")
                {
                    labelNier.Text += String.Format("x naleza do R");
                }
                else if (znak == "<=")
                {
                    labelNier.Text += String.Format("x naleza do R");
                }
                else if (znak == ">")
                {
                    labelNier.Text += String.Format("x naleza do zbioru pustego");
                }
                else if (znak == ">=")
                {
                    labelNier.Text += String.Format("x naleza do zbioru pustego");
                }
            }
        }
    }
}
