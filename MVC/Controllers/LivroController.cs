using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        public ActionResult Index()
        {
            /*
            * #Documentação
            * Utilizando o objeto de conexão com a API consome a rota [Get] api/Livro e
            * converte o resultado em uma lista de objetos do tipo LivrosModeloMVC retornando a view Cadastrar
            */
            IEnumerable<LivrosModeloMVC> listaLivros;
            HttpResponseMessage response = App.WebAPIClient.GetAsync("Livro").Result;
            listaLivros = response.Content.ReadAsAsync<IEnumerable<LivrosModeloMVC>>().Result;
            return View(listaLivros);
        }

        public ActionResult Cadastrar()
        {
            /*
            * #Documentação
            * Inicializa uma nova view para novo objeto do tipo LivrosModeloMVC
            */
            return View(new LivrosModeloMVC());
        }

        [HttpPost]
        public ActionResult Cadastrar(LivrosModeloMVC livro)
        {
            /*
            * #Documentação
            * Utilizando o objeto de conexão com a API consome a rota [Post] api/Livro
            * e retorna a view Index com mensagem de sucesso
            */
            HttpResponseMessage response = App.WebAPIClient.PostAsJsonAsync("Livro", livro).Result;
            TempData["Status"] = "Cadastrado";
            TempData["Mensagem"] = "Livro cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            /*
            * #Documentação
            * Utilizando o objeto de conexão com a API consome a rota [Get] api/Livro/{id},
            * obtendo os dados de um Livro, converte o resultado em um objetos do tipo LivrosModeloMVC
            * e retorna a view Editar
            */
            HttpResponseMessage response = App.WebAPIClient.GetAsync("Livro/" + id.ToString()).Result;
            return View(response.Content.ReadAsAsync<LivrosModeloMVC>().Result);
        }

        [HttpPost]
        public ActionResult Editar(LivrosModeloMVC livro)
        {
            /*
            * #Documentação
            * Utilizando o objeto de conexão com a API consome a rota [Put] api/Livro/{id}
            * e retorna a view Index com mensagem de sucesso
            */
            HttpResponseMessage response = App.WebAPIClient.PutAsJsonAsync("Livro/" + livro.id, livro).Result;
            TempData["Status"] = "Editado";
            TempData["Mensagem"] = "Livro editado com sucesso!";
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            /*
            * #Documentação
            * Utilizando o objeto de conexão com a API consome a rota [Delete] api/Livro/{id}
            * e retorna a view Index com mensagem de sucesso
            */
            HttpResponseMessage response = App.WebAPIClient.DeleteAsync("Livro/" + id.ToString()).Result;
            TempData["Status"] = "Excluido";
            TempData["Mensagem"] = "Livro removido com sucesso!";
            return RedirectToAction("Index");
        }
    }
}