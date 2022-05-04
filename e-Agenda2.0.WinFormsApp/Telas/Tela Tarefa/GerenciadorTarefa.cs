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
    public partial class GerenciadorTarefa : Form
    {
        private IRepositorioTarefa repositorioTarefa;

        public GerenciadorTarefa()
        {
          
            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }


        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            List<Tarefa> tarefasExistentes = repositorioTarefa.SelecionarTodos();

            foreach (Tarefa t in tarefasExistentes)
            {

                if (t.Titulo == tela.Tarefa.Titulo)
                {
                    MessageBox.Show("Esta tarefa já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (String.IsNullOrEmpty(t.Titulo))
                {
                    return;
                }
            }

            if (resultado == DialogResult.OK && !String.IsNullOrEmpty(tela.Tarefa.Titulo))
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
            else
            {
                return;
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            Tarefa tarefaSelecionadaPendente = (Tarefa)listTarefasPendentes.SelectedItem;
            Tarefa tarefaSelecionadaConcluida = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaSelecionadaPendente == null && tarefaSelecionadaConcluida == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                if (tarefaSelecionadaPendente != null)
                {
                    repositorioTarefa.Excluir(tarefaSelecionadaPendente);
                    CarregarTarefas();
                }

                else if (tarefaSelecionadaConcluida != null)
                {
                    repositorioTarefa.Excluir(tarefaSelecionadaConcluida);
                    CarregarTarefas();
                }

            }
        }

        private void btn_InserirItem_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa pendente",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);


            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<Item> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }

        }

        private void btn_AtualizarItem_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa pendente",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<Item> itensConcluidos = tela.ItensConcluidos;

                List<Item> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
