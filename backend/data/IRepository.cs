using System.Threading.Tasks;
using backend.models;

namespace backend.data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T> (T entity) where T : class;
        Task<bool> SaveChangesAsync();
        
        Task<Pessoa[]> GetAllPessoasAsync();
        Task<Pessoa> GetPessoaAsyncById(int pessosId);

        Task<SalaTreinamento[]> GetAllSalasTreinamentoAsync();
        Task<SalaTreinamento> GetSalaTreinamentoAsyncById(int salaTreinamentoId);

        Task<SalaCafe[]> GetAllSalasCafeAsync();
        Task<SalaCafe> GetSalaCafeAsyncById(int salaCafeId);

        Task<Etapa[]> GetAllEtapasAsync();
        Task<Etapa> GetEtapaAsyncById(int etapaId);

        Task<HorarioCafe[]> GetAllHorariosCafeAsync();
        Task<HorarioCafe> GetHorarioCafeAsyncById(int horarioCafeId);
        
        Task<PessoaSalaTreinamento[]> GetAllPessoasSalaTreinamentoAsync(bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe);
        Task<PessoaSalaTreinamento[]> GetPessoaSalaTreinamentoAsyncByPessoaId(int pessoaId, bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe);
        Task<PessoaSalaTreinamento[]> GetAllPessoasSalaTreinamentoBySalaTreinamentoIdAsync(int salaTreinamentoId, bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe);
        Task<PessoaSalaTreinamento[]> GetAllPessoasSalaTreinamentoBySalaCafeIdAsync(int salaCafeId, bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe);
        Task<PessoaSalaTreinamento> GetPessoaSalaTreinamentoAsyncByPessoaSalaTreinamentoId(int pessoaSalaTreinamentoId, bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe);
        Task<PessoaSalaTreinamento> GetTesteAsyncByPessoaSalaTreinamentoId(int pessoaSalaTreinamentoId);
    }
}