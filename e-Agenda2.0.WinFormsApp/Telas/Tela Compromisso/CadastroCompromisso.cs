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

namespace e_Agenda2._0.WinFormsApp.Telas.Tela_Compromisso
{
    public partial class CadastroCompromisso : Form
    {
            private Compromisso compromisso;
            private IRepositorioContato repositorioContato;

            public CadastroCompromisso()
            {
                InitializeComponent();


                List<Contato> contatos = repositorioContato.SelecionarTodos();

                cb_Contato.Items.Clear();

                foreach (Contato c in contatos)
                {
                    cb_Contato.Items.Add(c.Nome);
                }

            }

            public Compromisso Compromisso
            {
                get
                {
                    return compromisso;
                }
                set
                {
                    compromisso = value;
                    tb_Assunto.Text = compromisso.Assunto;
                    tb_Local.Text = compromisso.Local;

                    if (compromisso.DataCompromisso < dt_Data.MinDate)
                    {
                        dt_Data.Value = DateTime.Now;
                    }
                    else
                    {
                        dt_Data.Value = compromisso.DataCompromisso;
                    }

                    tb_HoraInicio.Text = compromisso.HoraInicio;
                    tb_HoraTermino.Text = compromisso.HoraTermino;

                    if (!String.IsNullOrEmpty(cb_Contato.Text))
                    {
                        cb_Contato.Text = compromisso.Contato.Nome;
                    }

                }
            }

            private Contato ReceberContato(string nome)
            {
                List<Contato> contatos = repositorioContato.SelecionarTodos();

                foreach (Contato contato in contatos)
                {
                    if (contato.Nome == nome)
                        return contato;
                }

                return null;
            }

            private void btn_Inserir_Click(object sender, EventArgs e)
            {
                compromisso.Assunto = tb_Assunto.Text;
                compromisso.Local = tb_Local.Text;
                compromisso.DataCompromisso = dt_Data.Value;
                compromisso.HoraInicio = tb_HoraInicio.Text;
                compromisso.HoraTermino = tb_HoraTermino.Text;
                compromisso.Contato = ReceberContato(cb_Contato.Text);
            }

            private void btn_Cancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}

