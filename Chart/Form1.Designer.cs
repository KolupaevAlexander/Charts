namespace Chart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CleanChart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гиперболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параболаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кубическаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.косинусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окружностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.гиперболаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leftBorder = new System.Windows.Forms.TextBox();
            this.rightBorder = new System.Windows.Forms.TextBox();
            this.coeffA = new System.Windows.Forms.TextBox();
            this.coeffB = new System.Windows.Forms.TextBox();
            this.coeffC = new System.Windows.Forms.TextBox();
            this.coeffR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.coefficientA = new System.Windows.Forms.Label();
            this.coefficientB = new System.Windows.Forms.Label();
            this.coefficientC = new System.Windows.Forms.Label();
            this.coefficientR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Graf
            // 
            chartArea5.Name = "ChartArea1";
            this.Graf.ChartAreas.Add(chartArea5);
            this.Graf.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.Graf.Legends.Add(legend5);
            this.Graf.Location = new System.Drawing.Point(0, 0);
            this.Graf.Name = "Graf";
            this.Graf.Size = new System.Drawing.Size(800, 611);
            this.Graf.TabIndex = 0;
            this.Graf.Text = "chart1";
            // 
            // CleanChart
            // 
            this.CleanChart.Location = new System.Drawing.Point(52, 317);
            this.CleanChart.Name = "CleanChart";
            this.CleanChart.Size = new System.Drawing.Size(77, 23);
            this.CleanChart.TabIndex = 1;
            this.CleanChart.Text = "Clean";
            this.CleanChart.UseVisualStyleBackColor = true;
            this.CleanChart.Click += new System.EventHandler(this.start_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 26);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гиперболаToolStripMenuItem,
            this.параболаToolStripMenuItem,
            this.кубическаяToolStripMenuItem,
            this.синусToolStripMenuItem,
            this.косинусToolStripMenuItem,
            this.окружностьToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // гиперболаToolStripMenuItem
            // 
            this.гиперболаToolStripMenuItem.Name = "гиперболаToolStripMenuItem";
            this.гиперболаToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            // 
            // параболаToolStripMenuItem
            // 
            this.параболаToolStripMenuItem.Name = "параболаToolStripMenuItem";
            this.параболаToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.параболаToolStripMenuItem.Text = "Парабола";
            // 
            // кубическаяToolStripMenuItem
            // 
            this.кубическаяToolStripMenuItem.Name = "кубическаяToolStripMenuItem";
            this.кубическаяToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.кубическаяToolStripMenuItem.Text = "Кубическая";
            // 
            // синусToolStripMenuItem
            // 
            this.синусToolStripMenuItem.Name = "синусToolStripMenuItem";
            this.синусToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.синусToolStripMenuItem.Text = "Синус";
            // 
            // косинусToolStripMenuItem
            // 
            this.косинусToolStripMenuItem.Name = "косинусToolStripMenuItem";
            this.косинусToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.косинусToolStripMenuItem.Text = "Косинус";
            // 
            // окружностьToolStripMenuItem
            // 
            this.окружностьToolStripMenuItem.Name = "окружностьToolStripMenuItem";
            this.окружностьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.окружностьToolStripMenuItem.Text = "Окружность";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гиперболаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // гиперболаToolStripMenuItem1
            // 
            this.гиперболаToolStripMenuItem1.Name = "гиперболаToolStripMenuItem1";
            this.гиперболаToolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // leftBorder
            // 
            this.leftBorder.Location = new System.Drawing.Point(29, 118);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(100, 20);
            this.leftBorder.TabIndex = 3;
            this.leftBorder.TextChanged += new System.EventHandler(this.leftBorder_TextChanged);
            // 
            // rightBorder
            // 
            this.rightBorder.Location = new System.Drawing.Point(29, 157);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(100, 20);
            this.rightBorder.TabIndex = 4;
            this.rightBorder.TextChanged += new System.EventHandler(this.rightBorder_TextChanged);
            // 
            // coeffA
            // 
            this.coeffA.Location = new System.Drawing.Point(43, 183);
            this.coeffA.Name = "coeffA";
            this.coeffA.Size = new System.Drawing.Size(86, 20);
            this.coeffA.TabIndex = 5;
            this.coeffA.TextChanged += new System.EventHandler(this.coeffA_TextChanged);
            // 
            // coeffB
            // 
            this.coeffB.Location = new System.Drawing.Point(43, 209);
            this.coeffB.Name = "coeffB";
            this.coeffB.Size = new System.Drawing.Size(86, 20);
            this.coeffB.TabIndex = 6;
            this.coeffB.TextChanged += new System.EventHandler(this.coeffB_TextChanged);
            // 
            // coeffC
            // 
            this.coeffC.Location = new System.Drawing.Point(43, 235);
            this.coeffC.Name = "coeffC";
            this.coeffC.Size = new System.Drawing.Size(86, 20);
            this.coeffC.TabIndex = 7;
            this.coeffC.TextChanged += new System.EventHandler(this.coeffC_TextChanged);
            // 
            // coeffR
            // 
            this.coeffR.Location = new System.Drawing.Point(43, 261);
            this.coeffR.Name = "coeffR";
            this.coeffR.Size = new System.Drawing.Size(86, 20);
            this.coeffR.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Левая граница";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Правая граница";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(52, 288);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(77, 23);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // coefficientA
            // 
            this.coefficientA.AutoSize = true;
            this.coefficientA.Location = new System.Drawing.Point(23, 183);
            this.coefficientA.Name = "coefficientA";
            this.coefficientA.Size = new System.Drawing.Size(14, 13);
            this.coefficientA.TabIndex = 12;
            this.coefficientA.Text = "A";
            // 
            // coefficientB
            // 
            this.coefficientB.AutoSize = true;
            this.coefficientB.Location = new System.Drawing.Point(23, 209);
            this.coefficientB.Name = "coefficientB";
            this.coefficientB.Size = new System.Drawing.Size(14, 13);
            this.coefficientB.TabIndex = 13;
            this.coefficientB.Text = "B";
            // 
            // coefficientC
            // 
            this.coefficientC.AutoSize = true;
            this.coefficientC.Location = new System.Drawing.Point(23, 235);
            this.coefficientC.Name = "coefficientC";
            this.coefficientC.Size = new System.Drawing.Size(14, 13);
            this.coefficientC.TabIndex = 14;
            this.coefficientC.Text = "C";
            // 
            // coefficientR
            // 
            this.coefficientR.AutoSize = true;
            this.coefficientR.Location = new System.Drawing.Point(23, 261);
            this.coefficientR.Name = "coefficientR";
            this.coefficientR.Size = new System.Drawing.Size(15, 13);
            this.coefficientR.TabIndex = 15;
            this.coefficientR.Text = "R";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chartName);
            this.panel1.Controls.Add(this.coeffR);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.coefficientA);
            this.panel1.Controls.Add(this.CleanChart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.leftBorder);
            this.panel1.Controls.Add(this.coefficientB);
            this.panel1.Controls.Add(this.coefficientC);
            this.panel1.Controls.Add(this.rightBorder);
            this.panel1.Controls.Add(this.coefficientR);
            this.panel1.Controls.Add(this.coeffC);
            this.panel1.Controls.Add(this.coeffB);
            this.panel1.Controls.Add(this.coeffA);
            this.panel1.Location = new System.Drawing.Point(635, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 378);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Вид";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Косинус",
            "Синус",
            "Парабола",
            "Гипербола",
            "Кубическая ф-ция",
            "Окружность"});
            this.comboBox1.Location = new System.Drawing.Point(29, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название";
            // 
            // chartName
            // 
            this.chartName.Location = new System.Drawing.Point(29, 41);
            this.chartName.Name = "chartName";
            this.chartName.Size = new System.Drawing.Size(100, 20);
            this.chartName.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Graf);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graf;
        private System.Windows.Forms.Button CleanChart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гиперболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параболаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кубическаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem косинусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окружностьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem гиперболаToolStripMenuItem1;
        private System.Windows.Forms.TextBox leftBorder;
        private System.Windows.Forms.TextBox rightBorder;
        private System.Windows.Forms.TextBox coeffA;
        private System.Windows.Forms.TextBox coeffB;
        private System.Windows.Forms.TextBox coeffC;
        private System.Windows.Forms.TextBox coeffR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label coefficientA;
        private System.Windows.Forms.Label coefficientB;
        private System.Windows.Forms.Label coefficientC;
        private System.Windows.Forms.Label coefficientR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chartName;
    }
}

