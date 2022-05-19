using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Metodo de accion
        public IActionResult Index()
        {
            return View();
            /*
             *  Llama al método View del controlador.
             *  Usa una plantilla de vista para generar una respuesta HTML.  
             */
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            /* El objeto de diccionario ViewData:
             * -contiene datos que se pasarán a la vista.
             * -es un objeto dinámico, se puede usar cualquier tipo. */
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}

/*    
 * Un punto de conexión HTTP:

Es una dirección URL que se puede establecer como destino en la aplicación web, por ejemplo, https://localhost:5001/HelloWorld.
Combina:
El protocolo usado: HTTPS.
La ubicación de red del servidor web, incluido el puerto TCP: localhost:5001.
El URI de destino: HelloWorld.
 * 
 */
