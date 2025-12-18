using Person.Models;

namespace Person.Routes;

public static class PersonRoute
{
     //Método para buscar todas as routes
    public static void PersonRoutes(this WebApplication app) //Usando o this dizemos que esse método deriva/extende do Webapplication (portanto faz parte do app)
    {
        app.MapGet("Person", () => new PersonModel("henrique")); //() => é um handler, ela pega essa requisição e fala oq vai fazer com ele
        //Map serve para criar apis, lembre dos diferentes verbos
    }
}