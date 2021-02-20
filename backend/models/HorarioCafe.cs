using System;
using System.Collections.Generic;

namespace backend.models
{
     public class HorarioCafe
     {
          public int Id { get; set; }
          public DateTime DataHoraInicio { get; set; }
          public DateTime DataHoraFim { get; set; }
          public IEnumerable<PessoaSalaCafe> PessoasSalaCafe { get; set; }

          public HorarioCafe()
          { }

          public HorarioCafe(int id, DateTime dataHoraInicio, DateTime dataHoraFim)
          {
               this.Id = id;
               this.DataHoraInicio = dataHoraInicio;
               this.DataHoraFim = dataHoraFim;
          }
     }
}