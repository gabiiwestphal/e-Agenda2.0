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
            comboBoxPrioridade.SelectedIndex = 0;
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
                txtId.Text = tarefa.id.ToString();
                txtTitulo.Text = tarefa.Descricao;
                comboBoxPrioridade.Text = tarefa.PrioridadeTarefa;
                txtDataCriacao.Text = tarefa.DataCriacao.ToString();
                PreencherCampoDataCriacao();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa.Descricao = txtTitulo.Text;
            tarefa.DataCriacao = DateTime.Parse(txtDataCriacao.Text);
            tarefa.PrioridadeTarefa = comboBoxPrioridade.Text;
        }

        private void PreencherCampoDataCriacao()
        {
            if (tarefa.DataCriacao == new DateTime(1, 1, 1))
                txtDataCriacao.Text = DateTime.Now.ToString();
            else
                txtDataCriacao.Text = Tarefa.DataCriacao.ToString();
        }
    }
}
