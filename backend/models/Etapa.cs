using System;
using System.Collections.Generic;

namespace backend.models
{
     public class Etapa
     {
          public int Id { get; set; }
          public DateTime DataHoraInicio { get; set; }
          public DateTime DataHoraFim { get; set; }
          public IEnumerable<PessoaSalaTreinamento> PessoasSalaTreinamento { get; set; }

          public Etapa()
          { }

          public Etapa(int id, DateTime dataHoraInicio, DateTime dataHoraFim)
          {
               this.Id = id;
               this.DataHoraInicio = dataHoraInicio;
               this.DataHoraFim = dataHoraFim;

          }
     }
}