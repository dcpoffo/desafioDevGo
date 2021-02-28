using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaSalaTreinamentoController : ControllerBase
    {
        private readonly IRepository _repositorio;

        public PessoaSalaTreinamentoController(IRepository repositorio)
        {
            this._repositorio = repositorio;
        }

        [HttpGet("pessoaId={pessoaId}")]
        public async Task<IActionResult> GetPessoaSalaTreinamentoAsyncByPessoaId(int pessoaId)
        {
            try
            {
                var result = await _repositorio.GetPessoaSalaTreinamentoAsyncByPessoaId(pessoaId, true, true, true, true, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao obter treinamentos da pessoa: \n{ex.Message}");
            }
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _repositorio.GetAllPessoasSalaTreinamentoAsync(true, true, true, true, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao obter dados dos Treinamentos: \n{ex.Message}");
            }
        }       

        [HttpGet("salaTreinamentoId={salaTreinamentoId}")]
        public async Task<IActionResult> GetAllPessoasSalaTreinamentoBySalaTreinamentoIdAsync(int salaTreinamentoId)
        {
            try
            {
                var result = await _repositorio.GetAllPessoasSalaTreinamentoBySalaTreinamentoIdAsync(salaTreinamentoId, true, true, true, true, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao obter listagem de pessoas da sala de treinamento: \n{ex.Message}");
            }
        }

        [HttpGet("salaCafeId={salaCafeId}")]
        public async Task<IActionResult> GetAllPessoasSalaTreinamentoBySalaCafeIdAsync(int salaCafeId)
        {
            try
            {
                var result = await _repositorio.GetAllPessoasSalaTreinamentoBySalaCafeIdAsync(salaCafeId, true, true, true, true, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao obter listagem de pessoas do espaço de cafe: \n{ex.Message}");
            }
        }

        [HttpGet("{pessoaSalaTreinamentoId}")]
          public async Task<IActionResult> GetById(int pessoaSalaTreinamentoId)
          {
               try
               {
                    var result = await _repositorio.GetPessoaSalaTreinamentoAsyncByPessoaSalaTreinamentoId(pessoaSalaTreinamentoId, true, true, true, true, true);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Horario de Café: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(PessoaSalaTreinamento pessoaSalaTreinamento)
          {
               try
               {
                    _repositorio.Add(pessoaSalaTreinamento);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(pessoaSalaTreinamento);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Treinamento: {ex.Message}");
               }
               return BadRequest();
          }

        [HttpPut("{pessoaSalaTreinamentoId}")]
          public async Task<IActionResult> Put(int pessoaSalaTreinamentoId, PessoaSalaTreinamento pessoaSalaTreinamento)
          {               
               try
               {
                    var cadastrado = await _repositorio.GetTesteAsyncByPessoaSalaTreinamentoId(pessoaSalaTreinamentoId);
                         
                    if (cadastrado == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(pessoaSalaTreinamento);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(pessoaSalaTreinamento);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Treinamento: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpDelete("{pessoaSalaTreinamentoId}")]
          public async Task<IActionResult> Delete(int pessoaSalaTreinamentoId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetPessoaSalaTreinamentoAsyncByPessoaSalaTreinamentoId(pessoaSalaTreinamentoId, true, true, true, true, true);
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
                                   message = "Treinamento removido com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Treinamento: {ex.Message}");
               }
               return BadRequest();
          }
    }
}