using e_Agenda2._0.Dominio.Compartilhado;
using e_Agenda2._0.Dominio.Compromisso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Compromisso
{
    public partial class GerenciadorCompromisso : Form
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private Validar validar = new Validar();

        public GerenciadorCompromisso()
        {        

            InitializeComponent();
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissosPassados = repositorioCompromisso.SelecionarCompromissoPassado();

            listCompromissosPassados.Items.Clear();

            foreach (Compromisso c in compromissosPassados)
            {
                listCompromissosPassados.Items.Add(c);
            }

            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissoFuturo();

            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromissosFuturos.Items.Add(c);
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            CadastroCompromisso tela = new CadastroCompromisso();
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            if (resultado == DialogResult.OK &&
                !String.IsNullOrEmpty(tela.Compromisso.Assunto) &&
                !String.IsNullOrEmpty(tela.Compromisso.Local) &&
                validar.HorarioEstaValido(tela.Compromisso.HoraInicio) &&
                validar.HorarioEstaValido(tela.Compromisso.HoraTermino))
            {
                if (tela.Compromisso.DataCompromisso >= DateTime.Today &&
                    TimeSpan.Parse(tela.Compromisso.HoraTermino) > TimeSpan.Parse(tela.Compromisso.HoraInicio))
                {
                    List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissoFuturo();

                    foreach (Compromisso compromisso in compromissos)
                    {
                        if (tela.Compromisso.DataCompromisso.Date == compromisso.DataCompromisso.Date && TimeSpan.Parse(compromisso.HoraTermino) > TimeSpan.Parse(tela.Compromisso.HoraInicio))
                        {
                            MessageBox.Show("Você não pode cadastrar compromissos na mesma data e horario!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    repositorioCompromisso.Inserir(tela.Compromisso);
                    CarregarCompromissos();
                    return;
                }
            }

            MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSemanal = (Compromisso)listCompromissosPassados.SelectedItem;
            Compromisso compromissoFuturo = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSemanal == null && compromissoFuturo == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromisso tela = new CadastroCompromisso();

            if (compromissoSemanal != null)
            {
                tela.Compromisso = compromissoSemanal;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }
            }

            else if (compromissoFuturo != null)
            {
                tela.Compromisso = compromissoFuturo;

                DialogResult resultado = tela.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioCompromisso.Editar(tela.Compromisso);
                    CarregarCompromissos();
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSemanal = (Compromisso)listCompromissosPassados.SelectedItem;
            Compromisso compromissoFuturo = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSemanal == null && compromissoFuturo == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {

                if (compromissoFuturo != null)
                {
                    repositorioCompromisso.Excluir(compromissoFuturo);
                    CarregarCompromissos();
                }

                else if (compromissoSemanal != null)
                {
                    repositorioCompromisso.Excluir(compromissoSemanal);
                    CarregarCompromissos();
                }

            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tab_Futuros_Click(object sender, EventArgs e)
        {

        }
    }
}
