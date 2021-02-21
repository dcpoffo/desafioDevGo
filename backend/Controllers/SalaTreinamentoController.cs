using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaTreinamentoController : ControllerBase
    {
        private readonly IRepository _repositorio;

          public SalaTreinamentoController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllSalasTreinamentoAsync();
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Salas de Treinamento: \n{ex.Message}");
               }
          }

          [HttpGet("{salaTreinamentoId}")]
          public async Task<IActionResult> GetById(int salaTreinamentoId)
          {
               try
               {
                    var result = await _repositorio.GetSalaTreinamentoAsyncById(salaTreinamentoId);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Sala de Treinamento: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(SalaTreinamento salaTreinamento)
          {
               try
               {
                    _repositorio.Add(salaTreinamento);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(salaTreinamento);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Sala Treinamento: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{salaTreinamentoId}")]
          public async Task<IActionResult> Put(int salaTreinamentoId, SalaTreinamento salaTreinamento)
          {
               try
               {
                    var salaTreinamentoCadastrada = await _repositorio.GetSalaTreinamentoAsyncById(salaTreinamentoId);

                    if (salaTreinamentoCadastrada == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(salaTreinamento);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(salaTreinamento);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Sala Treinamento: {ex.Message}");
               }
               return BadRequest();
          }
          
          [HttpDelete("{salaTreinamentoId}")]
          public async Task<IActionResult> Delete(int salaTreinamentoId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetSalaTreinamentoAsyncById(salaTreinamentoId);
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
                                   message = "Sala de Treinamento removida com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Sala de Treinamento: {ex.Message}");
               }
               return BadRequest();
          }
    }
}