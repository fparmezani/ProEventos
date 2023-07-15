using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _eventos = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo HOrizonte",
                Lote = "1. LOte",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png",
            },new Evento(){
                EventoId = 2,
                Tema = "Angular e Novidades",
                Local = "São Paulo",
                Lote = "2. Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png",
            }
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
}
