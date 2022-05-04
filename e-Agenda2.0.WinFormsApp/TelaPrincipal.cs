using e_Agenda2._0.Dominio.Compromisso;
using e_Agenda2._0.Dominio.Contato;
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

namespace e_Agenda2._0.WinFormsApp
{
    public partial class TelaPrincipal : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        private IRepositorioContato repositorioContato;
        private IRepositorioCompromisso repositorioCompromisso;

        public TelaPrincipal()
        {
           
            InitializeComponent();

            CarregarTarefa();
            CarregarContato();
            CarregarCompromisso();
        }

        private void CarregarTarefa()
        {

        }  

        private void CarregarContato()
        {
            
        }

        private void CarregarCompromisso()
        {
            
        }


        private void btn_GerenciarTarefas_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_GerenciarCompromissos_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_GerenciarContatos_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
