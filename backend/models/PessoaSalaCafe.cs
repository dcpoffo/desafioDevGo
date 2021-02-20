namespace backend.models
{
     public class PessoaSalaCafe
     {
          public int Id { get; set; }
          public int SalaCafeId { get; set; }
          public int PessoaId { get; set; }
          public int HorarioCafeId { get; set; }

          public SalaCafe SalaCafe { get; set; }
          public Pessoa Pessoa { get; set; }
          public HorarioCafe HorarioCafe { get; set; }

          public PessoaSalaCafe()
          { }

          public PessoaSalaCafe(int id, int salaCafeId, int pessoaId, int horarioCafeId)
          {
               this.Id = id;
               this.SalaCafeId = salaCafeId;
               this.PessoaId = pessoaId;
               this.HorarioCafeId = horarioCafeId;
          }
     }
}