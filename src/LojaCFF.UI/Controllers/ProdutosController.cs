using LojaCFF.Data.EF.Repositories;
using LojaCFF.Domain.Interfaces.Repositories;
using LojaCFF.Domain.Interfaces.Services;
using LojaCFF.Domain.Services;
using LojaCFF.UI.ViewModel.Produto;
using LojaCFF.UI.ViewModel.Produto.Maps;
using System.Web.Mvc;

namespace LojaCFF.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ITipoProdutoService _tipoProdutoService;
        private readonly TipoProdutoRepositoryEF _tipoProdutoRepositoryEF;
        public ProdutosController()
        {
            _tipoProdutoRepositoryEF = new TipoProdutoRepositoryEF();
            _produtoService = new ProdutoService(new ProdutoRepositoryEF());
            _tipoProdutoService = new TipoProdutoService(new TipoProdutoRepositoryEF());
        }

        // GET: Produto
        public ActionResult Index()
        {
            var produtos = _produtoService.Get().ToProdutosViewsModels();
            return View(produtos);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var tipos = _tipoProdutoService.Get();
            ViewBag.Tipos = tipos;

            return View();
        }

        [HttpPost]
        public ActionResult Add(ProdutoViewModel produtoVM)
        {
            var produto = produtoVM.ToProduto();

            //TODO : VALIDAR
            if (ModelState.IsValid)
            {
                _produtoService.Add(produto);

                return RedirectToAction("index");
            }

            var tipos = _tipoProdutoService.Get();
            ViewBag.Tipos = tipos;

            return View(produtoVM);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                var tipos = _tipoProdutoService.Get();
                ViewBag.Tipos = tipos;

                return View(_produtoService.Get((int)id).ToProdutoViewModel());
            }

            return RedirectToAction("index");
        }

        [HttpPost]
        public ActionResult Edit(ProdutoViewModel produtoVM)
        {
            var produto = produtoVM.ToProduto();

            //TODO : VALIDAR
            if (ModelState.IsValid)
            {
                var produtoBD = _produtoService.Get(produto.Id);

                produtoBD.Nome = produto.Nome;
                produtoBD.Preco = produto.Preco;
                produtoBD.TipoProdutoId = produto.TipoProdutoId;
                produtoBD.Qtde = produto.Qtde;

                _produtoService.Edit(produtoBD);

                return RedirectToAction("index");
            }

            var tipos = _tipoProdutoService.Get();
            ViewBag.Tipos = tipos;

            return View(produtoVM);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var produto = _produtoService.Get(id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            _produtoService.Delete(produto);

            return null;
        }
    }
}
