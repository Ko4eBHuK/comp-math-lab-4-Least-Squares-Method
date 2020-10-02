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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.approximatingFunctionList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfNodesUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.GroupBox();
            this.legendBox = new System.Windows.Forms.GroupBox();
            this.graphsBox = new System.Windows.Forms.GroupBox();
            this.nodesData = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNodesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesData)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsBox
            // 
            this.controlsBox.BackColor = System.Drawing.SystemColors.Control;
            this.controlsBox.Controls.Add(this.tableLayoutPanel1);
            this.controlsBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlsBox.Location = new System.Drawing.Point(2, 0);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(460, 360);
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
            this.tableLayoutPanel1.Controls.Add(this.numberOfNodesUpDown, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.nodesData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 342);
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
            this.approximatingFunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.approximatingFunctionList.Items.AddRange(new object[] {
            "f=a*x+b",
            "f=a*x^b",
            "f=a*e^(b*x)",
            "f=a*ln(x)+b",
            "f=a*x^2+b*x+c"});
            this.approximatingFunctionList.Location = new System.Drawing.Point(60, 50);
            this.approximatingFunctionList.Margin = new System.Windows.Forms.Padding(60, 8, 3, 3);
            this.approximatingFunctionList.Name = "approximatingFunctionList";
            this.approximatingFunctionList.Size = new System.Drawing.Size(111, 28);
            this.approximatingFunctionList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(28, 6, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecting an approximating function";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(60, 12, 3, 3);
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
            this.numberOfNodesUpDown.Location = new System.Drawing.Point(75, 136);
            this.numberOfNodesUpDown.Margin = new System.Windows.Forms.Padding(75, 10, 3, 3);
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
            this.numberOfNodesUpDown.ValueChanged += new System.EventHandler(this.numberOfNodesUpDown_ValueChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Location = new System.Drawing.Point(60, 186);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(60, 18, 3, 3);
            this.calculateButton.Name = "calculateButton";
            this.tableLayoutPanel1.SetRowSpan(this.calculateButton, 2);
            this.calculateButton.Size = new System.Drawing.Size(111, 58);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(60, 270);
            this.resetButton.Margin = new System.Windows.Forms.Padding(60, 18, 3, 3);
            this.resetButton.Name = "resetButton";
            this.tableLayoutPanel1.SetRowSpan(this.resetButton, 2);
            this.resetButton.Size = new System.Drawing.Size(111, 58);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(2, 360);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(460, 139);
            this.consoleBox.TabIndex = 1;
            this.consoleBox.TabStop = false;
            this.consoleBox.Text = "Console";
            // 
            // legendBox
            // 
            this.legendBox.Location = new System.Drawing.Point(468, 0);
            this.legendBox.Name = "legendBox";
            this.legendBox.Size = new System.Drawing.Size(594, 90);
            this.legendBox.TabIndex = 2;
            this.legendBox.TabStop = false;
            this.legendBox.Text = "Legend";
            // 
            // graphsBox
            // 
            this.graphsBox.Location = new System.Drawing.Point(468, 90);
            this.graphsBox.Name = "graphsBox";
            this.graphsBox.Size = new System.Drawing.Size(594, 409);
            this.graphsBox.TabIndex = 3;
            this.graphsBox.TabStop = false;
            this.graphsBox.Text = "Graphs";
            // 
            // nodesData
            // 
            this.nodesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.nodesData.Location = new System.Drawing.Point(229, 10);
            this.nodesData.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.nodesData.Name = "nodesData";
            this.tableLayoutPanel1.SetRowSpan(this.nodesData, 8);
            this.nodesData.Size = new System.Drawing.Size(214, 320);
            this.nodesData.TabIndex = 8;
            // 
            // X
            // 
            this.X.Frozen = true;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 75;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 75;
            // 
            // Y
            // 
            this.Y.Frozen = true;
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 75;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 501);
            this.Controls.Add(this.graphsBox);
            this.Controls.Add(this.legendBox);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.GroupBox consoleBox;
        private System.Windows.Forms.GroupBox legendBox;
        private System.Windows.Forms.GroupBox graphsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox approximatingFunctionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfNodesUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView nodesData;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

