using appRhIn.Classes;
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

namespace appRhIn.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconexao = "Data Source=DESKTOP-TCR9SDP\\SQLEXPRESS;Initial Catalog=RH;Integrated Security=True";
            string retorno = "";

            SqlCommand cmd = new SqlCommand();// comandos sql

            SqlConnection con = new SqlConnection(strconexao);

            con.Open();

            cmd.Connection = con;

            cmd.CommandText = "Select senha, id, nome from Usuario where cpf=@cpf";
            cmd.Parameters.AddWithValue("@cpf", this.textCPF.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (this.textBoxSenha.Text == "" || this.textCPF.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
            else
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        retorno = reader.GetString(0);
                        int id = reader.GetInt32(1);
                        string nome = reader.GetString(2);
                        string[] subs = nome.Split(' ');
                        if (retorno == this.textBoxSenha.Text)
                        {
                            UsuarioLogado.Instancia.Nome = subs[0];
                            UsuarioLogado.Instancia.Id = id;

                            //Home home = new Home();
                            //home.Show();

                            MasterForm form = new MasterForm();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Credenciais Invalidas");
                        }
                    }

                }
                else { MessageBox.Show("Usuario não localizado!"); }

                con.Close();
            }
        }
    }
}
