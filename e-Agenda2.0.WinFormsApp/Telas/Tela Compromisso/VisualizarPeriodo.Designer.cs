namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Compromisso
{
    partial class VisualizarPeriodo
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
            this.l_Visualizar = new System.Windows.Forms.Label();
            this.dt_DataInicial = new System.Windows.Forms.DateTimePicker();
            this.l_DataInicial = new System.Windows.Forms.Label();
            this.dt_DataFinal = new System.Windows.Forms.DateTimePicker();
            this.l_DataFinal = new System.Windows.Forms.Label();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.lb_Compromissos = new System.Windows.Forms.ListBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Visualizar
            // 
            this.l_Visualizar.AutoSize = true;
            this.l_Visualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_Visualizar.Location = new System.Drawing.Point(228, 7);
            this.l_Visualizar.Name = "l_Visualizar";
            this.l_Visualizar.Size = new System.Drawing.Size(290, 19);
            this.l_Visualizar.TabIndex = 6;
            this.l_Visualizar.Text = "Visualizar Compromisso por Periodo";
            // 
            // dt_DataInicial
            // 
            this.dt_DataInicial.Location = new System.Drawing.Point(10, 60);
            this.dt_DataInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_DataInicial.Name = "dt_DataInicial";
            this.dt_DataInicial.Size = new System.Drawing.Size(386, 23);
            this.dt_DataInicial.TabIndex = 13;
            // 
            // l_DataInicial
            // 
            this.l_DataInicial.AutoSize = true;
            this.l_DataInicial.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_DataInicial.Location = new System.Drawing.Point(10, 44);
            this.l_DataInicial.Name = "l_DataInicial";
            this.l_DataInicial.Size = new System.Drawing.Size(80, 16);
            this.l_DataInicial.TabIndex = 12;
            this.l_DataInicial.Text = "Data Inicial:";
            // 
            // dt_DataFinal
            // 
            this.dt_DataFinal.Location = new System.Drawing.Point(423, 60);
            this.dt_DataFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_DataFinal.Name = "dt_DataFinal";
            this.dt_DataFinal.Size = new System.Drawing.Size(366, 23);
            this.dt_DataFinal.TabIndex = 15;
            // 
            // l_DataFinal
            // 
            this.l_DataFinal.AutoSize = true;
            this.l_DataFinal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_DataFinal.Location = new System.Drawing.Point(423, 44);
            this.l_DataFinal.Name = "l_DataFinal";
            this.l_DataFinal.Size = new System.Drawing.Size(76, 16);
            this.l_DataFinal.TabIndex = 14;
            this.l_DataFinal.Text = "Data Final:";
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(10, 98);
            this.btn_Visualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(776, 37);
            this.btn_Visualizar.TabIndex = 16;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // lb_Compromissos
            // 
            this.lb_Compromissos.Enabled = false;
            this.lb_Compromissos.FormattingEnabled = true;
            this.lb_Compromissos.ItemHeight = 15;
            this.lb_Compromissos.Location = new System.Drawing.Point(9, 152);
            this.lb_Compromissos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Compromissos.Name = "lb_Compromissos";
            this.lb_Compromissos.Size = new System.Drawing.Size(777, 109);
            this.lb_Compromissos.TabIndex = 17;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Voltar.Location = new System.Drawing.Point(424, 274);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(365, 37);
            this.btn_Voltar.TabIndex = 18;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // VisualizarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 326);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lb_Compromissos);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.dt_DataFinal);
            this.Controls.Add(this.l_DataFinal);
            this.Controls.Add(this.dt_DataInicial);
            this.Controls.Add(this.l_DataInicial);
            this.Controls.Add(this.l_Visualizar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisualizarPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar por Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Visualizar;
        private System.Windows.Forms.DateTimePicker dt_DataInicial;
        private System.Windows.Forms.Label l_DataInicial;
        private System.Windows.Forms.DateTimePicker dt_DataFinal;
        private System.Windows.Forms.Label l_DataFinal;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.ListBox lb_Compromissos;
        private System.Windows.Forms.Button btn_Voltar;
    }
}