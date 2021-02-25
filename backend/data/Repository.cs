using System.Linq;
using System.Threading.Tasks;
using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.data
{
     public class Repository : IRepository
     {
          private readonly DataContext _context;

          public Repository(DataContext context)
          {
               this._context = context;
          }

          public void Add<T>(T entity) where T : class
          {
               _context.Add(entity);
          }

          public void Delete<T>(T entity) where T : class
          {
               _context.Remove(entity);               
          }

          public void Update<T>(T entity) where T : class
          {
               _context.Update(entity);
          }

          public async Task<bool> SaveChangesAsync()
          {
               return (await _context.SaveChangesAsync()) > 0;
          }

          public async Task<Etapa[]> GetAllEtapasAsync()
          {
               IQueryable<Etapa> query = _context.Etapa;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<HorarioCafe[]> GetAllHorariosCafeAsync()
          {
               IQueryable<HorarioCafe> query = _context.HorarioCafe;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<Pessoa[]> GetAllPessoasAsync()
          {
               IQueryable<Pessoa> query = _context.Pessoa;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<SalaCafe[]> GetAllSalasCafeAsync()
          {
               IQueryable<SalaCafe> query = _context.SalaCafe;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<SalaTreinamento[]> GetAllSalasTreinamentoAsync()
          {
               IQueryable<SalaTreinamento> query = _context.SalaTreinamento;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<Etapa> GetEtapaAsyncById(int etapaId)
          {
               IQueryable<Etapa> query = _context.Etapa;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == etapaId);

               return await query.FirstOrDefaultAsync();
          }

          public async Task<HorarioCafe> GetHorarioCafeAsyncById(int horarioCafeId)
          {
               IQueryable<HorarioCafe> query = _context.HorarioCafe;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == horarioCafeId);

               return await query.FirstOrDefaultAsync();
          }

          public async Task<Pessoa> GetPessoaAsyncById(int pessosId)
          {
               IQueryable<Pessoa> query = _context.Pessoa;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == pessosId);

               return await query.FirstOrDefaultAsync();
          }

          public async Task<SalaCafe> GetSalaCafeAsyncById(int salaCafeId)
          {
               IQueryable<SalaCafe> query = _context.SalaCafe;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == salaCafeId);

               return await query.FirstOrDefaultAsync();
          }

          public async Task<SalaTreinamento> GetSalaTreinamentoAsyncById(int salaTreinamentoId)
          {
               IQueryable<SalaTreinamento> query = _context.SalaTreinamento;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == salaTreinamentoId);

               return await query.FirstOrDefaultAsync();
          }

          public async Task<PessoaSalaTreinamento[]> GetAllDadosTreinamentoAsyncByPessoaId(int pessoaId, bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe)
          {
               IQueryable<PessoaSalaTreinamento> query = _context.PessoaSalaTreinamento;
               
               if (incluirSalaTreinamento)
               {
                   query = query.Include(a => a.SalaTreinamento);
               }

               if (incluirPessoa)
               {
                   query = query.Include(a => a.Pessoa);
               }

               if (incluirEtapa)
               {
                   query = query.Include(a => a.Etapa);
               }

               if (incluirSalaCafe)
               {
                   query = query.Include(a => a.SalaCafe);
               }

               if (incluirHorarioCafe)
               {
                   query = query.Include(a => a.HorarioCafe);
               }

               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.PessoaId == pessoaId) ;
               return await query.ToArrayAsync();
          }

          public async Task<PessoaSalaTreinamento[]> GetAllPessoasSalaTreinamentoAsync(bool incluirSalaTreinamento, 
                              bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe)
          {
               IQueryable<PessoaSalaTreinamento> query = _context.PessoaSalaTreinamento;

               if (incluirSalaTreinamento)
               {
                   query = query.Include(a => a.SalaTreinamento);
               }

               if (incluirPessoa)
               {
                   query = query.Include(a => a.Pessoa);
               }

               if (incluirEtapa)
               {
                   query = query.Include(a => a.Etapa);
               }

               if (incluirSalaCafe)
               {
                   query = query.Include(a => a.SalaCafe);
               }

               if (incluirHorarioCafe)
               {
                   query = query.Include(a => a.HorarioCafe);
               }
               
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<PessoaSalaTreinamento[]> GetAllPessoasSalaTreinamentoBySalaTreinamentoIdAsync(int salaTreinamentoId,
                               bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa)
          {
               IQueryable<PessoaSalaTreinamento> query = _context.PessoaSalaTreinamento;
               
               if (incluirSalaTreinamento)
               {
                   query = query.Include(a => a.SalaTreinamento);
               }

               if (incluirPessoa)
               {
                   query = query.Include(a => a.Pessoa);
               }

               if (incluirEtapa)
               {
                   query = query.Include(a => a.Etapa);
               }              

               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.SalaTreinamentoId == salaTreinamentoId) ;
               return await query.ToArrayAsync();
          }

          public async Task<PessoaSalaTreinamento[]> GetAllPessoasSalaTreinamentoBySalaCafeIdAsync(int salaCafeId, bool incluirSalaCafe, bool incluirPessoa, bool incluirEtapa)
          {
               IQueryable<PessoaSalaTreinamento> query = _context.PessoaSalaTreinamento;
                              
               if (incluirPessoa)
               {
                   query = query.Include(a => a.Pessoa);
               }

               if (incluirEtapa)
               {
                   query = query.Include(a => a.Etapa);
               }

               if (incluirSalaCafe)
               {
                   query = query.Include(a => a.SalaCafe);
               }               

               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.SalaCafeId == salaCafeId) ;
               return await query.ToArrayAsync();
          }

          public async Task<PessoaSalaTreinamento> GetAllPessoasSalaTreinamentoAsyncById(int pessoaSalaTreinamentoId, bool incluirSalaTreinamento, bool incluirPessoa, bool incluirEtapa, bool incluirSalaCafe, bool incluirHorarioCafe)
          {
               IQueryable<PessoaSalaTreinamento> query = _context.PessoaSalaTreinamento;

               if (incluirSalaTreinamento)
               {
                   query = query.Include(a => a.SalaTreinamento);
               }

               if (incluirPessoa)
               {
                   query = query.Include(a => a.Pessoa);
               }

               if (incluirEtapa)
               {
                   query = query.Include(a => a.Etapa);
               }

               if (incluirSalaCafe)
               {
                   query = query.Include(a => a.SalaCafe);
               }

               if (incluirHorarioCafe)
               {
                   query = query.Include(a => a.HorarioCafe);
               }
               
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.FirstOrDefaultAsync();
          }          
     }
}