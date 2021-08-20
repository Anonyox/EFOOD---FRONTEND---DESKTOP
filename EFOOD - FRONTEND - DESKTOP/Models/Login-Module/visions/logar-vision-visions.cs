using System;
using System.Windows.Forms;
using EFOOD___FRONTEND___DESKTOP.Models.Login_Module.services;
using EFOOD___FRONTEND___DESKTOP.Models.Menu_Module.visions;

namespace EFOOD___FRONTEND___DESKTOP.Models.Login_Module.visions
{
    public partial class logar_vision : Form
    {


        #region VARIÁVEIS E REFERÊNCIAS
        login_service_services service = new login_service_services();

        menuPrincipalAdmins_vision menu_admins = new menuPrincipalAdmins_vision();
        #endregion


        #region CONSTRUTOR
        public logar_vision()
        {
            InitializeComponent();
        }
        #endregion


        #region MÉTODOS DE FUNCIONALIDADES
        private void consultarLogin()
        {
            menuPrincipalUsers_vision menu_usuarios = new menuPrincipalUsers_vision(txtUserName.Text);
            string perfil = service.consultarLogin(txtUserName.Text, txtPassword.Text);
           
            if (service.success && perfil == "user")
            {
                this.Hide();
                menu_usuarios.ShowDialog();
            }
            else if (service.success && perfil == "admin")
            {
                this.Hide();
                menu_admins.ShowDialog();
            }
            else
                MessageBox.Show(service.mensagem);
        }
        #endregion


        #region DESIGN
        private void btnLogar_Click(object sender, System.EventArgs e)
        {
            consultarLogin();
        }
        #endregion


    }
}