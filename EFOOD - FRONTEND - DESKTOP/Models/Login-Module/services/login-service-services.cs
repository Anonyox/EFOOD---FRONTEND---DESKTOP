using RestSharp;
using RestSharp.Serialization.Json;
using EFOOD___FRONTEND___DESKTOP.contexto.requestCenter;
using EFOOD___FRONTEND___DESKTOP.Models.Login_Module.modules;
using EFOOD___FRONTEND___DESKTOP.Models.Login_Module.routers;

namespace EFOOD___FRONTEND___DESKTOP.Models.Login_Module.services
{
    public class login_service_services
    {


        #region VARIÁVEIS E INSTÂNCIAS
        public static dotEnv dotEnv = new dotEnv();
        public static login_router_routers router = new login_router_routers();
        string nomeUser, senhaUser, perfilUser;
        public string mensagem;

        public bool success = false;

        string url = dotEnv.getHTTP() + dotEnv.getPORT() + dotEnv.getROUTEPRIMARY();
        #endregion


        #region MÉTODOS DE FUNCIONALIDADES
        public string consultarLogin(string usuario, string senha) //GET CONSULTA UM ÚNICO USUÁRIO
        {
            RestClient restClient = new RestClient(url+router.getROUTEUSER()+"/"+usuario+"/"+senha);
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);
            if (restResponse.ContentLength <= -1 || restResponse.StatusCode == System.Net.HttpStatusCode.BadRequest || restResponse.StatusCode == 0)
            {
                mensagem = "ERRO DE CONEXÃO COM O SERVIDOR";
                this.success = false;
                return mensagem;
            }
            else
            {
                Root dadosRetorno = new JsonDeserializer().Deserialize<Root>(restResponse);
                this.success = true;
                foreach (var item in dadosRetorno.Usuarios)
                {
                    nomeUser = item.nome_user;
                    senhaUser = item.senha_user;
                    perfilUser = item.perfil_user;
                }
            }
            return perfilUser;
        }
        #endregion


    }
}