using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boost_C_Sharp_CRUD
{
    public partial class Form1 : Form
    {
        [Obsolete]
        SqlConnection cnx;
        List<Personne> personnes = new List<Personne>();
        public Form1()
        {
            InitializeComponent();
            cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vanilah\OneDrive\Documents\C#\Boost_C-Sharp_CRUD\Boost_C-Sharp_CRUD\Personne.mdf;Integrated Security=True");
            txtId.Visible = false;
            LoadPersonnes();
        }

        private void LoadPersonnes()
        {
            personnes.Clear();
            try
            {
                //cn.Open();
                cnx.Open();
                string query = "SELECT * FROM personne";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    personnes.Add(new Personne
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nom = reader["nom"].ToString(),
                        Prenom = reader["prenom"].ToString(),
                        Email = reader["email"].ToString(),
                        Telephone = reader["telephone"].ToString()
                    });
                }
                cnx.Close();

                dgvPersonne.DataSource = null;
                dgvPersonne.DataSource = personnes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Adresse email invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtTelephone.Text, @"^(032|033|034|039)\d{7}$"))
            {
                MessageBox.Show("Numéro de téléphone invalide. Format attendu : 0341234567", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearChamps()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                cnx.Open();
                string sql = "INSERT INTO personne (nom, prenom, email, telephone) VALUES (@nom, @prenom, @email, @telephone)";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                cmd.ExecuteNonQuery();
                cnx.Close();

                LoadPersonnes();
                ClearChamps();
                MessageBox.Show("Personne ajoutée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ClearChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.CurrentRow == null || !ValiderChamps()) return;

            var selectedPersonne = (Personne)dgvPersonne.CurrentRow.DataBoundItem;
            try
            {
                cnx.Open();
                string sql = "UPDATE personne SET nom=@nom, prenom=@prenom, email=@email, telephone=@telephone WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@id", selectedPersonne.Id);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                cmd.ExecuteNonQuery();
                cnx.Close();

                LoadPersonnes();
                ClearChamps();
                MessageBox.Show("Personne modifiée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.CurrentRow == null) return;

            var selectedPersonne = (Personne)dgvPersonne.CurrentRow.DataBoundItem;
            try
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette personne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cnx.Open();
                    string sql = "DELETE FROM personne WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@id", selectedPersonne.Id);
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    LoadPersonnes();
                    ClearChamps();
                    MessageBox.Show("Personne supprimée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void dgvPersonne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonne.CurrentRow != null)
            {
                var p = (Personne)dgvPersonne.CurrentRow.DataBoundItem;
                txtNom.Text = p.Nom;
                txtPrenom.Text = p.Prenom;
                txtEmail.Text = p.Email;
                txtTelephone.Text = p.Telephone;
            }
        }
    }
}
