using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _eventos = new Evento[]
    {
        new Evento() {EventoId = 1, Local = "São Paulo", DataEvento = "2021-08-20", Tema = "Angular 11 e .NET 5", Participantes = 250, Lote = "1º Lote", ImagemURL = "foto.jpg"},
        new Evento() {EventoId = 2, Local = "Rio de Janeiro", DataEvento = "2021-08-21", Tema = "React e .NET Core", Participantes = 350, Lote = "2º Lote", ImagemURL = "foto.jpg"}
    };

    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    { 
        return _eventos;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    { 
        return _eventos.Where(evento => evento.EventoId == id);
    }
    
    [HttpPost]
    public string Post()
    { 
        return "post";
    }

    
    [HttpPut("{id}")]
    public string Put(int id)
    { 
        return $"put id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    { 
        return $"delete id = {id}";
    }
}
