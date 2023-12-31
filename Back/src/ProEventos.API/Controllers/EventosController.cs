using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Data;
using ProEventos.Api.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventosController : ControllerBase
{
    private readonly DataContext _dataContext;

    public EventosController(DataContext context)
    {
        _dataContext = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _dataContext.Eventos;

    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _dataContext.Eventos.FirstOrDefault(evento => evento.EventoId == id);

    }
}
