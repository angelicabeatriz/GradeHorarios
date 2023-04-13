using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradeHorarios.Models
{
    public enum Funcao
    {
        Coordenador
    }
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public Funcao? Funcao { get; set; }
    }
}