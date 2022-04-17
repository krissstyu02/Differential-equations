using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace laba6
{
    public partial class Form1 : Form
    {
        public static int n;
        public string ME = "Метод Эйлера";
        public string MRK2 = "Метод Рунге-Кутта второго порядка";
        ZedGraphControl zedGrapgControl1 = new ZedGraphControl();
        public Form1()
        {
            InitializeComponent();

        }
        protected override void OnLoad(EventArgs e)
        {
            zedGrapgControl1.Location = new Point(10, 30);
            zedGrapgControl1.Name = "text";
            zedGrapgControl1.Size = new Size(700, 700);
            Controls.Add(zedGrapgControl1);
            GraphPane my_Pane = zedGrapgControl1.GraphPane;
            my_Pane.Title.Text = "График функции";
            my_Pane.XAxis.Title.Text = " X";
            my_Pane.YAxis.Title.Text = " Y";

        }
        private void GetSize()
        {
            zedGrapgControl1.Location = new Point(10, 10);
            zedGrapgControl1.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 20);

        }
 
        static double f1(double x, double y)
        {
            return 3*x*x*y ;
        }
        static double f2(double x, double y)
        {
            return 3*x*x*y+x*x*Math.Pow(Math.E,x*x*x);
        }

        static double f3(double x)
        {
            return (x * x * x * Math.Pow(Math.E, x * x * x)) / 3;
        }

        static double f4(double x)
        {
            return Math.Pow(Math.E, x * x * x);
        }

        private void Eiler(ZedGraphControl Zed_GraphControl)
        {
            GraphPane my_Pane = Zed_GraphControl.GraphPane;

            PointPairList list = new PointPairList();

            double h = Convert.ToDouble(h0.Text);
            double y=  Convert.ToDouble(Y0.Text);
            double x= Convert.ToDouble(X0.Text);
            n = Convert.ToInt32(iter.Text);
            switch (comboBox1.Text)
                {
                    case "y'=3x^(2)*y":
                        {
                            for (int i = 0; i < n + 1; i++)
                            {
                                list.Add(x, y);
                                y = y + h * f1(x, y); 
                                x += h;
                            }
                        }
                        break;
                    case "y'=3x^2y+x^2*e^(x^3)":
                        {
                            for (int i = 0; i < n + 1; i++)
                            {
                                list.Add(x, y);
                                y = y + h * f2(x, y); 
                                x += h;
                            }
                        }
                        break;
                }
            LineItem myCircle = my_Pane.AddCurve(ME, list, Color.DeepPink, SymbolType.Circle);
            zedGrapgControl1.AxisChange();
            zedGrapgControl1.Invalidate();

        }

        private void RungeKutto2(ZedGraphControl Zed_GraphControl)
        {
            GraphPane my_Pane = Zed_GraphControl.GraphPane;
           
            PointPairList list = new PointPairList();

            double h = Convert.ToDouble(h0.Text);
            double y = Convert.ToDouble(Y0.Text);
            double x = Convert.ToDouble(X0.Text);
            n = Convert.ToInt32(iter.Text);


            switch (comboBox1.Text)
                {
                    case "y'=3x^(2)*y":
                        {
                            for (int i = 0; i < n + 1; i++)
                            {
                                list.Add(x, y);
                                double d = f1(x, y);
                                y = y + (h / 2) * (d + f1(x + h, y + h * d)); //делаем шаг
                                x += h;
                            }
                        }
                        break;
                    case "y'=3x^2y+x^2*e^(x^3)":
                        {
                            for (int i = 0; i < n + 1; i++)
                            {
                                list.Add(x, y);
                                double d = f2(x, y);
                                y = y + (h / 2) * (d + f2(x + h, y + h * d)); //делаем шаг
                                x += h;
                            }
                        }
                        break;
                }
                LineItem myCircle = my_Pane.AddCurve(MRK2, list, Color.DarkGoldenrod, SymbolType.Circle);
                zedGrapgControl1.AxisChange();
                zedGrapgControl1.Invalidate();
        }

        private void GriddenOn(GraphPane my_Pane)
        {
            my_Pane.XAxis.MajorGrid.IsVisible = true;
            my_Pane.YAxis.MajorGrid.IsVisible = true;
            my_Pane.YAxis.MinorGrid.IsVisible = true;
            my_Pane.XAxis.MinorGrid.IsVisible = true;
        }
        
        private void Clear(ZedGraphControl Zed_GraphControl)
        {
            //GraphPane pane = Zed_GraphControl.GraphPane;
            zedGrapgControl1.GraphPane.CurveList.Clear();
            zedGrapgControl1.GraphPane.GraphObjList.Clear();

            zedGrapgControl1.GraphPane.XAxis.Type = AxisType.Linear;
            zedGrapgControl1.GraphPane.XAxis.Scale.TextLabels = null;
            zedGrapgControl1.GraphPane.XAxis.MajorGrid.IsVisible = false;
            zedGrapgControl1.GraphPane.YAxis.MajorGrid.IsVisible = false;
            zedGrapgControl1.GraphPane.YAxis.MinorGrid.IsVisible = false;
            zedGrapgControl1.GraphPane.XAxis.MinorGrid.IsVisible = false;
            zedGrapgControl1.RestoreScale(zedGrapgControl1.GraphPane);

            zedGrapgControl1.AxisChange();
            zedGrapgControl1.Invalidate();
        }
        private void BTN_EM(object sender, EventArgs e)
        {
            GriddenOn(zedGrapgControl1.GraphPane);
            Eiler(zedGrapgControl1);

        }


        private void BTN_RK2(object sender, EventArgs e)
        {
            GriddenOn(zedGrapgControl1.GraphPane);

            RungeKutto2(zedGrapgControl1);
        }

        private void BTN_Clear(object sender, EventArgs e)
        {
            Clear(zedGrapgControl1);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void toch(ZedGraphControl Zed_GraphControl)
        {
            GraphPane my_Pane = Zed_GraphControl.GraphPane;
            PointPairList list = new PointPairList();
            double h = Convert.ToDouble(h0.Text);
            double y = Convert.ToDouble(Y0.Text);
            double x = Convert.ToDouble(X0.Text);
            n = Convert.ToInt32(iter.Text);
            double i;

            switch (comboBox1.Text)
            {
                case "y'=3x^(2)*y":
                    {
                        for (i = 0; i < 1; i+=h)
                        {
                            list.Add(i, f4(i));

                        }
                    }
                    break;
                case "y'=3x^2y+x^2*e^(x^3)":
                    {

                        for (i = 0; i <  1; i+=h)
                        {
                            list.Add(i, f3(i));
                        }


                    }
                    break;
            }
            LineItem myCircle = my_Pane.AddCurve(MRK2, list, Color.Black, SymbolType.Circle);
            zedGrapgControl1.AxisChange();
            zedGrapgControl1.Invalidate();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            GriddenOn(zedGrapgControl1.GraphPane);

            toch(zedGrapgControl1);
        }

    }
}
