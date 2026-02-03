using TechMarketing.Data; 
using Microsoft.EntityFrameworkCore;
// using System.Reflection.Metadata.Ecma335;
// using System.Security.Cryptography.X509Certificates;

namespace TechMarketing.Endpoints; 

public static class VendasEndpoint
{
    public static void MapVendasEndpoint(this WebApplication app)
    {
        app.MapGet("/vendas/{ano:int}", async (int ano, AppDbContext db) =>
        {
            //vendas do ano sincroniza com o ano atual da tabela
            var vendasDoAno = await db.Vendas
                .Where(v => v.AnoVenda == ano)
                .ToListAsync();
 

            if (!vendasDoAno.Any()) 
            {
                return Results.NotFound("Vendas não registradas nesse ano");
            }

            var vendasRealizadas = vendasDoAno.Sum(v => v.QuantidadeVenda);
            var vendasMeta = vendasDoAno.First().MetaVenda;

            if (vendasMeta == 0)
            {
                return Results.BadRequest("A meta não pode ser nula");
            }

            var percentualVendas = (double) vendasRealizadas / vendasMeta * 100; 

            return Results.Ok (new 
            {
                ano = ano, 
                vendasMeta = vendasMeta, 
                vendasRealizadas = vendasRealizadas, 
                percentualVendas = Math.Round(percentualVendas, 2)
            });
        });
    } 
}