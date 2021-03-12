using CursoMVC.Business.Interfaces;
using CursoMVC.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAPI.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriasController : MainController
    {
        protected readonly ICategoriaRepository _categoriaRepository;

        public CategoriasController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> Get()
        {
            return await _categoriaRepository.ObterTodos();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Categoria>> Get(Guid id)
        {
            var categoria = await _categoriaRepository.ObterCategoriaProdutos(id);

            if (categoria == null) return NotFound();

            return categoria;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria)
        {
            if (categoria == null) return BadRequest();

            await _categoriaRepository.Adicionar(categoria);

            return Ok(categoria);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, Categoria categoria)
        {
            if (id != categoria.Id) return BadRequest();

            await _categoriaRepository.Atualizar(categoria);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var categoria = await _categoriaRepository.ObterCategoriaProdutos(id);

            if (categoria == null) return NotFound();

            await _categoriaRepository.Remover(id);

            return Ok(categoria);
        }
    }
}
