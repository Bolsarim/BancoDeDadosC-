using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=bd_pokemon;password=;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_pokemon (nome, tipo) VALUES (@nome, @tipo)", conn);

            //inserção no Banco de Dados
            cmd.Parameters.AddWithValue("@nome", textBoxNome.Text);
            cmd.Parameters.AddWithValue("@tipo", textBoxTipo.Text);

            //Abrindo Conexão
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            //Validando a Inserção de Dados
            if (rowsAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados. ");
            }

        }
    }
}
