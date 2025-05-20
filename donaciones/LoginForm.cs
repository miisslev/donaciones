using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace donaciones
{
    public partial class LoginForm : Form
    {
        private string conexion;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string connStr = "server=localhost;user=root;password=michelle;database=donaciones;";
                string queryLogin = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña";

                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre AND contrasena = @contrasena";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombre", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtContraseña.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            Form1 principal = new Form1();
                            principal.Show();
                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.ShowDialog();
        }
    }
}



