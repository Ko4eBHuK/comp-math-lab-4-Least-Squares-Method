using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquaresMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            approximatingFunctionList.SelectedIndex = 0;
            TableRemake();
        }

        private void numberOfNodesUpDown_ValueChanged(object sender, EventArgs e)
        {
            TableRemake();
        }

        private void TableRemake()
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
    }
}
