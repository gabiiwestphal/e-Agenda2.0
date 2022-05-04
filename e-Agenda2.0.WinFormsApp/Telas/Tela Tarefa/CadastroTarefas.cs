using e_Agenda2._0.Dominio.Tarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Tarefa
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        public CadastroTarefas()
        {
            InitializeComponent();

            cb_Prioridade.Items.Add("Alta");
            cb_Prioridade.Items.Add("Normal");
            cb_Prioridade.Items.Add("Baixa");

            cb_Prioridade.SelectedIndex = 2;

            tb_Numero.Text = "";

        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                tb_Titulo.Text = tarefa.Titulo;
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_Titulo.Text))
            {
                tarefa.Titulo = tb_Titulo.Text;

                if (cb_Prioridade.SelectedIndex == 0)
                {
                    tarefa.Prioridade = 0;
                }
                else if (cb_Prioridade.SelectedIndex == 1)
                {
                    tarefa.Prioridade = (PrioridadeTarefa)1;
                }
                else if (cb_Prioridade.SelectedIndex == 2)
                {
                    tarefa.Prioridade = (PrioridadeTarefa)2;
                }
            }
            else
            {
                MessageBox.Show("Você não pode cadastrar uma tarefa sem um título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
