using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.Contato

namespace e_Agenda2._0.Dominio.Compromisso
{
    [Serializable]
    public class Compromisso
    {
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime DataCompromisso { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public Contato Contato { get; set; }
        public Compromisso(string assunto, string local, DateTime dataCompromisso, string horaInicio, string horaTermino, Contato contato)
        {
            this.Assunto = assunto;
            this.Local = local;
            this.HoraInicio = horaInicio;
            this.HoraTermino = horaTermino;
            this.DataCompromisso = dataCompromisso;
            this.Contato = contato;
        }

        public Compromisso()
        {
        }

        public override string ToString()
        {
            string contatoRelacionado = Contato is null ? "Não disponível" : Contato.Nome;

            return
            "Assunto: " + Assunto +
                "\tLocal: " + Local +
                "\tData: " + DataCompromisso.ToShortDateString() +
                "\tHora de início: " + HoraInicio +
                "\tHora de término: " + HoraTermino +
                "\tContato: " + contatoRelacionado + "\n";

        }
    }
     
}

