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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        private void btnLogin_Click(object sender, EventArgs e)
        {
           

          

            try
            {
                string sql = "SELECT * FROM usuario WHERE username = @username and senha = @senha";
                SqlCommand sqlCommand = new SqlCommand(sql, con.ConectarBD());
                sqlCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text;
                sqlCommand.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtPassword.Text;
                //SqlCommand cmd = new SqlCommand(sql, con.ConectarBD());
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                   

                DataTable dtb = new DataTable();
                adapter.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                  

                    MessageBox.Show("Logado com sucesso");
                    //carregar a proxima pagina 
                    Form3 planos = new Form3();
                    planos.ShowDialog();

                }

                else
                {
                    MessageBox.Show("Login inválido");
                }


            }
            catch (Exception erro)
            {


                MessageBox.Show("Erro");

            }

        }

    }
}

