 
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Models;
namespace PizzaStore.Controllers;

public class HelloWorldController : Controller{

//public string Index() => "Esta es la pagina de inicio desde HelloWorld Controller";
public IActionResult Index(){

DogViewModel doggo = new(){
    Name="sif",Age=2
};
    return View(doggo);
}

    
}
