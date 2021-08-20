using System;
using System.Windows.Forms;
using EFOOD___FRONTEND___DESKTOP.Models.Menu_Module.services;
using EFOOD___FRONTEND___DESKTOP.Models.Login_Module.visions;
using static EFOOD___FRONTEND___DESKTOP.Models.Login_Module.visions.logar_vision;

namespace EFOOD___FRONTEND___DESKTOP.Models.Menu_Module.visions
{
    public partial class menuPrincipalUsers_vision : Form
    {


        #region VARIÁVEIS E INSTÂNCIAS
   
        #endregion


        #region CONSTRUTOR
        public menuPrincipalUsers_vision(string usuario)
        {
            InitializeComponent();
            lblUsuarioLogado.Text = usuario.ToString();
        }
        #endregion


        #region MÉTODOS DE FUNCIONALIDADES
        #endregion


        #region DESIGN
        private void btnFechar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void btnHome_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            //controlHome.BringToFront();
        }
        private void btnPedidos_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnPedidos.Height;
            SidePanel.Top = btnPedidos.Top;
            //controlPedidos1.BringToFront();
        }
        private void btnEntregas_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnEntregas.Height;
            SidePanel.Top = btnEntregas.Top;
            //controlEntregas1.BringToFront();
        }
        private void btnDeslogar_Click(object sender, System.EventArgs e)
        {
            logar_vision login = new logar_vision();
            this.Hide();
            login.ShowDialog();
        }
        private void temporizador_Tick(object sender, System.EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
    #endregion


}