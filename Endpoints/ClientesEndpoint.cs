using TechMarketing.Data; 
using Microsoft.EntityFrameworkCore;
// using System.Reflection.Metadata.Ecma335;
// using System.Security.Cryptography.X509Certificates;

namespace TechMarketing.Endpoints; 

public static class ClientesEndpoint
{
    public static void MapClientesEndpoint(this WebApplication app)
    {
        app.MapGet("/clientes/satisfeitos", async (AppDbContext db) =>
        {
           var clientes = await db.Clientes.FirstOrDefaultAsync();

            if (clientes == null || clientes.ClienteTotal == 0) 
            {
                return Results.NotFound("Nenhum cliente encontrado");
            }

           var percentualSatisfacao = (double) clientes.ClienteSatisfeito /  clientes.ClienteTotal * 100;

           return Results.Ok (new
            {
                totalClientes = clientes.ClienteTotal,
                clientesSatisfeitos = clientes.ClienteSatisfeito,
                percentualSatisfacaoJason = Math.Round(percentualSatisfacao, 2)
            });
        });
    } 
}