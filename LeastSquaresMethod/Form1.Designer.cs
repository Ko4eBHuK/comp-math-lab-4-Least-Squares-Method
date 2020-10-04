namespace LeastSquaresMethod
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.approximatingFunctionList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfNodesUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nodesData = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleBox = new System.Windows.Forms.GroupBox();
            this.outputConsole = new System.Windows.Forms.TextBox();
            this.graphsBox = new System.Windows.Forms.GroupBox();
            this.plotsArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.controlsBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNodesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesData)).BeginInit();
            this.consoleBox.SuspendLayout();
            this.graphsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotsArea)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsBox
            // 
            this.controlsBox.BackColor = System.Drawing.SystemColors.Control;
            this.controlsBox.Controls.Add(this.tableLayoutPanel1);
            this.controlsBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlsBox.Location = new System.Drawing.Point(2, 0);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(460, 236);
            this.controlsBox.TabIndex = 0;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.approximatingFunctionList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nodesData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberOfNodesUpDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // approximatingFunctionList
            // 
            this.approximatingFunctionList.AutoCompleteCustomSource.AddRange(new string[] {
            "f=a*x+b",
            "f=a*x^b",
            "f=a*e^(b*x)",
            "f=a*ln(x)+b",
            "f=a*x^2+b*x+c"});
            this.approximatingFunctionList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approximatingFunctionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approximatingFunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.approximatingFunctionList.Items.AddRange(new object[] {
            "y=a*x+b",
            "y=a*x^b",
            "y=a*e^(b*x)",
            "y=a*ln(x)+b",
            "y=a*x^2+b*x+c"});
            this.approximatingFunctionList.Location = new System.Drawing.Point(60, 40);
            this.approximatingFunctionList.Margin = new System.Windows.Forms.Padding(60, 4, 3, 3);
            this.approximatingFunctionList.Name = "approximatingFunctionList";
            this.approximatingFunctionList.Size = new System.Drawing.Size(111, 28);
            this.approximatingFunctionList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(60, 10, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of nodes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfNodesUpDown
            // 
            this.numberOfNodesUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberOfNodesUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfNodesUpDown.Location = new System.Drawing.Point(75, 113);
            this.numberOfNodesUpDown.Margin = new System.Windows.Forms.Padding(75, 5, 3, 3);
            this.numberOfNodesUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfNodesUpDown.Name = "numberOfNodesUpDown";
            this.numberOfNodesUpDown.Size = new System.Drawing.Size(73, 26);
            this.numberOfNodesUpDown.TabIndex = 5;
            this.numberOfNodesUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfNodesUpDown.ValueChanged += new System.EventHandler(this.NumberOfNodesUpDown_ValueChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Location = new System.Drawing.Point(60, 147);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(111, 30);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(60, 183);
            this.resetButton.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 33);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 12, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecting an approximating function";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nodesData
            // 
            this.nodesData.AllowUserToAddRows = false;
            this.nodesData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nodesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.nodesData.Location = new System.Drawing.Point(227, 12);
            this.nodesData.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.nodesData.Name = "nodesData";
            this.tableLayoutPanel1.SetRowSpan(this.nodesData, 6);
            this.nodesData.Size = new System.Drawing.Size(218, 201);
            this.nodesData.TabIndex = 8;
            this.nodesData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.NodesData_DataError);
            // 
            // X
            // 
            this.X.Frozen = true;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 75;
            this.X.Name = "X";
            this.X.Width = 75;
            // 
            // Y
            // 
            this.Y.Frozen = true;
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 75;
            this.Y.Name = "Y";
            this.Y.Width = 75;
            // 
            // consoleBox
            // 
            this.consoleBox.Controls.Add(this.outputConsole);
            this.consoleBox.Location = new System.Drawing.Point(2, 238);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(460, 261);
            this.consoleBox.TabIndex = 1;
            this.consoleBox.TabStop = false;
            this.consoleBox.Text = "Console";
            // 
            // outputConsole
            // 
            this.outputConsole.BackColor = System.Drawing.SystemColors.ControlText;
            this.outputConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputConsole.ForeColor = System.Drawing.SystemColors.Menu;
            this.outputConsole.Location = new System.Drawing.Point(6, 19);
            this.outputConsole.Multiline = true;
            this.outputConsole.Name = "outputConsole";
            this.outputConsole.ReadOnly = true;
            this.outputConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputConsole.Size = new System.Drawing.Size(448, 236);
            this.outputConsole.TabIndex = 0;
            // 
            // graphsBox
            // 
            this.graphsBox.Controls.Add(this.plotsArea);
            this.graphsBox.Location = new System.Drawing.Point(468, 0);
            this.graphsBox.Name = "graphsBox";
            this.graphsBox.Size = new System.Drawing.Size(594, 499);
            this.graphsBox.TabIndex = 3;
            this.graphsBox.TabStop = false;
            this.graphsBox.Text = "Plots";
            // 
            // plotsArea
            // 
            this.plotsArea.BackColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.plotsArea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plotsArea.Legends.Add(legend1);
            this.plotsArea.Location = new System.Drawing.Point(6, 18);
            this.plotsArea.Name = "plotsArea";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.plotsArea.Series.Add(series1);
            this.plotsArea.Size = new System.Drawing.Size(582, 475);
            this.plotsArea.TabIndex = 0;
            this.plotsArea.Text = "Plots";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 501);
            this.Controls.Add(this.graphsBox);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.controlsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Least Squares Method";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlsBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNodesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesData)).EndInit();
            this.consoleBox.ResumeLayout(false);
            this.consoleBox.PerformLayout();
            this.graphsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotsArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.GroupBox consoleBox;
        private System.Windows.Forms.GroupBox graphsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox approximatingFunctionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfNodesUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox outputConsole;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotsArea;
        private System.Windows.Forms.DataGridView nodesData;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

