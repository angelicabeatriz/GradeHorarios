using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradeHorarios.Models
{
    public enum DiaSemana
    {
        Segunda, Terça, Quarta, Quinta, Sexta
    }
    public class SemanaDia
    {
        public string SemanaDiaID { get; set; }
        public DiaSemana? DiaSemana { get; set; }
    }
}