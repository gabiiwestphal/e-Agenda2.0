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
    public partial class CadastroItensTarefa : Form
    {
        public readonly Tarefa tarefa;

        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;

            l_TarefaSelecionada.Text = tarefa.Titulo;

            foreach (Item item in tarefa.Itens)
            {
                lb_Itens.Items.Add(item);
            }
        }

        public List<Item> ItensAdicionados
        {
            get
            {
                return lb_Itens.Items.Cast<Item>().ToList();
            }
        }

        private void btn_AdicionarItem_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(tb_Titulo.Text) == false)
            {
                Item item = new Item();

                item.Titulo = tb_Titulo.Text;

                if (cb_Status.SelectedIndex == 0)
                {
                    item.Concluido = false;
                }
                else if (cb_Status.SelectedIndex == 1)
                {
                    item.Concluido = true;
                }

                lb_Itens.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_Titulo.Clear();
            tb_Descricao.Clear();
            cb_Status.SelectedIndex = -1;

        }

    }
}

