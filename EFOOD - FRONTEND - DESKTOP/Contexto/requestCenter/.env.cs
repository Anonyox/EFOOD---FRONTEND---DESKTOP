namespace EFOOD___FRONTEND___DESKTOP.contexto.requestCenter
{
    public class dotEnv
    {
        private string HTTP = "http://localhost:"; //ENDEREÇO ONDE ESTÁ ALOCADO A API
        public string getHTTP()
        {
            return this.HTTP;
        }

        private string PORT = "3000"; //PORTA DE ACESSO ONDE ESTÁ ALOCADO A API
        public string getPORT()
        {
            return this.PORT;
        }

        private string ROUTEPRIMARY = "/"; //INSERIR O "/" LOGO APÓS DE COLOCAR O ENDEREÇO E A PORTA AUTOMÁTICO
        public string getROUTEPRIMARY()
        {
            return this.ROUTEPRIMARY;
        }
    }
}
