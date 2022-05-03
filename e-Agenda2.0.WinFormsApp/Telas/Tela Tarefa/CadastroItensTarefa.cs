﻿using e_Agenda2._0.Dominio.Tarefa;
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
        private readonly Tarefa tarefa;

        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Descricao;

            foreach (Item item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);
            }
        }

        public List<Item> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items.Cast<Item>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricaoItem.Text) == false)
            {
                List<string> descricoes = ItensAdicionados.Select(x => x.Descricao.ToUpper()).ToList();

                if (descricoes.Count == 0 || descricoes.Contains(txtDescricaoItem.Text) == false)
                {
                    Item item = new Item();

                    item.Descricao = txtDescricaoItem.Text;

                    listItensTarefa.Items.Add(item);
                }
                else
                    MessageBox.Show("Item já existente na tarefa!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Descrição vazia", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
