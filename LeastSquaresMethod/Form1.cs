using System;
using System.Drawing;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            approximatingFunctionList.SelectedIndex = 0;
            UpdateTable();
            UpdatePlotsArea(10, -10, 10, -10);
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
            //вводные данные
            int approximatingFunctionIndex = approximatingFunctionList.SelectedIndex;
            int nodesCount = (int)numberOfNodesUpDown.Value;

            //занесение данных из таблицы узлов в поле
            //проверки на возможность поиска аппроксимирующих коэффициентов
            NodesTable = new double[2, nodesData.RowCount];
            bool negativeOrZeroAbscissaExistence = false, negativeOrZeroOrdinateExistence = false;
            for (int i = 0; i < nodesData.RowCount; i++)
            {
                NodesTable[0, i] = Double.Parse(nodesData[0, i].Value.ToString());
                NodesTable[1, i] = Double.Parse(nodesData[1, i].Value.ToString());
                if (!negativeOrZeroAbscissaExistence & NodesTable[0, i] <= 0) negativeOrZeroAbscissaExistence = true;
                if (!negativeOrZeroOrdinateExistence & NodesTable[1, i] <= 0) negativeOrZeroOrdinateExistence = true;
            }

            if((negativeOrZeroAbscissaExistence & (approximatingFunctionIndex == 1 | approximatingFunctionIndex == 2 | approximatingFunctionIndex == 3)) | (negativeOrZeroOrdinateExistence & (approximatingFunctionIndex == 1 | approximatingFunctionIndex == 2)))
            {
                outputConsole.AppendText("Requirements to find a solution ability:\r\n" +
                    "X > 0 for approximating functions #2, #3, #4;\r\n" +
                    "Y > 0 for approximating functions #2, #3;\r\n" +
                    "in cause to the use of the natural logarithm\r\nwhen calculating the coefficients.\r\n" +
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n");
                return;
            }

            //поиски макс и мин для отображения графика
            double minX = 10, maxX = -10, minY = 10, maxY = -10;
            for (int i = 0; i < nodesData.RowCount; i++)
            {
                if (NodesTable[0, i] < minX)
                    minX = NodesTable[0, i];
                if (NodesTable[0, i] > maxX)
                    maxX = NodesTable[0, i];
                if (NodesTable[1, i] < minY)
                    minY = NodesTable[1, i];
                if (NodesTable[1, i] > maxY)
                    maxY = NodesTable[1, i];
            }

            if (minX == maxX)
            {
                minX = -10;
                maxX = 10;
            }
            if (minY == maxY)
            {
                minY = -10;
                maxY = 10;
            }

            //обновление области графика в соответсвии с данными
            plotsArea.Series.Clear();
            UpdatePlotsArea(maxX, minX, maxY, minY);

            //вычисление коэффициентов МНК и прочего
            var solution = new LeastSquaresMethodRealisation(approximatingFunctionIndex, NodesTable, nodesCount);

            if (solution.SolutionExistence)
            {
                //соритруем узлы
                double xContainer, yContainer;
                for(int i = 0; i < nodesCount - 1; i++)
                {
                    for(int j = i + 1; j < nodesCount; j++)
                    {
                        if (NodesTable[0, i] > NodesTable[0, j])
                        {
                            xContainer = NodesTable[0, i];
                            yContainer = NodesTable[1, i];

                            NodesTable[0, i] = NodesTable[0, j];
                            NodesTable[1, i] = NodesTable[1, j];

                            NodesTable[0, j] = xContainer;
                            NodesTable[1, j] = yContainer;
                        }
                    }
                }

                //рисование первого графика, до исключения точки с наибольшим отклонением
                Series plot1 = new Series();
                plot1.LegendText = "y1";
                plot1.ChartType = SeriesChartType.Spline;
                plot1.BorderWidth = 2;
                plot1.Color = Color.Blue;
                double x;
                double y;
                for (int i = 0; i < nodesCount; i++)
                {
                    x = NodesTable[0, i];
                    y = 0;
                    switch (approximatingFunctionIndex)
                    {
                        case 0:
                            y = solution.ResultСoefficients[0] * x + solution.ResultСoefficients[1];
                            break;
                        case 1:
                            y = solution.ResultСoefficients[1] * Math.Pow(x, solution.ResultСoefficients[0]);
                            break;
                        case 2:
                            y = solution.ResultСoefficients[1] * Math.Pow(Math.E, x * solution.ResultСoefficients[0]);
                            break;
                        case 3:
                            y = solution.ResultСoefficients[0] * Math.Log(x) + solution.ResultСoefficients[1];
                            break;
                        case 4:
                            y = solution.ResultСoefficients[0] * x * x + solution.ResultСoefficients[1] * x + solution.ResultСoefficients[2];
                            break;
                    }
                    plot1.Points.AddXY(x, y);
                }
                plotsArea.Series.Add(plot1);

                //вывод вычисленных данных
                outputConsole.AppendText("Approximating function before excluding the point with maximum deviation:\r\n");
                switch (approximatingFunctionIndex)
                {
                    case 0:
                        outputConsole.AppendText("y1 = " + Math.Round(solution.ResultСoefficients[0], 6) + "*x + " + Math.Round(solution.ResultСoefficients[1], 6) + "\r\n");
                        break;
                    case 1:
                        outputConsole.AppendText("y1 = " + Math.Round(solution.ResultСoefficients[1], 6) + "*x^" + Math.Round(solution.ResultСoefficients[0], 6) + "\r\n");
                        break;
                    case 2:
                        outputConsole.AppendText("y1 = " + Math.Round(solution.ResultСoefficients[1], 6) + "*e^(" + Math.Round(solution.ResultСoefficients[0], 6) + "*x)\r\n");
                        break;
                    case 3:
                        outputConsole.AppendText("y1 = " + Math.Round(solution.ResultСoefficients[0], 6) + "*ln(x) + " + Math.Round(solution.ResultСoefficients[1], 6) + "\r\n");
                        break;
                    case 4:
                        outputConsole.AppendText("y1 = " + Math.Round(solution.ResultСoefficients[0], 6) + "*x^2 + " + Math.Round(solution.ResultСoefficients[1], 6) + "*x + " + Math.Round(solution.ResultСoefficients[2], 6) + "\r\n");
                        break;
                }
                outputConsole.AppendText("Measure of deviation: " + Math.Round(solution.MeasureOfDeviation, 6) + "\r\n");
                outputConsole.AppendText("Correlation coefficient: " + Math.Round(solution.CorrelationCoefficient, 6) + "\r\n");
                outputConsole.AppendText("Root mean square deviation: " + Math.Round(solution.RootMeanSquareDeviation, 6) + "\r\n");

                if (solution.MaximumNodeDeviationExistence)
                {
                    //исключение точки и перерасчёт
                    double[,] newXY = new double[2, nodesCount - 1];
                    int k = 0, m = 0;
                    while (k < nodesCount)
                    {
                        if (k != solution.NodeWithMaximumDeviationIndex)
                        {
                            newXY[0, m] = NodesTable[0, k];
                            newXY[1, m] = NodesTable[1, k];
                            m++;
                        }
                        k++;
                    }                    

                    var solution2 = new LeastSquaresMethodRealisation(approximatingFunctionIndex, newXY, nodesCount - 1);

                    //рисование второго графика, после исключения точки с наибольшим отклонением
                    Series plot2 = new Series();
                    plot2.LegendText = "y2";
                    plot2.ChartType = SeriesChartType.Spline;
                    plot2.BorderWidth = 2;
                    plot2.Color = Color.LightBlue;
                    for (int i = 0; i < nodesCount - 1; i++)
                    {
                        x = newXY[0, i];
                        y = 0;
                        switch (approximatingFunctionIndex)
                        {
                            case 0:
                                y = solution2.ResultСoefficients[0] * x + solution2.ResultСoefficients[1];
                                break;
                            case 1:
                                y = solution2.ResultСoefficients[1] * Math.Pow(x, solution2.ResultСoefficients[0]);
                                break;
                            case 2:
                                y = solution2.ResultСoefficients[1] * Math.Pow(Math.E, x * solution2.ResultСoefficients[0]);
                                break;
                            case 3:
                                y = solution2.ResultСoefficients[0] * Math.Log(x) + solution2.ResultСoefficients[1];
                                break;
                            case 4:
                                y = solution2.ResultСoefficients[0] * x * x + solution2.ResultСoefficients[1] * x + solution2.ResultСoefficients[2];
                                break;
                        }
                        plot2.Points.AddXY(x, y);
                    }
                    plotsArea.Series.Add(plot2);

                    //вывод изменённых вычисленных данных
                    outputConsole.AppendText("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\nApproximating function after excluding the point with maximum deviation:\r\n");
                    switch (approximatingFunctionIndex)
                    {
                        case 0:
                            outputConsole.AppendText("y2 = " + Math.Round(solution2.ResultСoefficients[0], 6) + "*x + " + Math.Round(solution2.ResultСoefficients[1], 6) + "\r\n");
                            break;
                        case 1:
                            outputConsole.AppendText("y2 = " + Math.Round(solution2.ResultСoefficients[1], 6) + "*x^" + Math.Round(solution2.ResultСoefficients[0], 6) + "\r\n");
                            break;
                        case 2:
                            outputConsole.AppendText("y2 = " + Math.Round(solution2.ResultСoefficients[1], 6) + "*e^(" + Math.Round(solution2.ResultСoefficients[0], 6) + "*x)\r\n");
                            break;
                        case 3:
                            outputConsole.AppendText("y2 = " + Math.Round(solution2.ResultСoefficients[0], 6) + "*ln(x) + " + Math.Round(solution2.ResultСoefficients[1], 6) + "\r\n");
                            break;
                        case 4:
                            outputConsole.AppendText("y2 = " + Math.Round(solution2.ResultСoefficients[0], 6) + "*x^2 + " + Math.Round(solution2.ResultСoefficients[1], 6) + "*x + " + Math.Round(solution2.ResultСoefficients[2], 6) + "\r\n");
                            break;
                    }
                    outputConsole.AppendText("Measure of deviation: " + Math.Round(solution2.MeasureOfDeviation, 6) + "\r\n");
                    outputConsole.AppendText("Correlation coefficient: " + Math.Round(solution2.CorrelationCoefficient, 6) + "\r\n");
                    outputConsole.AppendText("Root mean square deviation: " + Math.Round(solution2.RootMeanSquareDeviation, 6) + "\r\n");
                    outputConsole.AppendText("\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\r\n");

                    //нанесение узлов на график
                    Series nodes = new Series();
                    nodes.LegendText = "Nodes";
                    nodes.ChartType = SeriesChartType.Point;
                    nodes.Color = Color.DarkViolet;
                    for (int i = 0; i < nodesData.RowCount; i++)
                    {
                        if (i != solution.NodeWithMaximumDeviationIndex)
                        {
                            nodes.Points.AddXY(NodesTable[0, i], NodesTable[1, i]);
                        }
                    }
                    plotsArea.Series.Add(nodes);

                    //рисование точки с набольшим отклонением
                    Series nodeWithMaximumDeviation = new Series();
                    nodeWithMaximumDeviation.LegendText = "Node with max deviation";
                    nodeWithMaximumDeviation.ChartType = SeriesChartType.Point;
                    nodeWithMaximumDeviation.Color = Color.OrangeRed;
                    nodeWithMaximumDeviation.Points.AddXY(NodesTable[0, solution.NodeWithMaximumDeviationIndex], NodesTable[1, solution.NodeWithMaximumDeviationIndex]);
                    plotsArea.Series.Add(nodeWithMaximumDeviation);
                }
                else
                {
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

                    outputConsole.AppendText("Node with maximum deviation does not exist.\r\n");
                    outputConsole.AppendText("\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\r\n");
                }

            }
            else
            {
                outputConsole.AppendText("Impossible to calculate the coefficients\r\nwith these inputs\r\n" +
                                      "\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\u25B2\u25BC\r\n");
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            approximatingFunctionList.SelectedIndex = 0;
            numberOfNodesUpDown.Value = 2;
            UpdateTable();
            UpdatePlotsArea(10, -10, 10, -10);
            outputConsole.Text = "";
        }
    }
}
