
using Microsoft.AspNetCore.Mvc;

public class VagaController : Controller
{
    private IVagasData data;

    public VagaController (IVagasData data)
    {
        this.data = data;
    }

    [HttpGet]
    public ActionResult AdicionaVaga()
    {
        return View();
    }

    [HttpPost]
    public ActionResult AdicionaVaga(Vagas vagas)
    {
        data.AdicionaVaga(vagas);
        return View();
    }


    public ActionResult ListaVaga()
    {
        return View();
    }

     public ActionResult ListaVagaCandidato()
    {
        return View();
    }
}