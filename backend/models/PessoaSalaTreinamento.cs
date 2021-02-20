namespace backend.models
{
     public class PessoaSalaTreinamento
     {          
          public int Id { get; set; }
          public int SalaTreinamentoId { get; set; }
          public int PessoaId { get; set; }
          public int EtapaId { get; set; }

          public SalaTreinamento SalaTreinamento { get; set; }
          public Pessoa Pessoa { get; set; }
          public Etapa Etapa { get; set; }

          public PessoaSalaTreinamento()
          { }

          public PessoaSalaTreinamento(int id, int salaTreinamentoId, int pessoaId, int etapaId)
          {
               this.Id = id;
               this.SalaTreinamentoId = salaTreinamentoId;
               this.PessoaId = pessoaId;
               this.EtapaId = etapaId;           
          }
     }
}