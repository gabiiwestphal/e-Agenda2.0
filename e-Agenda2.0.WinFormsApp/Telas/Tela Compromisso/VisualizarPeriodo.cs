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
    public partial class VisualizarPeriodo : Form
    {
        private Compromisso compromisso;
        private IRepositorioCompromisso repositorioCompromisso;

        public VisualizarPeriodo()
        {
            InitializeComponent();   
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissoPorPeriodo(dt_DataInicial.Value, dt_DataFinal.Value);

            lb_Compromissos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                lb_Compromissos.Items.Add(c);
            }
        }
      
    }
}

