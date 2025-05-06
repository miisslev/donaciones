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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbMetodoPago.Items.AddRange(new string[] {
        "Transferencia bancaria",
        "Tarjeta de crédito",
        "Tarjeta de débito",
        "Criptomonedas",
        "PayPal",
        "Otro"
    });
            cmbMetodoPago.SelectedIndex = 0;
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDonar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMonto.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Ingrese un monto válido.");
                return;
            }

            string metodo = cmbMetodoPago.SelectedItem.ToString();
            bool anonima = chkAnonima.Checked;

            using (var conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Donaciones (monto, metodo_pago, anonima) VALUES (@monto, @metodo, @anonima)";
                    var cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@metodo", metodo);
                    cmd.Parameters.AddWithValue("@anonima", anonima);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("¡Donación registrada exitosamente!");
                    txtMonto.Clear();
                    chkAnonima.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la donación: " + ex.Message);
                }
            }
        }
        }
    }



