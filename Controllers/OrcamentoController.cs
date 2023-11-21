using Microsoft.AspNetCore.Mvc;
public class OrcamentoController : Controller
{
    private IOrcamentoData data;
    private IAgendamentoData agendadata;

    public OrcamentoController (IOrcamentoData data, IAgendamentoData agendadata)
    {
        this.data = data;
        this.agendadata= agendadata;
    }

    [HttpGet]
    public ActionResult ListaOrcamento() 
    {
        List<Orcamento> lista = data.Read();
        return View();      
    }     
    [HttpPost]
    public ActionResult Orcamento(Orcamento orcamento)
    {        
        ViewBag.Horario=data.Read();
        return View();
    }
    
}
