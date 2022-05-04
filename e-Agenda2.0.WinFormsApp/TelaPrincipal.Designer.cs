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
            this.l_eAgenda = new System.Windows.Forms.Label();
            this.btn_GerenciarTarefas = new System.Windows.Forms.Button();
            this.btn_GerenciarCompromissos = new System.Windows.Forms.Button();
            this.btn_GerenciarContatos = new System.Windows.Forms.Button();
            this.lb_Tarefas = new System.Windows.Forms.ListBox();
            this.lb_Compromissos = new System.Windows.Forms.ListBox();
            this.lb_Contatos = new System.Windows.Forms.ListBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_eAgenda
            // 
            this.l_eAgenda.AutoSize = true;
            this.l_eAgenda.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_eAgenda.Location = new System.Drawing.Point(369, 7);
            this.l_eAgenda.Name = "l_eAgenda";
            this.l_eAgenda.Size = new System.Drawing.Size(98, 22);
            this.l_eAgenda.TabIndex = 0;
            this.l_eAgenda.Text = "e-Agenda";
            // 
            // btn_GerenciarTarefas
            // 
            this.btn_GerenciarTarefas.Location = new System.Drawing.Point(10, 46);
            this.btn_GerenciarTarefas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GerenciarTarefas.Name = "btn_GerenciarTarefas";
            this.btn_GerenciarTarefas.Size = new System.Drawing.Size(242, 35);
            this.btn_GerenciarTarefas.TabIndex = 2;
            this.btn_GerenciarTarefas.Text = "Gerenciar Tarefas";
            this.btn_GerenciarTarefas.UseVisualStyleBackColor = true;
            this.btn_GerenciarTarefas.Click += new System.EventHandler(this.btn_GerenciarTarefas_Click);
            // 
            // btn_GerenciarCompromissos
            // 
            this.btn_GerenciarCompromissos.Location = new System.Drawing.Point(550, 46);
            this.btn_GerenciarCompromissos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GerenciarCompromissos.Name = "btn_GerenciarCompromissos";
            this.btn_GerenciarCompromissos.Size = new System.Drawing.Size(240, 35);
            this.btn_GerenciarCompromissos.TabIndex = 3;
            this.btn_GerenciarCompromissos.Text = "Gerenciar Compromissos";
            this.btn_GerenciarCompromissos.UseVisualStyleBackColor = true;
            this.btn_GerenciarCompromissos.Click += new System.EventHandler(this.btn_GerenciarCompromissos_Click);
            // 
            // btn_GerenciarContatos
            // 
            this.btn_GerenciarContatos.Location = new System.Drawing.Point(283, 46);
            this.btn_GerenciarContatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GerenciarContatos.Name = "btn_GerenciarContatos";
            this.btn_GerenciarContatos.Size = new System.Drawing.Size(240, 35);
            this.btn_GerenciarContatos.TabIndex = 4;
            this.btn_GerenciarContatos.Text = "Gerenciar Contatos";
            this.btn_GerenciarContatos.UseVisualStyleBackColor = true;
            this.btn_GerenciarContatos.Click += new System.EventHandler(this.btn_GerenciarContatos_Click);
            // 
            // lb_Tarefas
            // 
            this.lb_Tarefas.Enabled = false;
            this.lb_Tarefas.FormattingEnabled = true;
            this.lb_Tarefas.ItemHeight = 15;
            this.lb_Tarefas.Location = new System.Drawing.Point(10, 85);
            this.lb_Tarefas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Tarefas.Name = "lb_Tarefas";
            this.lb_Tarefas.Size = new System.Drawing.Size(242, 94);
            this.lb_Tarefas.TabIndex = 5;
            // 
            // lb_Compromissos
            // 
            this.lb_Compromissos.Enabled = false;
            this.lb_Compromissos.FormattingEnabled = true;
            this.lb_Compromissos.ItemHeight = 15;
            this.lb_Compromissos.Location = new System.Drawing.Point(550, 85);
            this.lb_Compromissos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Compromissos.Name = "lb_Compromissos";
            this.lb_Compromissos.Size = new System.Drawing.Size(240, 94);
            this.lb_Compromissos.TabIndex = 6;
            // 
            // lb_Contatos
            // 
            this.lb_Contatos.Enabled = false;
            this.lb_Contatos.FormattingEnabled = true;
            this.lb_Contatos.ItemHeight = 15;
            this.lb_Contatos.Location = new System.Drawing.Point(283, 85);
            this.lb_Contatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_Contatos.Name = "lb_Contatos";
            this.lb_Contatos.Size = new System.Drawing.Size(240, 94);
            this.lb_Contatos.TabIndex = 7;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(10, 602);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(819, 34);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 195);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lb_Contatos);
            this.Controls.Add(this.lb_Compromissos);
            this.Controls.Add(this.lb_Tarefas);
            this.Controls.Add(this.btn_GerenciarContatos);
            this.Controls.Add(this.btn_GerenciarCompromissos);
            this.Controls.Add(this.btn_GerenciarTarefas);
            this.Controls.Add(this.l_eAgenda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_eAgenda;
        private System.Windows.Forms.Button btn_GerenciarTarefas;
        private System.Windows.Forms.Button btn_GerenciarCompromissos;
        private System.Windows.Forms.Button btn_GerenciarContatos;
        private System.Windows.Forms.ListBox lb_Tarefas;
        private System.Windows.Forms.ListBox lb_Compromissos;
        private System.Windows.Forms.ListBox lb_Contatos;
        private System.Windows.Forms.Button btn_Sair;
    }
}