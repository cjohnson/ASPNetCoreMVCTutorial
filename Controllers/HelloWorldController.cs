using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASPNetCoreMVCTutorial.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
    }
}