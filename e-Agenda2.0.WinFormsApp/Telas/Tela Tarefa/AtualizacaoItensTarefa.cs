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
    public partial class AtualizacaoItensTarefa : Form
    {
        private readonly Tarefa tarefa;
        private IRepositorioTarefa repositorioTarefa;

        public AtualizacaoItensTarefa(Tarefa tarefa)
        {            
            InitializeComponent();
            this.tarefa = tarefa;

            l_Titulo.Text = tarefa.Titulo;

            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                checkedLb_Itens.Items.Add(item);

                if (item.Concluido)
                    checkedLb_Itens.SetItemChecked(i, true);

                i++;
            }

            foreach (var item in tarefa.Itens)
            {
                if (checkedLb_Itens.SelectedItems.Count == checkedLb_Itens.Items.Count)
                {
                    repositorioTarefa.Excluir(tarefa);
                }

            }
        }

        public List<Item> ItensConcluidos
        {
            get
            {
                return checkedLb_Itens.CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return checkedLb_Itens.Items
                    .Cast<Item>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void l_AtualizacaoItem_Click(object sender, EventArgs e)
        {

        }
    }
}
