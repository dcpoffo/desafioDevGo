using System;
using System.Collections.Generic;

namespace backend.models
{
     public class Etapa
     {
          public Etapa(int id, DateTime inicio, DateTime fim)
          {
               this.Id = id;
               this.Inicio = inicio;
               this.fim = fim;
          }
          public int Id { get; set; }
          public DateTime Inicio { get; set; }
          public DateTime fim { get; set; }

          public IEnumerable<PessoaSalaTreinamento> PessoasSalaTreinamento { get; set; }

          public Etapa()
          { }


     }
}