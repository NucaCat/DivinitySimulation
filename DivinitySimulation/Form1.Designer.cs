namespace DivinitySimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TopAndLeastDamage1 = new System.Windows.Forms.Button();
            this.LeastCrits1 = new System.Windows.Forms.Button();
            this.MostCrits1 = new System.Windows.Forms.Button();
            this.LeastDamage1 = new System.Windows.Forms.Button();
            this.MostDamage1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1100, 600);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 675);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1240, 55);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 657);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Урон за пару ударов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TopAndLeastDamage1
            // 
            this.TopAndLeastDamage1.Enabled = false;
            this.TopAndLeastDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopAndLeastDamage1.Location = new System.Drawing.Point(1138, 398);
            this.TopAndLeastDamage1.Name = "TopAndLeastDamage1";
            this.TopAndLeastDamage1.Size = new System.Drawing.Size(114, 85);
            this.TopAndLeastDamage1.TabIndex = 5;
            this.TopAndLeastDamage1.Text = "Top And Least Damage";
            this.TopAndLeastDamage1.UseVisualStyleBackColor = true;
            this.TopAndLeastDamage1.Click += new System.EventHandler(this.TopAndLeastDamage1_Click);
            // 
            // LeastCrits1
            // 
            this.LeastCrits1.Enabled = false;
            this.LeastCrits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeastCrits1.Location = new System.Drawing.Point(1138, 307);
            this.LeastCrits1.Name = "LeastCrits1";
            this.LeastCrits1.Size = new System.Drawing.Size(114, 85);
            this.LeastCrits1.TabIndex = 4;
            this.LeastCrits1.Text = "Top 10 Least Crits";
            this.LeastCrits1.UseVisualStyleBackColor = true;
            this.LeastCrits1.Click += new System.EventHandler(this.LeastCrits1_Click);
            // 
            // MostCrits1
            // 
            this.MostCrits1.Enabled = false;
            this.MostCrits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MostCrits1.Location = new System.Drawing.Point(1138, 216);
            this.MostCrits1.Name = "MostCrits1";
            this.MostCrits1.Size = new System.Drawing.Size(114, 85);
            this.MostCrits1.TabIndex = 3;
            this.MostCrits1.Text = "Top 10 Most Crits";
            this.MostCrits1.UseVisualStyleBackColor = true;
            this.MostCrits1.Click += new System.EventHandler(this.MostCrits1_Click);
            // 
            // LeastDamage1
            // 
            this.LeastDamage1.Enabled = false;
            this.LeastDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeastDamage1.Location = new System.Drawing.Point(1138, 125);
            this.LeastDamage1.Name = "LeastDamage1";
            this.LeastDamage1.Size = new System.Drawing.Size(114, 85);
            this.LeastDamage1.TabIndex = 2;
            this.LeastDamage1.Text = "Top 10 Least Damage";
            this.LeastDamage1.UseVisualStyleBackColor = true;
            this.LeastDamage1.Click += new System.EventHandler(this.LeastDamage1_Click);
            // 
            // MostDamage1
            // 
            this.MostDamage1.Enabled = false;
            this.MostDamage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MostDamage1.Location = new System.Drawing.Point(1138, 34);
            this.MostDamage1.Name = "MostDamage1";
            this.MostDamage1.Size = new System.Drawing.Size(114, 85);
            this.MostDamage1.TabIndex = 1;
            this.MostDamage1.Text = "Top 10 Most Damage";
            this.MostDamage1.UseVisualStyleBackColor = true;
            this.MostDamage1.Click += new System.EventHandler(this.MostDamage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Средний урон";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(1100, 600);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 739);
            this.Controls.Add(this.TopAndLeastDamage1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LeastCrits1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MostCrits1);
            this.Controls.Add(this.MostDamage1);
            this.Controls.Add(this.LeastDamage1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button TopAndLeastDamage1;
        private System.Windows.Forms.Button LeastCrits1;
        private System.Windows.Forms.Button MostCrits1;
        private System.Windows.Forms.Button LeastDamage1;
        private System.Windows.Forms.Button MostDamage1;
    }
}

