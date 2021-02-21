using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class SalaCafeController : ControllerBase
     {
          private readonly IRepository _repositorio;

          public SalaCafeController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllSalasCafeAsync();
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Salas de Café: \n{ex.Message}");
               }
          }

          [HttpGet("{salaCafeId}")]
          public async Task<IActionResult> GetById(int salaCafeId)
          {
               try
               {
                    var result = await _repositorio.GetSalaCafeAsyncById(salaCafeId);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Sala de Café: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(SalaCafe salaCafe)
          {
               try
               {
                    _repositorio.Add(salaCafe);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(salaCafe);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Sala Café: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{salaCafeId}")]
          public async Task<IActionResult> Put(int salaCafeId, SalaCafe salaCafe)
          {
               try
               {
                    var salaCafeCadastrada = await _repositorio.GetSalaCafeAsyncById(salaCafeId);

                    if (salaCafeCadastrada == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(salaCafe);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(salaCafe);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Sala Café: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpDelete("{salaCafeId}")]
          public async Task<IActionResult> Delete(int salaCafeId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetSalaCafeAsyncById(salaCafeId);
                    if (cadastrado == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Delete(cadastrado);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(
                              new
                              {
                                   message = "Sala de Café removida com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Sala de Café: {ex.Message}");
               }
               return BadRequest();
          }
     }
}