using AutoMapper;
using CursoMVC.App.ViewModels;
using CursoMVC.Business.Interfaces;
using CursoMVC.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursoMVC.App.Controllers
{
    public class ProdutosController : MainController
    {
        protected readonly IProdutoRepository _produtoRepository;
        protected readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosCategorias()));
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var produtoViewModel = await ObterProdutoCategoria(id);

            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);

            var produto = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Adicionar(produto);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var produtoViewModel = await ObterProdutoCategoria(id);

            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(produtoViewModel);

            var produto = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Atualizar(produto);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var produtoViewModel = await ObterProdutoCategoria(id);

            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoViewModel = await ObterProdutoCategoria(id);

            if (produtoViewModel == null) return NotFound();

            await _produtoRepository.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<ProdutoViewModel> ObterProdutoCategoria(Guid id)
        {
            return _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoCategoria(id));
        }
    }
}
