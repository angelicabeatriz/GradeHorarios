using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradeHorarios.Models
{
    public enum Periodo
    {
        Primeiro, Segundo, Terceiro, Quarto, Quinto, Sexto, Setimo, Oitavo
    }
    public class OfertaSala
    {
        //Cadastro de Sala
        //Salas 
        //Cadastrar Semestre
        //Semestres
        //Ofertar Disciplina
        //Tabela de Disciplinas
        public int OfertaSalaID { get; set; }
        public string Professor { get; set; }
        public Periodo? Periodo { get; set; }
        public int CadastroSalaID { get; set; }
        public int CadastroSemestreID { get; set; }

        public virtual CadastroSala CadastroSala { get; set; }
        public virtual CadastroSemestre CadastroSemestre { get; set; }
    }
}