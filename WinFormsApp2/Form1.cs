namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.ToString() == "admin" && txtPassword.Text.ToString() == "admin")
            {
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
                this.Close();
            }
        }
    }
}