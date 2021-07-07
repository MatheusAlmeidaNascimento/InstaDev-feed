using System.Collections.Generic;
using System;

namespace InstaDev_feed.Controllers
{
    [route("Perfil")]
    public class PerfilController: controller
    {
        Post PostModel = new Post();
        Usuario u = new Usuario();

        public IActionResult Index(){
            ViewBag.UserName = HttpContext.Session.GetString("_UserName");
            ViewBag.Name = HttpContext.Session.GetString("_Nome");
            ViewBag.ImagemUsuario = HttpContext.Session.GetString("_FotoUsuario");
            ViewBag.Posts = PostModel.LerTodas();
            ViewBag.usuarios = u.LerTodos();
            return View();
        }

        public IActionResult ListarPublicacao(){
            string nick = HttpContext.Session.GetString("_UserName");
            List<Post> usuariosPost = new List<Post>();
            usuariosPost = PostModel.LerTodas();
            var tempPost = usuariosPost.Find(x => x.NomeUsuario == nick);
            ViewBag.PostUsuario = tempPost;
            return LocalRedirect("~/Perfil");
        }
    }
}