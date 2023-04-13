using GradeHorarios.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace GradeHorarios.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var cadastroSala = new List<CadastroSala>
            {
            new CadastroSala{NomeSala="Labin 1",Campus=Campus.PalmasGraciosa,Bloco=Bloco.A,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Labin 2",Campus=Campus.PalmasGraciosa,Bloco=Bloco.B,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Labin 3",Campus=Campus.PalmasGraciosa,Bloco=Bloco.C,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Labin 4",Campus=Campus.PalmasGraciosa,Bloco = Bloco.C,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Labin 5",Campus=Campus.PalmasGraciosa,Bloco = Bloco.B,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Sala 1",Campus=Campus.PalmasGraciosa,Bloco = Bloco.A,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Sala 2",Campus=Campus.PalmasGraciosa,Bloco = Bloco.B,Descricao="",NumeroPessoas="",},
            new CadastroSala{NomeSala="Sala 3",Campus=Campus.PalmasGraciosa,Bloco = Bloco.C,Descricao="",NumeroPessoas="",}
            };

            cadastroSala.ForEach(s => context.CadastroSala.Add(s));
            context.SaveChanges();

            var CadastroSemestre = new List<CadastroSemestre>
            {
            new CadastroSemestre{ID=1050,PeriodoLetivo="2020/1",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Primeiro},
            new CadastroSemestre{ID=4022,PeriodoLetivo="2020/2",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Segundo},
            new CadastroSemestre{ID=4041,PeriodoLetivo="2021/1",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Terceiro},
            new CadastroSemestre{ID=1045,PeriodoLetivo="2021/2",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Quarto},
            new CadastroSemestre{ID=3141,PeriodoLetivo="2022/1",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Quinto},
            new CadastroSemestre{ID=2021,PeriodoLetivo="2022/2",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Sexto},
            new CadastroSemestre{ID=2042,PeriodoLetivo="2023/1",Campus=Campus.PalmasGraciosa,Curso="Sistemas de Informação", MatrizCurricular="Atual", Semestre=Semestre.Setimo}
            };
            CadastroSemestre.ForEach(s => context.CadastroSemestre.Add(s));
            context.SaveChanges();
            var OfertaSala = new List<OfertaSala>
            {
            new OfertaSala{CadastroSalaID=1,CadastroSemestreID=1050,},
            new OfertaSala{CadastroSalaID=1,CadastroSemestreID=4022,},
            new OfertaSala{CadastroSalaID=1,CadastroSemestreID=4041,},
            new OfertaSala{CadastroSalaID=2,CadastroSemestreID=1045,},
            new OfertaSala{CadastroSalaID=2,CadastroSemestreID=3141,},
            new OfertaSala{CadastroSalaID=2,CadastroSemestreID=2021,},
            new OfertaSala{CadastroSalaID=3,CadastroSemestreID=1050},
               new OfertaSala{CadastroSalaID=4,CadastroSemestreID=1050,},
                new OfertaSala{CadastroSalaID=4,CadastroSemestreID=4022,},
            new OfertaSala{CadastroSalaID=5,CadastroSemestreID=4041,},
                new OfertaSala{CadastroSalaID=6,CadastroSemestreID=1045},
            new OfertaSala{CadastroSalaID=7,CadastroSemestreID=3141,},
            };
            OfertaSala.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}