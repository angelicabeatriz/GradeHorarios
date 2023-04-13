using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GradeHorarios.Models
{
    public enum Bloco
    {
        A, B, C
    }
    public enum Campus
    {
        PalmasGraciosa
    }

    public class CadastroSala
    {
        //ID -
        //NOME SALA 
        //CAMPUS
        //BLOCO
        //DESCRICAO
        //NUMERO DE PESSOAS
        //SALAS

        public int ID { get; set; }
        public string NomeSala { get; set; }
        public Campus? Campus { get; set; }
        public Bloco? Bloco { get; set; }
        public string Descricao { get; set; }
        public string NumeroPessoas { get; set; }

        public virtual OfertaSala  OfertaSala { get; set; }
    }
}