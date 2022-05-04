namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Tarefa
{
    partial class CadastroTarefas
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
            this.l_CadastroTarefa = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.l_titulo = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.l_Prioridade = new System.Windows.Forms.Label();
            this.cb_Prioridade = new System.Windows.Forms.ComboBox();
            this.tb_Numero = new System.Windows.Forms.TextBox();
            this.l_Numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_CadastroTarefa
            // 
            this.l_CadastroTarefa.AutoSize = true;
            this.l_CadastroTarefa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_CadastroTarefa.Location = new System.Drawing.Point(18, 6);
            this.l_CadastroTarefa.Name = "l_CadastroTarefa";
            this.l_CadastroTarefa.Size = new System.Drawing.Size(153, 19);
            this.l_CadastroTarefa.TabIndex = 0;
            this.l_CadastroTarefa.Text = "Cadastro de Tarefa";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Cadastrar.Location = new System.Drawing.Point(10, 145);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(184, 32);
            this.btn_Cadastrar.TabIndex = 1;
            this.btn_Cadastrar.Text = "Cadastrar Tarefa";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(220, 145);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(184, 32);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // l_titulo
            // 
            this.l_titulo.AutoSize = true;
            this.l_titulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_titulo.Location = new System.Drawing.Point(220, 39);
            this.l_titulo.Name = "l_titulo";
            this.l_titulo.Size = new System.Drawing.Size(47, 16);
            this.l_titulo.TabIndex = 3;
            this.l_titulo.Text = "Título:";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(220, 57);
            this.tb_Titulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(184, 23);
            this.tb_Titulo.TabIndex = 5;
            // 
            // l_Prioridade
            // 
            this.l_Prioridade.AutoSize = true;
            this.l_Prioridade.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Prioridade.Location = new System.Drawing.Point(10, 91);
            this.l_Prioridade.Name = "l_Prioridade";
            this.l_Prioridade.Size = new System.Drawing.Size(76, 16);
            this.l_Prioridade.TabIndex = 8;
            this.l_Prioridade.Text = "Prioridade:";
            // 
            // cb_Prioridade
            // 
            this.cb_Prioridade.FormattingEnabled = true;
            this.cb_Prioridade.Location = new System.Drawing.Point(10, 109);
            this.cb_Prioridade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Prioridade.Name = "cb_Prioridade";
            this.cb_Prioridade.Size = new System.Drawing.Size(394, 23);
            this.cb_Prioridade.TabIndex = 9;
            // 
            // tb_Numero
            // 
            this.tb_Numero.Enabled = false;
            this.tb_Numero.Location = new System.Drawing.Point(10, 55);
            this.tb_Numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Numero.Name = "tb_Numero";
            this.tb_Numero.Size = new System.Drawing.Size(184, 23);
            this.tb_Numero.TabIndex = 11;
            // 
            // l_Numero
            // 
            this.l_Numero.AutoSize = true;
            this.l_Numero.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Numero.Location = new System.Drawing.Point(10, 39);
            this.l_Numero.Name = "l_Numero";
            this.l_Numero.Size = new System.Drawing.Size(60, 16);
            this.l_Numero.TabIndex = 10;
            this.l_Numero.Text = "Número:";
            // 
            // CadastroTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 205);
            this.Controls.Add(this.tb_Numero);
            this.Controls.Add(this.l_Numero);
            this.Controls.Add(this.cb_Prioridade);
            this.Controls.Add(this.l_Prioridade);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.l_titulo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.l_CadastroTarefa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_CadastroTarefa;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label l_titulo;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.Label l_Prioridade;
        private System.Windows.Forms.ComboBox cb_Prioridade;
        private System.Windows.Forms.TextBox tb_Numero;
        private System.Windows.Forms.Label l_Numero;
    }
}