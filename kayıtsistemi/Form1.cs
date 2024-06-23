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

namespace kayıtsistemi
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;Database=ogrenci;Uid=root;pwd='hasan1278';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select * from new_table",conn);
            adapter.Fill(dt);
            dgvliste.DataSource = dt;
            conn.Close();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void dgvliste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtno.Text = dgvliste.CurrentRow.Cells[0].Value.ToString();
            txtadı.Text = dgvliste.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dgvliste.CurrentRow.Cells[2].Value.ToString();
            dtdogumtarihi.Text = dgvliste.CurrentRow.Cells[3].Value.ToString();
            cmbsınıf.Text = dgvliste.CurrentRow.Cells[4].Value.ToString();
            txtpuan.Text = dgvliste.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO new_table(no,adı,soyadı,tarih,sinif,puan)"+
                "VALUES(@numara,@AD,@SOYAD,@TARİH,@SINIF,@PUAN)";
            cmd = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@numara",txtno.Text);
            cmd.Parameters.AddWithValue("@AD",txtadı.Text);
            cmd.Parameters.AddWithValue("@SOYAD",txtsoyad.Text);
            cmd.Parameters.AddWithValue("@TARİH", dtdogumtarihi.Value);
            cmd.Parameters.AddWithValue("@SINIF", cmbsınıf.Text);
            cmd.Parameters.AddWithValue("@PUAN", txtpuan.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("kayıt başarılı!!!");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM new_table WHERE no=@numara";
            cmd = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@numara",txtno.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("kayıt silindi!!!");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE new_table " +
                "SET adı= @AD,soyadı=@SOYAD,tarih=@TARİH,sinif=@SINIF,puan=@PUAN " +
                "WHERE no=@numara";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@numara", txtno.Text);
            cmd.Parameters.AddWithValue("@AD", txtadı.Text);
            cmd.Parameters.AddWithValue("@SOYAD", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@TARİH", dtdogumtarihi.Value);
            cmd.Parameters.AddWithValue("@SINIF", cmbsınıf.Text);
            cmd.Parameters.AddWithValue("@PUAN", txtpuan.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("kayıt güncelleme başarılı!!!");
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "adı LIKE '" + txtadı.Text + "%'";
            dgvliste.DataSource = dv;
        }
    }
}
