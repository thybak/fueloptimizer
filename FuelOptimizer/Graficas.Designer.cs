namespace FuelOptimizer
{
    partial class Graficas
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtCromosoma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // chResultados
            // 
            this.chResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chResultados.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chResultados.Legends.Add(legend1);
            this.chResultados.Location = new System.Drawing.Point(25, 23);
            this.chResultados.Name = "chResultados";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Fitness Máximo";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Media Fitness";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Consumo";
            this.chResultados.Series.Add(series1);
            this.chResultados.Series.Add(series2);
            this.chResultados.Series.Add(series3);
            this.chResultados.Size = new System.Drawing.Size(1166, 552);
            this.chResultados.TabIndex = 0;
            this.chResultados.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tras las generaciones parametrizadas el resultado es:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(66, 641);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(86, 13);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Media fitness {0}";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(66, 667);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(93, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Máximo fitness {0}";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(66, 693);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(277, 13);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Consumo de combustible en el mejor cromosoma {0} litros";
            // 
            // txtCromosoma
            // 
            this.txtCromosoma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCromosoma.Location = new System.Drawing.Point(465, 616);
            this.txtCromosoma.Multiline = true;
            this.txtCromosoma.Name = "txtCromosoma";
            this.txtCromosoma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCromosoma.Size = new System.Drawing.Size(401, 126);
            this.txtCromosoma.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genes correspondientes al mejor cromosoma";
            // 
            // Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 764);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCromosoma);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chResultados);
            this.Name = "Graficas";
            this.Text = "Resultado de la aplicación del algoritmo";
            ((System.ComponentModel.ISupportInitialize)(this.chResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtCromosoma;
        private System.Windows.Forms.Label label2;
    }
}