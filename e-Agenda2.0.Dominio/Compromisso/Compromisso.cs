using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.Contato;
using e_Agenda2._0.Dominio.Compartilhado;

namespace e_Agenda2._0.Dominio.Compromisso
{
    public class Compromisso
    {
        public string Assunto { get; set; }
        public string Local { get; set; }
        public string NomeContato { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataCompromisso { get => MostrarDataCompromisso(DataInicio, HoraInicio); }

        public Compromisso()
        {

        }
        public Compromisso(string assunto, string local, string contato, DateTime horaInicio, DateTime horaTermino, DateTime dataInicio)
        {
            Assunto = assunto;
            Local = local;
            NomeContato = contato;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataInicio = dataInicio;

        }
       
        public override string ToString()
        {
            string retorno =

                "Assunto: " + Assunto +
                "\tLocal: " + Local +
                "\tContato: " + NomeContato +
                "\tData: " + DataInicio.ToShortDateString() +
                "\tHorário de início: " + HoraInicio.ToShortTimeString() +
                "\tHorário de término: " + HoraTermino.ToShortTimeString() + "\n";

            return retorno;
        }
        private DateTime MostrarDataCompromisso(DateTime data, DateTime hora)
        {
            int dia, mes, ano, horas, minutos;
            dia = data.Day;
            mes = data.Month;
            ano = data.Year;
            horas = hora.Hour;
            minutos = hora.Minute;
            return new DateTime(ano, mes, dia, horas, minutos, 0);
        }
        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine(" - É necessário inserir um assunto para os compromissos!");

            if (string.IsNullOrEmpty(Local))
                sb.AppendLine(" - É necessário inserir um local para os compromissos!");

            if (NomeContato == null)
                sb.AppendLine(" - É necessário inserir um contato!");

            if (HoraInicio == new DateTime(1, 1, 1))
                sb.AppendLine(" - É necessário inserir um horário de início!");

            if (HoraTermino == new DateTime(1, 1, 1))
                sb.AppendLine(" - É necessário inserir um horário de término!");

            if (DataInicio == new DateTime(1, 1, 1))
                sb.AppendLine(" - É necessário inserir uma data de início!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();

        }
    }
}
