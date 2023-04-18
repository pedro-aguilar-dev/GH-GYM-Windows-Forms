using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Conexao con = new Conexao();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Obrigatório preencher");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Obrigatório preencher");
            }
            else
            {
                string nome = txtUsername.Text;
                string senha = txtPassword.Text;

                try
                {
                    string sql = "insert into usuario(username, senha) values(@username, @senha)";
                    SqlCommand cmd = new SqlCommand(sql, con.ConectarBD());
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = nome;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados cadastrados");
                    con.DesconectarBD();
                    Form2 login = new Form2();
                    login.ShowDialog();

                }
                catch
                {
                    MessageBox.Show("dados inválidos");
                }
            }
            {

            }
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}


