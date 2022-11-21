using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SzamlaGUI
{
    
    public partial class SzamlaGUI : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public SzamlaGUI()
        {
            InitializeComponent();
        }

        private void SzamlaGUI_Load(object sender, EventArgs e)
        {
            //Csatlakozunk az adatbázishoz
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                //terv szerint
                conn.Open();
                cmd = conn.CreateCommand();

            }
            catch (MySqlException ex)
            {
                //hiba esetén
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!", "Program hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            finally
            {
                //Terv és hiba esetén is
                conn.Close();

            }
            //Meghívjuk a ListBox frissítést
            Szamlak_ListBox_Update();

        }

        private void Szamlak_ListBox_Update()
        {
            //Frissíti a ListBox-ot
            Szamlak.Items.Clear();
            cmd.CommandText = "SELECT `id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum` FROM `szamlak` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    
                    SzamlakAdat uj = new SzamlakAdat(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetInt32("egyenleg"), dr.GetDateTime("nyitasdatum"));
                    Szamlak.Items.Add(uj);

                }

            }
            conn.Close();

        }

        private void HozzaadButton_Click(object sender, EventArgs e)
        {
            //Hozzáad az adatbázishoz
            if (nincsadat())
            {

                return;

            }
            cmd.CommandText = "INSERT INTO `szamlak` (`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (NULL, @tulnev, @egyenleg, @nyitdat)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tulnev", TulNevText.Text);
            cmd.Parameters.AddWithValue("@egyenleg", EgyenText.Text);
            cmd.Parameters.AddWithValue("@nyitdat", NyitDatPick.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Adatot sikeresen rögzítettük!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IDText.Text = "";
                    TulNevText.Text = "";
                    EgyenText.Text = "";
                    NyitDatPick.ResetText();


                }
                else
                {

                    MessageBox.Show("Adatot nem sikerült rögzíteni!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            conn.Close();
            Szamlak_ListBox_Update();

        }

        private bool nincsadat()
        {
            //Ellenőrzi hogy van-e adat
            if (string.IsNullOrEmpty(TulNevText.Text))
            {

                MessageBox.Show("Adjon meg egy Tulajdonos Nevét!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TulNevText.Focus();
                return true;

            }
            if (string.IsNullOrEmpty(EgyenText.Text))
            {

                MessageBox.Show("Adjon meg egy egyenleget!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EgyenText.Focus();
                return true;

            }
            return false;

        }

        private void TorolButton_Click(object sender, EventArgs e)
        {

            //Töröl az adatbázisból
            if (Szamlak.SelectedIndex < 0)
            {

                return;

            }
            cmd.CommandText = "DELETE FROM `szamlak` WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", IDText.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adat törlése sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                IDText.Text = "";
                TulNevText.Text = "";
                EgyenText.Text = "";
                NyitDatPick.ResetText();
                Szamlak_ListBox_Update();


            }
            else
            {

                MessageBox.Show("Az adat törlése sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (conn.State == ConnectionState.Open)
            {

                conn.Close();

            }

        }

        private void FrissitButton_Click(object sender, EventArgs e)
        {

            //Frissíti az adatbázisban
            if (Szamlak.SelectedIndex < 0)
            {

                MessageBox.Show("Nincsen kijelölve számla!", "Hiányzó jelölés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            SzamlakAdat kivalasztottSzamla = (SzamlakAdat)Szamlak.SelectedItem;
            cmd.CommandText = "UPDATE `szamlak` SET `tulajdonosNeve` = @tulnev, `egyenleg` = @egyenleg, `nyitasdatum`= @nyitdat WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", IDText.Text);
            cmd.Parameters.AddWithValue("@tulnev", TulNevText.Text);
            cmd.Parameters.AddWithValue("@egyenleg", EgyenText.Text);
            cmd.Parameters.AddWithValue("@nyitdat", NyitDatPick.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adatok módosítása sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                IDText.Text = "";
                TulNevText.Text = "";
                EgyenText.Text = "";
                NyitDatPick.ResetText();
                Szamlak_ListBox_Update();

            }
            else
            {

                MessageBox.Show("Az adatok módosítása sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (conn.State == ConnectionState.Open)
            {

                conn.Close();

            }

        }

        private void KivalasztButton_Click(object sender, EventArgs e)
        {

            //Kiválasztja az adatbázisból
            if (Szamlak.SelectedIndex < 0)
            {

                return;

            };
            //A felhasználó kijelöl egy elemet a listában.
            SzamlakAdat kivalasztottgyumolcs = (SzamlakAdat)Szamlak.SelectedItem;
            IDText.Text = kivalasztottgyumolcs.Id.ToString();
            TulNevText.Text = kivalasztottgyumolcs.Tulajnev;
            EgyenText.Text = kivalasztottgyumolcs.Egyenleg.ToString();
            NyitDatPick.Value = kivalasztottgyumolcs.Datum.Date;



        }

        private void EgyenText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Csak számokat fog elfogadni
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void KilepesButton_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }
    }
}
