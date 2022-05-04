﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.Tarefa
{
    [Serializable]

    public class Item
    {
        public string Titulo { get; set; }

        public bool Concluido { get; set; }

        public override string ToString()
        {
            return "\t Titulo: " + Titulo +
                "\t Concluído: " + Concluido + "\n";
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
