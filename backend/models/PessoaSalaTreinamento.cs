namespace backend.models
{
     public class PessoaSalaTreinamento
     {          
          public int Id { get; set; }
          public int SalaTreinamentoId { get; set; }
          public int PessoaId { get; set; }
          public int EtapaId { get; set; }
          public int SalaCafeId { get; set; }
          public int HorarioCafeId { get; set; }

          public SalaTreinamento SalaTreinamento { get; set; }
          public Pessoa Pessoa { get; set; }
          public Etapa Etapa { get; set; }
          public SalaCafe SalaCafe { get; set; }
          public HorarioCafe HorarioCafe { get; set; }

          public PessoaSalaTreinamento()
          { }

          public PessoaSalaTreinamento(int id, int salaTreinamentoId, int pessoaId, int etapaId, int salaCafeId, int horarioCafeId)
          {
               this.Id = id;
               this.SalaTreinamentoId = salaTreinamentoId;
               this.PessoaId = pessoaId;
               this.EtapaId = etapaId;           
               this.SalaCafeId = salaCafeId;
               this.HorarioCafeId = horarioCafeId;
          }
     }
}