using e_Agenda2._0.Dominio.Compartilhado;
using e_Agenda2._0.Dominio.Compromisso;
using e_Agenda2._0.Dominio.Contato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Contato
{
    public partial class GerenciadorContato : Form
    {
        private IRepositorioContato repositorioContato;
        private IRepositorioCompromisso repositorioCompromisso;
        private Validar validar = new Validar();

        public GerenciadorContato()
        {
          
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            lb_Contatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                lb_Contatos.Items.Add(c);
            }
        }


        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();
            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            if (resultado == DialogResult.OK && !String.IsNullOrEmpty(tela.Contato.Telefone)
                && !String.IsNullOrEmpty(tela.Contato.Email) && !String.IsNullOrEmpty(tela.Contato.Nome))
            {
                if (validar.TelefoneEstaValido(tela.Contato.Telefone) && validar.EmailEstaValido(tela.Contato.Email))
                {
                    List<Contato> contatos = repositorioContato.SelecionarTodos();

                    foreach (Contato contato in contatos)
                    {
                        if (tela.Contato.Telefone == contato.Telefone ||
                            tela.Contato.Email == contato.Email ||
                            tela.Contato.Nome == contato.Nome)
                        {
                            MessageBox.Show("Este contato já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }

                    repositorioContato.Inserir(tela.Contato);
                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)lb_Contatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new CadastroContato();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)lb_Contatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissoFuturo();

                foreach (Compromisso compromisso in compromissos)
                {
                    if (compromisso.Contato.Nome == contatoSelecionado.Nome)
                    {
                        MessageBox.Show("Você não pode excluir este contato pois ele esta vinculado a um compromisso.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

    }
}
