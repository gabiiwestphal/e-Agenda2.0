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
    public partial class CadastroContato : Form
    {
        private Contato contato;

        public CadastroContato()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                tb_Nome.Text = contato.Nome;
                tb_Email.Text = contato.Email;
                tb_Telefone.Text = contato.Telefone;
                tb_Empresa.Text = contato.Empresa;
                tb_Cargo.Text = contato.Cargo;
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            contato.Nome = tb_Nome.Text;
            contato.Email = tb_Email.Text;
            contato.Telefone = tb_Telefone.Text;
            contato.Empresa = tb_Empresa.Text;
            contato.Cargo = tb_Cargo.Text;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
