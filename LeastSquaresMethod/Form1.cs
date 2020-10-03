using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LeastSquaresMethod
{
    public partial class Form1 : Form
    {
        private double[,] NodesTable;

        public Form1()
        {
            InitializeComponent();

            UpdatePlotsArea(10, -10, 10, -10);

            //double x = -10;
            double y;
            Series sinePlot = new Series();
            sinePlot.LegendText = "y=sin(x)";
            sinePlot.ChartType = SeriesChartType.Spline;
            sinePlot.BorderWidth = 2;
            sinePlot.Color = Color.Red;
            for (int i = -10; i <= 10; i++)
            {
                y = Math.Sin(i);
                sinePlot.Points.AddXY(i, y);
            }
            plotsArea.Series.Add(sinePlot);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            approximatingFunctionList.SelectedIndex = 0;
            UpdateTable();
        }

        private void NumberOfNodesUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable(); 
        }

        private void UpdateTable()
        {
            nodesData.RowCount = Convert.ToInt32(numberOfNodesUpDown.Value);
            for (int i = 0; i < nodesData.RowCount; i++)
            {
                nodesData[0, i].ValueType = System.Type.GetType("System.Double");
                nodesData[1, i].ValueType = System.Type.GetType("System.Double");
                if (Convert.ToString(nodesData[0, i].Value) == "")
                    nodesData[0, i].Value = 0;
                if (Convert.ToString(nodesData[1, i].Value) == "")
                    nodesData[1, i].Value = 0;
            }
        }

        private void UpdatePlotsArea(double maxX, double minX, double maxY, double minY)
        {
            plotsArea.Series.Clear();

            plotsArea.ChartAreas[0].AxisX.Minimum = minX;
            plotsArea.ChartAreas[0].AxisX.Maximum = maxX;
            plotsArea.ChartAreas[0].AxisY.Minimum = minY;
            plotsArea.ChartAreas[0].AxisY.Maximum = maxY;

            plotsArea.ChartAreas[0].AxisX.MajorGrid.Interval = Math.Abs(maxX - minX) / 10;
            plotsArea.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            plotsArea.ChartAreas[0].AxisY.MajorGrid.Interval = Math.Abs(maxY - minY) / 10;
            plotsArea.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            Series abscissaAxis = new Series();
            abscissaAxis.LegendText = "X and";
            abscissaAxis.ChartType = SeriesChartType.Line;
            abscissaAxis.Points.AddXY(minX, 0);
            abscissaAxis.Points.AddXY(maxX, 0);
            abscissaAxis.Color = Color.LimeGreen;
            abscissaAxis.BorderWidth = 1;
            plotsArea.Series.Add(abscissaAxis);

            Series ordinateAxis = new Series();
            ordinateAxis.LegendText = "Y axis";
            ordinateAxis.ChartType = SeriesChartType.Line;
            ordinateAxis.Points.AddXY(0, minY);
            ordinateAxis.Points.AddXY(0, maxY);
            ordinateAxis.Color = Color.LimeGreen;
            ordinateAxis.BorderWidth = 1;
            plotsArea.Series.Add(ordinateAxis);
        }

        private void NodesData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The value in the cell is not a real number.\nMake the correct entry.");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //занесение данных из таблицы узлов в поле
            //попутное нахождение максимумов и минимумов
            NodesTable = new double[2, nodesData.RowCount];
            double minX = 10, maxX = -10, minY = 10, maxY = -10;
            for (int i = 0; i < nodesData.RowCount; i++)
            {
                NodesTable[0, i] = Double.Parse(nodesData[0, i].Value.ToString().Replace(",","."));
                NodesTable[1, i] = Double.Parse(nodesData[1, i].Value.ToString().Replace(",", "."));

                if (NodesTable[0, i] < minX)
                    minX = NodesTable[0, i];
                if (NodesTable[0, i] > maxX)
                    maxX = NodesTable[0, i];
                if (NodesTable[1, i] < minY)
                    minY = NodesTable[1, i];
                if (NodesTable[1, i] > maxY)
                    maxY = NodesTable[1, i];
            }

            //обновление области графика в соответсвии с данными
            UpdatePlotsArea(maxX, minX, maxY, minY);

            //нанесение узлов на график
            Series nodes = new Series();
            nodes.LegendText = "Nodes";
            nodes.ChartType = SeriesChartType.Point;
            nodes.Color = Color.DarkViolet;
            for (int i = 0; i < nodesData.RowCount; i++)
            {
                nodes.Points.AddXY(NodesTable[0, i], NodesTable[1, i]);
            }
            plotsArea.Series.Add(nodes);


        }
    }
}
