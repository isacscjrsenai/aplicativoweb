using aplicativoweb.Models;
using Microsoft.AspNetCore.Mvc;
namespace aplicativoweb.Controllers;


public class CursoController:Controller{

    /*
        Ações ou Actions
        Objetivo: redirecionar para as páginas
        View
    */

    /*
        Interface 
    */
    List <Curso> cursos = new List<Curso>{new Curso("Desenvolvedor C#", "Crie Aplicativos Incrivéis", "Primeiros Passos no ASP.NET Core"),
                                          new Curso("Desenvolvedor Java", "Crie Aplicativos em Java", "Primeiro passos no desenvolvimento de aplicativos Java"),
                                          new Curso("Gerenciador de Bancos de Dados", "Trabalhe com banco de Dados", "Primeiro passos no SQL"),

                                          new Curso("Eletricista Instalador Predial", "Faça instalações Elétricas em casas e Prédios", "Eletricista Predial"),
                                          new Curso("Eletricista Instalador Solar", "Trabalhe com geração de energia Solar", "Eletricista Solar"),
                                          new Curso("Eletricista Instalador Industrial", "Progrida na carreira, trabalhe na industria", "Eletricista Industrial"),

                                          new Curso("Panificador", "Trabalhe com massas, pães, bolos e confeitaria", "Panificação"),
                                          new Curso("Corte e Custura", "Faça roupas arojadas e da moda", "Custura")

                                         };
    public IActionResult Index(){
        //Curso c1 = new Curso();
        //c1.Descricao = "Primeiros Passos no ASP.NET Core";
       // c1.TituloInterno = "Desenvolvedor C#";
       // c1.TituloMarketing ="Crie Aplicativos Incrivéis";
        ViewData["cursos"] = cursos;
                return View();
    }    
}