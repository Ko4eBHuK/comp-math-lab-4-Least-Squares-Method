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
        public int NodesCount { get; set; }
        private double[] DeviationSums = new double[0];
        private double[,] DeterminantCells = new double [0,0];
        private int ApproximatinFunctionIndex;

        public LeastSquaresMethodRealisation(int approximatinFunctionIndex, double[,] nodesTable, int nodesCount)
        {
            NodesTable = nodesTable;
            NodesCount = nodesCount;
            ApproximatinFunctionIndex = approximatinFunctionIndex;
            if (ApproximatinFunctionIndex == 4)
            {
                DeterminantCells = new double[3,4];
            }
            else
            {
                DeterminantCells = new double[2,3];
            }
        }

        private double GetDeterminant(int determinantNumber)
        {
            double determinant = 0;

            if(ApproximatinFunctionIndex == 4)
            {
                determinant = DeterminantCells[0, 0] * DeterminantCells[1, 1] * DeterminantCells[2, 2] +
                              DeterminantCells[0, 2] * DeterminantCells[1, 0] * DeterminantCells[2, 1] +
                              DeterminantCells[0, 1] * DeterminantCells[1, 2] * DeterminantCells[2, 0] -
                              DeterminantCells[0, 0] * DeterminantCells[1, 1] * DeterminantCells[2, 0] -
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
                if (DeviationSums.Length == 7)
                {
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
                }
                else
                {
                    DeterminantCells[0, 0] += Math.Pow(NodesTable[0, i], 2);
                    DeterminantCells[0, 1] += NodesTable[0, i];
                    DeterminantCells[1, 0] += NodesTable[0, i];
                    DeterminantCells[1, 1]++;
                    DeterminantCells[0, 2] += NodesTable[0, i] * NodesTable[1, i];
                    DeterminantCells[1, 2] += NodesTable[1, i];
                }
            }
        }

    }
}
