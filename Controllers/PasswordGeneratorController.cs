using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace PasswordGeneratorAPI.Controllers;

public class PasswordGeneratorController : ControllerBase
{
    //
    // GET: /PasswordGenerator/ 
    public string Index()
    {
        return "Welcome to the Password Generator API.";
    }
    
    //
    // GET: /PasswordGenerator/Generate/
    public string Generate()
    {
        return "";
    }
    
    // POST: "/validate"
    public string Validate()
    {
        return "";
    }
    
    //
    // GET: /PasswordGenerator/Health/
    public string Health()
    {
        return "";
    }
}