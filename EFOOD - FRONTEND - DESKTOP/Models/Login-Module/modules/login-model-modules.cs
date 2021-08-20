using System.Collections.Generic;

namespace EFOOD___FRONTEND___DESKTOP.Models.Login_Module.modules
{
    public class Usuario
    {
        public int id_user { get; set; }
        public string nome_user { get; set; }
        public string senha_user { get; set; }
        public string perfil_user { get; set; }
    } //GET E SET PARA CADA CAMPO NO BANCO
    public class Root
    {
        public List<Usuario> Usuarios { get; set; }
    } //LISTA COM A CONSULTA REALIZADA
}