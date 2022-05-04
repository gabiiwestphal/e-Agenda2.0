namespace e_Agenda2._0.WinFormsApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GerenciarTarefas = new System.Windows.Forms.Button();
            this.btn_GerenciarCompromissos = new System.Windows.Forms.Button();
            this.btn_GerenciarContatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GerenciarTarefas
            // 
            this.btn_GerenciarTarefas.BackColor = System.Drawing.Color.SeaShell;
            this.btn_GerenciarTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GerenciarTarefas.Location = new System.Drawing.Point(140, 67);
            this.btn_GerenciarTarefas.Name = "btn_GerenciarTarefas";
            this.btn_GerenciarTarefas.Size = new System.Drawing.Size(288, 69);
            this.btn_GerenciarTarefas.TabIndex = 1;
            this.btn_GerenciarTarefas.Text = "Tarefas";
            this.btn_GerenciarTarefas.UseVisualStyleBackColor = false;
            this.btn_GerenciarTarefas.Click += new System.EventHandler(this.btn_GerenciarTarefas_Click);
            // 
            // btn_GerenciarCompromissos
            // 
            this.btn_GerenciarCompromissos.BackColor = System.Drawing.Color.SeaShell;
            this.btn_GerenciarCompromissos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GerenciarCompromissos.Location = new System.Drawing.Point(140, 227);
            this.btn_GerenciarCompromissos.Name = "btn_GerenciarCompromissos";
            this.btn_GerenciarCompromissos.Size = new System.Drawing.Size(288, 79);
            this.btn_GerenciarCompromissos.TabIndex = 3;
            this.btn_GerenciarCompromissos.Text = "Compromissos";
            this.btn_GerenciarCompromissos.UseVisualStyleBackColor = false;
            this.btn_GerenciarCompromissos.Click += new System.EventHandler(this.btn_GerenciarCompromissos_Click);
            // 
            // btn_GerenciarContatos
            // 
            this.btn_GerenciarContatos.BackColor = System.Drawing.Color.SeaShell;
            this.btn_GerenciarContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GerenciarContatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GerenciarContatos.Location = new System.Drawing.Point(140, 142);
            this.btn_GerenciarContatos.Name = "btn_GerenciarContatos";
            this.btn_GerenciarContatos.Size = new System.Drawing.Size(288, 79);
            this.btn_GerenciarContatos.TabIndex = 2;
            this.btn_GerenciarContatos.Text = "Contatos";
            this.btn_GerenciarContatos.UseVisualStyleBackColor = false;
            this.btn_GerenciarContatos.Click += new System.EventHandler(this.btn_GerenciarContatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "e-Agenda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::e_Agenda2._0.WinFormsApp.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 334);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GerenciarContatos);
            this.Controls.Add(this.btn_GerenciarCompromissos);
            this.Controls.Add(this.btn_GerenciarTarefas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label l_eAgenda;
        private System.Windows.Forms.Button btn_GerenciarTarefas;
        private System.Windows.Forms.Button btn_GerenciarCompromissos;
        private System.Windows.Forms.Button btn_GerenciarContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}