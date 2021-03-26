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


namespace FlappyBirb_Peli
{
    public partial class Kirjautuminen : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=flappybird");
        int i;
        public Kirjautuminen()
        {
            InitializeComponent();
        }

        private void ButtonKirjaudu_Click(object sender, EventArgs e)
        {
            
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where kayttajatunnus='"+txtkayttaja.Text+"' and salasana='"+txtsalasana.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            // Jos käyttäjätunnus tai salasana on virheellinen kirjautuessa
            if (i == 0)
            {
                txtvirheellinen.Text = "Virheellinen käyttäjätunnus tai salasana";
            }
            // Jos käyttäjätunnus ja salasana ovat oikein kirjautuessa
            else
            {
                // Piilota kirjautumis Form
                this.Hide();
                MainWindow Peli = new MainWindow();
                // Näytä Peli
                Peli.Show();
            }


            con.Close();
        }

        private void txtkayttaja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
