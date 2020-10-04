using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastSquaresMethod
{
    class LeastSquaresMethodRealisation
    {
        public double[,] NodesTable { get; set; }
        public double[] ResultСoefficients { get; set; }
        public double MeasureOfDeviation { get; set; }
        public double CorrelationCoefficient { get; set; }
        public double RootMeanSquareDeviation { get; set; }
        public int NodesCount { get; set; }
        public int ApproximatinFunctionIndex { get; set; }
        public bool SolutionExistence { get; set; }
        private double[,] DeterminantCells = new double[0, 0];
        public double [] DeviationSums { get; set; }
        
        public int NodeWithMaximumDeviationIndex { get; set; }
        public bool MaximumNodeDeviationExistence { get; set; }

        public LeastSquaresMethodRealisation(int approximatinFunctionIndex, double[,] nodesTable, int nodesCount)
        {
            NodesTable = nodesTable;
            NodesCount = nodesCount;
            ApproximatinFunctionIndex = approximatinFunctionIndex;
            DeterminantCells = new double[3, 4];

            LeastSquaresMethod();
        }

        public void LeastSquaresMethod()
        {
            CalculateDeviationSums();

            SolutionExistence = GetDeterminant() != 0;

            if (SolutionExistence)
            {
                //вычисление коэффициентов
                if (ApproximatinFunctionIndex == 4)
                {
                    ResultСoefficients = new double[3];
                    
                    ResultСoefficients[0] = (DeterminantCells[0, 3] * DeterminantCells[1, 1] * DeterminantCells[2, 2] +
                              DeterminantCells[0, 2] * DeterminantCells[1, 3] * DeterminantCells[2, 1] +
                              DeterminantCells[0, 1] * DeterminantCells[1, 2] * DeterminantCells[2, 3] -
                              DeterminantCells[0, 2] * DeterminantCells[1, 1] * DeterminantCells[2, 3] -
                              DeterminantCells[0, 3] * DeterminantCells[1, 2] * DeterminantCells[2, 1] -
                              DeterminantCells[0, 1] * DeterminantCells[1, 3] * DeterminantCells[2, 2]) / GetDeterminant();

                    ResultСoefficients[1] = (DeterminantCells[0, 0] * DeterminantCells[1, 3] * DeterminantCells[2, 2] +
                              DeterminantCells[0, 2] * DeterminantCells[1, 0] * DeterminantCells[2, 3] +
                              DeterminantCells[0, 3] * DeterminantCells[1, 2] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 2] * DeterminantCells[1, 3] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 0] * DeterminantCells[1, 2] * DeterminantCells[2, 3] -
                              DeterminantCells[0, 3] * DeterminantCells[1, 0] * DeterminantCells[2, 2]) / GetDeterminant();

                    ResultСoefficients[2] = (DeterminantCells[0, 0] * DeterminantCells[1, 1] * DeterminantCells[2, 3] +
                              DeterminantCells[0, 3] * DeterminantCells[1, 0] * DeterminantCells[2, 1] +
                              DeterminantCells[0, 1] * DeterminantCells[1, 3] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 3] * DeterminantCells[1, 1] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 0] * DeterminantCells[1, 3] * DeterminantCells[2, 1] -
                              DeterminantCells[0, 1] * DeterminantCells[1, 0] * DeterminantCells[2, 3]) / GetDeterminant();
                }
                else
                {
                    ResultСoefficients = new double[2];

                    ResultСoefficients[0] = (DeterminantCells[0, 2] * DeterminantCells[1, 1] -
                                             DeterminantCells[0, 1] * DeterminantCells[1, 2]) / GetDeterminant();

                    ResultСoefficients[1] = (DeterminantCells[0, 0] * DeterminantCells[1, 2] -
                                             DeterminantCells[0, 2] * DeterminantCells[1, 0]) / GetDeterminant();
                }

                //преобразование коэффициентов, если требуется
                if (ApproximatinFunctionIndex == 1 | ApproximatinFunctionIndex == 2)
                {
                    ResultСoefficients[1] = Math.Pow(Math.E, ResultСoefficients[1]);
                }

                //вычисление суммы квадратов отклонений S
                MeasureOfDeviation = 0;
                DeviationSums = new double[NodesCount];
                for(int i = 0; i < NodesCount; i++)
                {
                    DeviationSums[i] = Math.Pow(GetFiValueInPoint(NodesTable[0, i]) - NodesTable[1, i], 2);
                    MeasureOfDeviation += DeviationSums[i];
                }

                //вычисление коэффициента корелляции
                double averageX = 0, averageY = 0;
                for(int i = 0; i < NodesCount; i++)
                {
                    averageX += NodesTable[0, i];
                    averageY += NodesTable[1, i];
                }
                averageX /= NodesCount;
                averageY /= NodesCount;
                double sum1 = 0, sum2 = 0, sum3 = 0;
                for(int i = 0; i < NodesCount; i++)
                {
                    sum1 += (NodesTable[0, i] - averageX) * (NodesTable[1, i] - averageY);
                    sum2 += Math.Pow(NodesTable[0, i] - averageX, 2);
                    sum3 += Math.Pow(NodesTable[1, i] - averageY, 2);
                }
                CorrelationCoefficient = sum1 / Math.Pow(sum2 * sum3, 0.5);

                //вычисление среднеквадратичного отклонения
                RootMeanSquareDeviation = Math.Pow(MeasureOfDeviation / NodesCount, 0.5);

                //существование точки с наибольшим отклонением
                int m = 1;
                MaximumNodeDeviationExistence = false;
                while (!MaximumNodeDeviationExistence & m < NodesCount)
                {
                    MaximumNodeDeviationExistence = DeviationSums[0] != DeviationSums[m];
                    m++;
                }

                //вычисление точки с наибольшим отклоеннием
                if (MaximumNodeDeviationExistence)
                {
                    NodeWithMaximumDeviationIndex = 0;
                    for (int i = 1; i < NodesCount; i++)
                    {
                        if (DeviationSums[i] > DeviationSums[NodeWithMaximumDeviationIndex]) NodeWithMaximumDeviationIndex = i;
                    }
                }

            }
        }

        private double GetDeterminant()
        {
            double determinant = 0;

            if(ApproximatinFunctionIndex == 4)
            {
                determinant = DeterminantCells[0, 0] * DeterminantCells[1, 1] * DeterminantCells[2, 2] +
                              DeterminantCells[0, 2] * DeterminantCells[1, 0] * DeterminantCells[2, 1] +
                              DeterminantCells[0, 1] * DeterminantCells[1, 2] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 2] * DeterminantCells[1, 1] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 0] * DeterminantCells[1, 2] * DeterminantCells[2, 1] -
                              DeterminantCells[0, 1] * DeterminantCells[1, 0] * DeterminantCells[2, 2];
            }
            else
            {
                determinant = DeterminantCells[0, 0] * DeterminantCells[1, 1] -
                              DeterminantCells[0, 1] * DeterminantCells[1, 0];
            }

            return determinant;
        }

        private void CalculateDeviationSums()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DeterminantCells[i,j] = 0;
                }
            }

            for (int i = 0; i < NodesCount; i++)
            {
                switch (ApproximatinFunctionIndex)
                {
                    case 0:
                        DeterminantCells[0, 0] += Math.Pow(NodesTable[0, i], 2);
                        DeterminantCells[0, 1] += NodesTable[0, i];
                        DeterminantCells[1, 0] += NodesTable[0, i];
                        DeterminantCells[1, 1]++;
                        DeterminantCells[0, 2] += NodesTable[0, i] * NodesTable[1, i];
                        DeterminantCells[1, 2] += NodesTable[1, i];
                        break;
                    case 1:
                        DeterminantCells[0, 0] += Math.Pow(Math.Log(NodesTable[0, i]), 2);
                        DeterminantCells[0, 1] += Math.Log(NodesTable[0, i]);
                        DeterminantCells[1, 0] += Math.Log(NodesTable[0, i]);
                        DeterminantCells[1, 1]++;
                        DeterminantCells[0, 2] += Math.Log(NodesTable[0, i]) * Math.Log(NodesTable[1, i]);
                        DeterminantCells[1, 2] += Math.Log(NodesTable[1, i]);
                        break;
                    case 2:
                        DeterminantCells[0, 0] += Math.Pow(NodesTable[0, i], 2);
                        DeterminantCells[0, 1] += NodesTable[0, i];
                        DeterminantCells[1, 0] += NodesTable[0, i];
                        DeterminantCells[1, 1]++;
                        DeterminantCells[0, 2] += NodesTable[0, i] * Math.Log(NodesTable[1, i]);
                        DeterminantCells[1, 2] += Math.Log(NodesTable[1, i]);
                        break;
                    case 3:
                        DeterminantCells[0, 0] += Math.Pow(Math.Log(NodesTable[0, i]), 2);
                        DeterminantCells[0, 1] += Math.Log(NodesTable[0, i]);
                        DeterminantCells[1, 0] += Math.Log(NodesTable[0, i]);
                        DeterminantCells[1, 1]++;
                        DeterminantCells[0, 2] += Math.Log(NodesTable[0, i]) * NodesTable[1, i];
                        DeterminantCells[1, 2] += NodesTable[1, i];
                        break;
                    case 4:
                        DeterminantCells[0, 0] += Math.Pow(NodesTable[0, i], 4);
                        DeterminantCells[0, 1] += Math.Pow(NodesTable[0, i], 3);
                        DeterminantCells[1, 0] += Math.Pow(NodesTable[0, i], 3);
                        DeterminantCells[0, 2] += Math.Pow(NodesTable[0, i], 2);
                        DeterminantCells[1, 1] += Math.Pow(NodesTable[0, i], 2);
                        DeterminantCells[2, 0] += Math.Pow(NodesTable[0, i], 2);
                        DeterminantCells[1, 2] += NodesTable[0, i];
                        DeterminantCells[2, 1] += NodesTable[0, i];
                        DeterminantCells[2, 2]++;
                        DeterminantCells[0, 3] += Math.Pow(NodesTable[0, i], 2) * NodesTable[1, i];
                        DeterminantCells[1, 3] += NodesTable[0, i] * NodesTable[1, i];
                        DeterminantCells[2, 3] += NodesTable[1, i];
                        break;
                }
            }
        }

        private double GetFiValueInPoint(double x)
        {
            double fiValue = 0;

            switch (ApproximatinFunctionIndex)
            {
                case 0:
                    fiValue = ResultСoefficients[0] * x + ResultСoefficients[1];
                    break;
                case 1:
                    fiValue = ResultСoefficients[1] * Math.Pow(x, ResultСoefficients[0]);
                    break;
                case 2:
                    fiValue = ResultСoefficients[1] * Math.Pow(Math.E, ResultСoefficients[0] * x);
                    break;
                case 3:
                    fiValue = ResultСoefficients[0] * Math.Log(x) + ResultСoefficients[1];
                    break;
                case 4:
                    fiValue = ResultСoefficients[0] * Math.Pow(x, 2) + ResultСoefficients[1] * x + ResultСoefficients[2];
                    break;
            }

            return fiValue;
        }

    }
}
