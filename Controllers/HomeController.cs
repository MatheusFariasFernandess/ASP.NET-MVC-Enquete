using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Questionario.Models;
using System.ComponentModel.DataAnnotations;

namespace Questionario.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Responder(Resposta form)
    {
        if (ModelState.IsValid)
        {
            RespostaArmazenamento.AdicionarResposta(form);
            return View("AgradecimentosPorResponder");
        }
        return View();
    }
    public IActionResult ExibirQuestionario()
    {
        return View(RespostaArmazenamento.RespostaExibicao);
    }

}
