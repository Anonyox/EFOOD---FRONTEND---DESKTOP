namespace EFOOD___FRONTEND___DESKTOP.Models.Login_Module.routers
{
    /*AS ROTAS SÃO RESPONSÁVEIS PARA INDICAR O CAMINHO NO QUAL DEVE SER ENVIADA A REQUISIÇÃO HTTP PARA OBTER RETORNO
   DA API NODEJS, TODOS OS MÉTODOS NA API, TEM UMA ROTA NO QUAL DEVE SER CHAMADA PELO FRONT END QUE ESTÁ CONSUMINDO*/
    public class login_router_routers
    {
        private string ROUTE = "logar"; //BUSCA TODOS OS USUÁRIOS

        public string getROUTE()
        {
            return this.ROUTE;
        }

        private string ROUTEUSER = "logins/user"; //BUSCA USUÁRIO SOLICITADO

        public string getROUTEUSER()
        {
            return this.ROUTEUSER;
        }
    }
}