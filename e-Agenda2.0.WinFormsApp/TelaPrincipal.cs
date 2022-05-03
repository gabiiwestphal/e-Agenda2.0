using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Agenda2._0.WinFormsApp.Telas.Tela_Tarefa;
using e_Agenda2._0.WinFormsApp.Telas.Tela_Contato;
using e_Agenda2._0.WinFormsApp.Telas.Tela_Compromisso;

namespace e_Agenda2._0.WinFormsApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            ListagemCompromisso tela = new ListagemCompromisso();
            panelPrincipal.Controls.Add(tela);
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            ListagemTarefas tela = new ListagemTarefas();
            panelPrincipal.Controls.Add(tela);
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            ListagemContato tela = new ListagemContato();
            panelPrincipal.Controls.Add(tela);
        }
    }
}
