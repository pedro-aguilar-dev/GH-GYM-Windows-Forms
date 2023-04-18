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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        Conexao con = new Conexao();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomePlano.Text == "")
            {
                MessageBox.Show("Obrigatório preencher");
            }
            else if (txtDesc.Text == "")
            {
                MessageBox.Show("Obrigatório preencher");
            }

            else if (txtPreco.Text == "")
            {
                MessageBox.Show("Obrigatório preencher");
            }
            else
            {
                string nomePlano = txtNomePlano.Text;
                string desc = txtDesc.Text;
                string preco = txtPreco.Text;

                try
                {
                    string sql = "insert into plano(nome,descricao, preco) values(@nome, @desc, @preco)";
                    SqlCommand cmd = new SqlCommand(sql, con.ConectarBD());
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomePlano;
                    cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
                    cmd.Parameters.Add("@preco", SqlDbType.VarChar).Value = preco;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados cadastrados");
                    con.DesconectarBD();


                }
                catch
                {
                    MessageBox.Show("dados inválidos");
                }
            }
            {
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

}
