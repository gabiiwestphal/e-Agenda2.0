﻿namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Compromisso
{
    partial class GerenciadorCompromisso
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
            this.l_GerenciadorCompromisso = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.tb_PassadosFuturos = new System.Windows.Forms.TabControl();
            this.tab_Passados = new System.Windows.Forms.TabPage();
            this.listCompromissosPassados = new System.Windows.Forms.ListBox();
            this.tab_Futuros = new System.Windows.Forms.TabPage();
            this.listCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.tb_PassadosFuturos.SuspendLayout();
            this.tab_Passados.SuspendLayout();
            this.tab_Futuros.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_GerenciadorCompromisso
            // 
            this.l_GerenciadorCompromisso.AutoSize = true;
            this.l_GerenciadorCompromisso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_GerenciadorCompromisso.Location = new System.Drawing.Point(275, 9);
            this.l_GerenciadorCompromisso.Name = "l_GerenciadorCompromisso";
            this.l_GerenciadorCompromisso.Size = new System.Drawing.Size(238, 19);
            this.l_GerenciadorCompromisso.TabIndex = 0;
            this.l_GerenciadorCompromisso.Text = "Gerenciador de Compromisso";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(14, 38);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(247, 41);
            this.btn_Inserir.TabIndex = 2;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(266, 38);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(247, 41);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(518, 38);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(247, 41);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // tb_PassadosFuturos
            // 
            this.tb_PassadosFuturos.Controls.Add(this.tab_Passados);
            this.tb_PassadosFuturos.Controls.Add(this.tab_Futuros);
            this.tb_PassadosFuturos.Location = new System.Drawing.Point(10, 84);
            this.tb_PassadosFuturos.Name = "tb_PassadosFuturos";
            this.tb_PassadosFuturos.SelectedIndex = 0;
            this.tb_PassadosFuturos.Size = new System.Drawing.Size(1006, 184);
            this.tb_PassadosFuturos.TabIndex = 8;
            // 
            // tab_Passados
            // 
            this.tab_Passados.Controls.Add(this.listCompromissosPassados);
            this.tab_Passados.Location = new System.Drawing.Point(4, 24);
            this.tab_Passados.Name = "tab_Passados";
            this.tab_Passados.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Passados.Size = new System.Drawing.Size(998, 156);
            this.tab_Passados.TabIndex = 0;
            this.tab_Passados.Text = "Compromissos Passados";
            this.tab_Passados.UseVisualStyleBackColor = true;
            // 
            // listCompromissosPassados
            // 
            this.listCompromissosPassados.FormattingEnabled = true;
            this.listCompromissosPassados.ItemHeight = 15;
            this.listCompromissosPassados.Location = new System.Drawing.Point(0, 15);
            this.listCompromissosPassados.Name = "listCompromissosPassados";
            this.listCompromissosPassados.Size = new System.Drawing.Size(1000, 124);
            this.listCompromissosPassados.TabIndex = 6;
            // 
            // tab_Futuros
            // 
            this.tab_Futuros.Controls.Add(this.listCompromissosFuturos);
            this.tab_Futuros.Location = new System.Drawing.Point(4, 24);
            this.tab_Futuros.Name = "tab_Futuros";
            this.tab_Futuros.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Futuros.Size = new System.Drawing.Size(998, 156);
            this.tab_Futuros.TabIndex = 1;
            this.tab_Futuros.Text = "Compromissos Futuros";
            this.tab_Futuros.UseVisualStyleBackColor = true;
            this.tab_Futuros.Click += new System.EventHandler(this.tab_Futuros_Click);
            // 
            // listCompromissosFuturos
            // 
            this.listCompromissosFuturos.FormattingEnabled = true;
            this.listCompromissosFuturos.ItemHeight = 15;
            this.listCompromissosFuturos.Location = new System.Drawing.Point(0, 15);
            this.listCompromissosFuturos.Name = "listCompromissosFuturos";
            this.listCompromissosFuturos.Size = new System.Drawing.Size(751, 124);
            this.listCompromissosFuturos.TabIndex = 7;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(518, 287);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(247, 33);
            this.btn_Voltar.TabIndex = 9;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // GerenciadorCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 333);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.tb_PassadosFuturos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.l_GerenciadorCompromisso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GerenciadorCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Compromisso";
            this.tb_PassadosFuturos.ResumeLayout(false);
            this.tab_Passados.ResumeLayout(false);
            this.tab_Futuros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_GerenciadorCompromisso;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.TabControl tb_PassadosFuturos;
        private System.Windows.Forms.TabPage tab_Passados;
        private System.Windows.Forms.ListBox listCompromissosPassados;
        private System.Windows.Forms.TabPage tab_Futuros;
        private System.Windows.Forms.ListBox listCompromissosFuturos;
        private System.Windows.Forms.Button btn_Voltar;
    }
}