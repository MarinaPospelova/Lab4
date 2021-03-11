namespace Cur
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.edRub = new System.Windows.Forms.NumericUpDown();
            this.edDoll = new System.Windows.Forms.NumericUpDown();
            this.edSell = new System.Windows.Forms.NumericUpDown();
            this.btSell = new System.Windows.Forms.Button();
            this.edBuy = new System.Windows.Forms.NumericUpDown();
            this.btBuy = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Rub = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Rub);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edRub);
            this.panel1.Controls.Add(this.edDoll);
            this.panel1.Controls.Add(this.edSell);
            this.panel1.Controls.Add(this.btSell);
            this.panel1.Controls.Add(this.edBuy);
            this.panel1.Controls.Add(this.btBuy);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 126);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Доллары";
            // 
            // edRub
            // 
            this.edRub.Location = new System.Drawing.Point(705, 80);
            this.edRub.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edRub.Name = "edRub";
            this.edRub.Size = new System.Drawing.Size(120, 26);
            this.edRub.TabIndex = 10;
            this.edRub.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // edDoll
            // 
            this.edDoll.Location = new System.Drawing.Point(705, 22);
            this.edDoll.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edDoll.Name = "edDoll";
            this.edDoll.Size = new System.Drawing.Size(120, 26);
            this.edDoll.TabIndex = 9;
            this.edDoll.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // edSell
            // 
            this.edSell.Location = new System.Drawing.Point(431, 80);
            this.edSell.Name = "edSell";
            this.edSell.Size = new System.Drawing.Size(120, 26);
            this.edSell.TabIndex = 8;
            this.edSell.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btSell
            // 
            this.btSell.Location = new System.Drawing.Point(338, 66);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(87, 52);
            this.btSell.TabIndex = 7;
            this.btSell.Text = "Продать";
            this.btSell.UseVisualStyleBackColor = true;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // edBuy
            // 
            this.edBuy.Location = new System.Drawing.Point(431, 22);
            this.edBuy.Name = "edBuy";
            this.edBuy.Size = new System.Drawing.Size(120, 26);
            this.edBuy.TabIndex = 6;
            this.edBuy.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(338, 12);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(87, 45);
            this.btBuy.TabIndex = 5;
            this.btBuy.Text = "Купить";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(37, 65);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(112, 35);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Do it!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(159, 25);
            this.edRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(144, 26);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            7433,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс";
            // 
            // chart1
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 126);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "F2";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1076, 566);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Rub
            // 
            this.Rub.AutoSize = true;
            this.Rub.Location = new System.Drawing.Point(629, 82);
            this.Rub.Name = "Rub";
            this.Rub.Size = new System.Drawing.Size(54, 20);
            this.Rub.TabIndex = 12;
            this.Rub.Text = "Рубли";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(888, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 692);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown edSell;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.NumericUpDown edBuy;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edRub;
        private System.Windows.Forms.NumericUpDown edDoll;
        private System.Windows.Forms.Label Rub;
        private System.Windows.Forms.TextBox textBox1;
    }
}

