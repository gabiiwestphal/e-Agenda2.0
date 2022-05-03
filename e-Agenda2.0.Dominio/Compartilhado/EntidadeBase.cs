using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int id;

        public abstract string Validar();
    }
}
