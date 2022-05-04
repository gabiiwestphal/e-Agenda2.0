namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Contato
{
    partial class GerenciadorContato
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
            this.l_GerenciadorContato = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.lb_Contatos = new System.Windows.Forms.ListBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_GerenciadorContato
            // 
            this.l_GerenciadorContato.AutoSize = true;
            this.l_GerenciadorContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_GerenciadorContato.Location = new System.Drawing.Point(335, 7);
            this.l_GerenciadorContato.Name = "l_GerenciadorContato";
            this.l_GerenciadorContato.Size = new System.Drawing.Size(191, 19);
            this.l_GerenciadorContato.TabIndex = 0;
            this.l_GerenciadorContato.Text = "Gerenciador de Contato";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(10, 36);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(212, 41);
            this.btn_Inserir.TabIndex = 3;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(228, 36);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(212, 41);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(444, 36);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(212, 41);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lb_Contatos
            // 
            this.lb_Contatos.FormattingEnabled = true;
            this.lb_Contatos.ItemHeight = 15;
            this.lb_Contatos.Location = new System.Drawing.Point(10, 90);
            this.lb_Contatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Contatos.Name = "lb_Contatos";
            this.lb_Contatos.Size = new System.Drawing.Size(646, 64);
            this.lb_Contatos.TabIndex = 6;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(445, 172);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(211, 33);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // GerenciadorContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 225);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lb_Contatos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.l_GerenciadorContato);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GerenciadorContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_GerenciadorContato;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.ListBox lb_Contatos;
        private System.Windows.Forms.Button btn_Voltar;
    }
}