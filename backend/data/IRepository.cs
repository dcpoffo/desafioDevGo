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
        Task<SalaCafe> GetSalaAsyncById(int salaCafeId);

        Task<Etapa[]> GetAllEtapasAsync();
        Task<Etapa> GetEtapaAsyncById(int etapaId);

        Task<HorarioCafe[]> GetAllHorariosCafeAsync();
        Task<HorarioCafe> GetHorarioCafeAsyncById(int horarioCafeId);

        // Ao consultar uma pessoa cadastrada no treinamento, o sistema deverá retornar à sala em que a 
        // pessoa ficará em cada etapa e o espaço onde ela realizará cada intervalo de café.
        
        // Ao consultar uma sala cadastrada ou um espaço de café, o sistema deverá retornar uma 
        //lista das pessoas que estarão naquela sala ou espaço em cada etapa do evento.


    }
}