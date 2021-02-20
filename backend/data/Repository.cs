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

          public async Task<SalaCafe> GetSalaAsyncById(int salaCafeId)
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
     }
}