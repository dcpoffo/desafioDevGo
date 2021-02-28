using System;
using System.Collections.Generic;

namespace backend.models
{
     public class HorarioCafe
     {
          public HorarioCafe(int id, DateTime inicio, DateTime fim)
          {
               this.Id = id;
               this.Inicio = inicio;
               this.Fim = fim;
          }
          public int Id { get; set; }
          public DateTime Inicio { get; set; }
          public DateTime Fim { get; set; }
          

          public HorarioCafe()
          { }


     }
}