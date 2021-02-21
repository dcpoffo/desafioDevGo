using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EtapaController : ControllerBase
    {        
        private readonly IRepository _repositorio;

          public EtapaController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllEtapasAsync();
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Etapas: \n{ex.Message}");
               }
          }

          [HttpGet("{etapaId}")]
          public async Task<IActionResult> GetById(int etapaId)
          {
               try
               {
                    var result = await _repositorio.GetEtapaAsyncById(etapaId);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Etapa: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(Etapa etapa)
          {
               try
               {
                    _repositorio.Add(etapa);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(etapa);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Etapa: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{etapaId}")]
          public async Task<IActionResult> Put(int etapaId, Etapa etapa)
          {
               try
               {
                    var etapaCadastrada = await _repositorio.GetSalaCafeAsyncById(etapaId);

                    if (etapaCadastrada == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(etapa);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(etapa);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Etapa: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpDelete("{etapaId}")]
          public async Task<IActionResult> Delete(int etapaId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetEtapaAsyncById(etapaId);
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
                                   message = "Etapa removida com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Etapa: {ex.Message}");
               }
               return BadRequest();
          }
    }
}