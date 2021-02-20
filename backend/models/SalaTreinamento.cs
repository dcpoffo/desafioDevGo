using System.Collections.Generic;

namespace backend.models
{
     public class SalaTreinamento
     {          
          public int Id { get; set; }
          public string Nome { get; set; }
          public int Lotacao { get; set; }
          public IEnumerable<SalaTreinamento> SalaTreinamentos { get; set; }         

          public SalaTreinamento()
          { }

          public SalaTreinamento(int id, string nome, int lotacao)
          {
               this.Id = id;
               this.Nome = nome;
               this.Lotacao = lotacao;
          }          
     }
}