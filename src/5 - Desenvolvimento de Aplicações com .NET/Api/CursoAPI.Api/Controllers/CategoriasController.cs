using AutoMapper;
using CursoAPI.Api.ViewModels;
using CursoMVC.Business.Interfaces;
using CursoMVC.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursoAPI.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriasController : MainController
    {
        protected readonly ICategoriaRepository _categoriaRepository;
        protected readonly IMapper _mapper;

        public CategoriasController(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaViewModel>>> GetCategorias()
        {
            var categoriaViewModel = _mapper.Map<IEnumerable<CategoriaViewModel>>(await _categoriaRepository.ObterTodos());

            return Ok(categoriaViewModel);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CategoriaViewModel>> Get(Guid id)
        {
            var categoriaViewModel = await ObterCategoriaProdutos(id);

            if (categoriaViewModel == null) return NotFound();

            return Ok(categoriaViewModel);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaViewModel>> Post(CategoriaViewModel categoriaViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            await _categoriaRepository.Adicionar(categoria);

            return Ok(categoria);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<CategoriaViewModel>> Put(Guid id, CategoriaViewModel categoriaViewModel)
        {
            if (id != categoriaViewModel.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            await _categoriaRepository.Atualizar(categoria);

            return Ok(categoria);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<CategoriaViewModel>> Delete(Guid id)
        {
            var categoriaViewModel = await ObterCategoriaProdutos(id);

            if (categoriaViewModel == null) return NotFound();

            await _categoriaRepository.Remover(id);

            return Ok(categoriaViewModel);
        }

        private async Task<CategoriaViewModel> ObterCategoriaProdutos(Guid id)
        {
            return _mapper.Map<CategoriaViewModel>(await _categoriaRepository.ObterCategoriaProdutos(id));
        }
    }
}
