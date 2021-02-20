using System.Collections.Generic;

namespace backend.models
{
     public class SalaCafe
     {          
          public int Id { get; set; }
          public string Nome { get; set; }
          public IEnumerable<PessoaSalaCafe> PessoasSalaCafe { get; set; }

          public SalaCafe()
          { }

          public SalaCafe(int id, string nome)
          {
               this.Id = id;
               this.Nome = nome;
          }
     }
}