using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HorarioCafeController : ControllerBase
    {
        private readonly IRepository _repositorio;

          public HorarioCafeController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllHorariosCafeAsync();
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Horarios de Café: \n{ex.Message}");
               }
          }

          [HttpGet("{horarioCafeId}")]
          public async Task<IActionResult> GetById(int horarioCafeId)
          {
               try
               {
                    var result = await _repositorio.GetHorarioCafeAsyncById(horarioCafeId);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Horario de Café: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(HorarioCafe horarioCafe)
          {
               try
               {
                    _repositorio.Add(horarioCafe);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(horarioCafe);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Horario de Café: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{horarioCafeId}")]
          public async Task<IActionResult> Put(int horarioCafeId, HorarioCafe horarioCafe)
          {
               try
               {
                    var horarioCafeCadastrado = await _repositorio.GetHorarioCafeAsyncById(horarioCafeId);

                    if (horarioCafeCadastrado == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(horarioCafe);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(horarioCafe);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Horario de Café: {ex.Message}");
               }
               return BadRequest();
          }
          [HttpDelete("{horarioCafeId}")]
          public async Task<IActionResult> Delete(int horarioCafeId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetHorarioCafeAsyncById(horarioCafeId);
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
                                   message = "Horário de Café removido com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir Horário de Café: {ex.Message}");
               }
               return BadRequest();
          }
    }
}