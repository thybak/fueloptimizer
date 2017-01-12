using FuelOptimizer.Clases.COR;

namespace FuelOptimizer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.gbCircuito = new System.Windows.Forms.GroupBox();
            this.txtLongitudTramoActualizacion = new System.Windows.Forms.TextBox();
            this.lblTramoActualizacion = new System.Windows.Forms.Label();
            this.dgvCircuito = new System.Windows.Forms.DataGridView();
            this.tramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCoche = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcha4Max = new System.Windows.Forms.TextBox();
            this.txtMarcha4Min = new System.Windows.Forms.TextBox();
            this.txtMarcha3Max = new System.Windows.Forms.TextBox();
            this.txtMarcha3Min = new System.Windows.Forms.TextBox();
            this.txtMarcha5Max = new System.Windows.Forms.TextBox();
            this.txtMarcha5Min = new System.Windows.Forms.TextBox();
            this.txtMarcha2Max = new System.Windows.Forms.TextBox();
            this.txtMarcha2Min = new System.Windows.Forms.TextBox();
            this.txtMarcha1Max = new System.Windows.Forms.TextBox();
            this.txtMarcha1Min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGenetico = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumGeneraciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnLanzamiento = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblGeneracion = new System.Windows.Forms.ToolStripStatusLabel();
            this.bwCalculo = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCircuito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCircuito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).BeginInit();
            this.gbCoche.SuspendLayout();
            this.gbGenetico.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCircuito
            // 
            this.gbCircuito.Controls.Add(this.txtLongitudTramoActualizacion);
            this.gbCircuito.Controls.Add(this.lblTramoActualizacion);
            this.gbCircuito.Controls.Add(this.dgvCircuito);
            this.gbCircuito.Location = new System.Drawing.Point(12, 12);
            this.gbCircuito.Name = "gbCircuito";
            this.gbCircuito.Size = new System.Drawing.Size(671, 168);
            this.gbCircuito.TabIndex = 0;
            this.gbCircuito.TabStop = false;
            this.gbCircuito.Text = "Características del circuito (medidas en metros)";
            // 
            // txtLongitudTramoActualizacion
            // 
            this.txtLongitudTramoActualizacion.Location = new System.Drawing.Point(465, 80);
            this.txtLongitudTramoActualizacion.Name = "txtLongitudTramoActualizacion";
            this.txtLongitudTramoActualizacion.Size = new System.Drawing.Size(100, 20);
            this.txtLongitudTramoActualizacion.TabIndex = 3;
            this.txtLongitudTramoActualizacion.Text = "100";
            this.txtLongitudTramoActualizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTramoActualizacion
            // 
            this.lblTramoActualizacion.AutoSize = true;
            this.lblTramoActualizacion.Location = new System.Drawing.Point(427, 50);
            this.lblTramoActualizacion.Name = "lblTramoActualizacion";
            this.lblTramoActualizacion.Size = new System.Drawing.Size(174, 13);
            this.lblTramoActualizacion.TabIndex = 2;
            this.lblTramoActualizacion.Text = "Longitud del tramo de actualización";
            // 
            // dgvCircuito
            // 
            this.dgvCircuito.AutoGenerateColumns = false;
            this.dgvCircuito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCircuito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCircuito.DataSource = this.tramoBindingSource;
            this.dgvCircuito.Location = new System.Drawing.Point(6, 19);
            this.dgvCircuito.Name = "dgvCircuito";
            this.dgvCircuito.Size = new System.Drawing.Size(349, 143);
            this.dgvCircuito.TabIndex = 1;
            // 
            // tramoBindingSource
            // 
            this.tramoBindingSource.DataSource = typeof(FuelOptimizer.Clases.COR.Tramo);
            // 
            // gbCoche
            // 
            this.gbCoche.Controls.Add(this.label8);
            this.gbCoche.Controls.Add(this.txtMarcha4Max);
            this.gbCoche.Controls.Add(this.txtMarcha4Min);
            this.gbCoche.Controls.Add(this.txtMarcha3Max);
            this.gbCoche.Controls.Add(this.txtMarcha3Min);
            this.gbCoche.Controls.Add(this.txtMarcha5Max);
            this.gbCoche.Controls.Add(this.txtMarcha5Min);
            this.gbCoche.Controls.Add(this.txtMarcha2Max);
            this.gbCoche.Controls.Add(this.txtMarcha2Min);
            this.gbCoche.Controls.Add(this.txtMarcha1Max);
            this.gbCoche.Controls.Add(this.txtMarcha1Min);
            this.gbCoche.Controls.Add(this.label5);
            this.gbCoche.Controls.Add(this.label4);
            this.gbCoche.Controls.Add(this.label3);
            this.gbCoche.Controls.Add(this.label2);
            this.gbCoche.Controls.Add(this.label1);
            this.gbCoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCoche.Location = new System.Drawing.Point(12, 186);
            this.gbCoche.Name = "gbCoche";
            this.gbCoche.Size = new System.Drawing.Size(671, 178);
            this.gbCoche.TabIndex = 1;
            this.gbCoche.TabStop = false;
            this.gbCoche.Text = "Cambios estimados (km/h)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "(velocidades mín/máx)";
            // 
            // txtMarcha4Max
            // 
            this.txtMarcha4Max.Location = new System.Drawing.Point(513, 85);
            this.txtMarcha4Max.Name = "txtMarcha4Max";
            this.txtMarcha4Max.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha4Max.TabIndex = 16;
            this.txtMarcha4Max.Text = "130";
            this.txtMarcha4Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha4Min
            // 
            this.txtMarcha4Min.Location = new System.Drawing.Point(398, 85);
            this.txtMarcha4Min.Name = "txtMarcha4Min";
            this.txtMarcha4Min.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha4Min.TabIndex = 15;
            this.txtMarcha4Min.Text = "40";
            this.txtMarcha4Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha3Max
            // 
            this.txtMarcha3Max.Location = new System.Drawing.Point(513, 27);
            this.txtMarcha3Max.Name = "txtMarcha3Max";
            this.txtMarcha3Max.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha3Max.TabIndex = 14;
            this.txtMarcha3Max.Text = "100";
            this.txtMarcha3Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha3Min
            // 
            this.txtMarcha3Min.Location = new System.Drawing.Point(398, 27);
            this.txtMarcha3Min.Name = "txtMarcha3Min";
            this.txtMarcha3Min.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha3Min.TabIndex = 13;
            this.txtMarcha3Min.Text = "25";
            this.txtMarcha3Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha5Max
            // 
            this.txtMarcha5Max.Location = new System.Drawing.Point(515, 139);
            this.txtMarcha5Max.Name = "txtMarcha5Max";
            this.txtMarcha5Max.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha5Max.TabIndex = 12;
            this.txtMarcha5Max.Text = "170";
            this.txtMarcha5Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha5Min
            // 
            this.txtMarcha5Min.Location = new System.Drawing.Point(399, 139);
            this.txtMarcha5Min.Name = "txtMarcha5Min";
            this.txtMarcha5Min.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha5Min.TabIndex = 11;
            this.txtMarcha5Min.Text = "60";
            this.txtMarcha5Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha2Max
            // 
            this.txtMarcha2Max.Location = new System.Drawing.Point(197, 85);
            this.txtMarcha2Max.Name = "txtMarcha2Max";
            this.txtMarcha2Max.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha2Max.TabIndex = 10;
            this.txtMarcha2Max.Text = "70";
            this.txtMarcha2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha2Min
            // 
            this.txtMarcha2Min.Location = new System.Drawing.Point(81, 85);
            this.txtMarcha2Min.Name = "txtMarcha2Min";
            this.txtMarcha2Min.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha2Min.TabIndex = 9;
            this.txtMarcha2Min.Text = "15";
            this.txtMarcha2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha1Max
            // 
            this.txtMarcha1Max.Location = new System.Drawing.Point(197, 27);
            this.txtMarcha1Max.Name = "txtMarcha1Max";
            this.txtMarcha1Max.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha1Max.TabIndex = 8;
            this.txtMarcha1Max.Text = "15";
            this.txtMarcha1Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarcha1Min
            // 
            this.txtMarcha1Min.Location = new System.Drawing.Point(81, 27);
            this.txtMarcha1Min.Name = "txtMarcha1Min";
            this.txtMarcha1Min.Size = new System.Drawing.Size(100, 20);
            this.txtMarcha1Min.TabIndex = 4;
            this.txtMarcha1Min.Text = "0";
            this.txtMarcha1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Marcha 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marcha 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marcha 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marcha 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marcha 1";
            // 
            // gbGenetico
            // 
            this.gbGenetico.Controls.Add(this.label7);
            this.gbGenetico.Controls.Add(this.txtNumGeneraciones);
            this.gbGenetico.Controls.Add(this.label6);
            this.gbGenetico.Controls.Add(this.txtSize);
            this.gbGenetico.Location = new System.Drawing.Point(12, 370);
            this.gbGenetico.Name = "gbGenetico";
            this.gbGenetico.Size = new System.Drawing.Size(371, 171);
            this.gbGenetico.TabIndex = 2;
            this.gbGenetico.TabStop = false;
            this.gbGenetico.Text = "Características del algoritmo genético";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Número de generaciones";
            // 
            // txtNumGeneraciones
            // 
            this.txtNumGeneraciones.Location = new System.Drawing.Point(148, 104);
            this.txtNumGeneraciones.Name = "txtNumGeneraciones";
            this.txtNumGeneraciones.Size = new System.Drawing.Size(100, 20);
            this.txtNumGeneraciones.TabIndex = 19;
            this.txtNumGeneraciones.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tamaño de la población";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(148, 48);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 17;
            this.txtSize.Text = "100";
            // 
            // btnLanzamiento
            // 
            this.btnLanzamiento.Location = new System.Drawing.Point(421, 370);
            this.btnLanzamiento.Name = "btnLanzamiento";
            this.btnLanzamiento.Size = new System.Drawing.Size(252, 68);
            this.btnLanzamiento.TabIndex = 3;
            this.btnLanzamiento.Text = "Lanzar el algoritmo genético";
            this.btnLanzamiento.UseVisualStyleBackColor = true;
            this.btnLanzamiento.Click += new System.EventHandler(this.btnLanzamiento_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Enabled = false;
            this.btnVerResultados.Location = new System.Drawing.Point(421, 473);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(252, 68);
            this.btnVerResultados.TabIndex = 4;
            this.btnVerResultados.Text = "Ver resultados finales";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblGeneracion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblGeneracion
            // 
            this.tslblGeneracion.Name = "tslblGeneracion";
            this.tslblGeneracion.Size = new System.Drawing.Size(190, 17);
            this.tslblGeneracion.Text = "No se ha lanzado la optimización...";
            // 
            // bwCalculo
            // 
            this.bwCalculo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCalculo_DoWork);
            this.bwCalculo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCalculo_Completed);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Longitud";
            this.dataGridViewTextBoxColumn2.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MinVelocidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "MinVelocidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaxVelocidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaxVelocidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnLanzamiento);
            this.Controls.Add(this.gbGenetico);
            this.Controls.Add(this.gbCoche);
            this.Controls.Add(this.gbCircuito);
            this.Name = "Main";
            this.Text = "Fuel Optimizer: optimización de consumos de combustible";
            this.gbCircuito.ResumeLayout(false);
            this.gbCircuito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCircuito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramoBindingSource)).EndInit();
            this.gbCoche.ResumeLayout(false);
            this.gbCoche.PerformLayout();
            this.gbGenetico.ResumeLayout(false);
            this.gbGenetico.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCircuito;
        private System.Windows.Forms.DataGridView dgvCircuito;
        private System.Windows.Forms.BindingSource tramoBindingSource;
        private System.Windows.Forms.GroupBox gbCoche;
        private System.Windows.Forms.GroupBox gbGenetico;
        private System.Windows.Forms.TextBox txtLongitudTramoActualizacion;
        private System.Windows.Forms.Label lblTramoActualizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcha4Max;
        private System.Windows.Forms.TextBox txtMarcha4Min;
        private System.Windows.Forms.TextBox txtMarcha3Max;
        private System.Windows.Forms.TextBox txtMarcha3Min;
        private System.Windows.Forms.TextBox txtMarcha5Max;
        private System.Windows.Forms.TextBox txtMarcha5Min;
        private System.Windows.Forms.TextBox txtMarcha2Max;
        private System.Windows.Forms.TextBox txtMarcha2Min;
        private System.Windows.Forms.TextBox txtMarcha1Max;
        private System.Windows.Forms.TextBox txtMarcha1Min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumGeneraciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnLanzamiento;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minVelocidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxVelocidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblGeneracion;
        private System.ComponentModel.BackgroundWorker bwCalculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

