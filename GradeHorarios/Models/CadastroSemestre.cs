using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GradeHorarios.Models
{
    public enum Semestre
    {
        Primeiro,Segundo, Terceiro, Quarto, Quinto, Sexto, Setimo, Oitavo
    }

    public class CadastroSemestre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string PeriodoLetivo { get; set; }
        public Campus? Campus { get; set; }
        public string Curso { get; set; }
        public string MatrizCurricular { get; set; }
        public Semestre? Semestre { get; set; }

        public virtual OfertaSala OfertaSala { get; set; }
    }
}