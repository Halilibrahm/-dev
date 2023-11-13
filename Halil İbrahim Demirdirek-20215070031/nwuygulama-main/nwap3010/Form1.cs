
using System.Data;
using System.Data.SqlClient;

namespace nwap3010
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlCommand cmdtedarik;

        string constr = "Data Source=DESKTOP-VGH8NJ9\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);

            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"insert into Urunler(UrunAdi,TedarikciID,KategoriID,BirimFiyati) " +
                $"values('{txturunad.Text.ToString()}',{cmbtedarik.SelectedValue},{cmbkategori.SelectedValue},{nupbirimfiyat.Value})";
            cmd.ExecuteNonQuery();
            con.Close();
            tazele();

        }


        private void tazele()
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Urunler order by " +
                "UrunID desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();


            //Kategori bilgileri cmbkategori combosuna aktarýlýyor
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select KategoriID,KategoriAdi from Kategoriler";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmbkategori.ValueMember = "KategoriID";
            cmbkategori.DisplayMember = "KategoriAdi";
            cmbkategori.DataSource = dt;


            //Tedarikçiler bilgileri cmbtedarik combosuna aktarýlýyor

            cmdtedarik = new SqlCommand();
            cmdtedarik.Connection = con;
            cmdtedarik.CommandText = "select TedarikciID,SirketAdi from Tedarikciler";
            cmdtedarik.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmdtedarik);
            da2.Fill(dt2);
            cmbtedarik.ValueMember = "TedarikciID";
            cmbtedarik.DisplayMember = "SirketAdi";
            cmbtedarik.DataSource = dt2;

            con.Close();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand verisil = new SqlCommand("Delete From Urunler Where UrunAdi = '" + txturunad.Text + "'", con);
            verisil.ExecuteNonQuery();
            con.Close();
            tazele();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand verigetir = new SqlCommand("Select* from Urunler where UrunAdi like'%" + txturunad.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(verigetir);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UrunID"].Value);

                string selectedProductName = dataGridView1.SelectedRows[0].Cells["UrunAdi"].Value.ToString();
                int selectedSupplierId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TedarikciID"].Value);
                int selectedCategoryId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KategoriID"].Value);
                decimal selectedUnitPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BirimFiyati"].Value);

                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT KategoriID, KategoriAdi FROM Kategoriler";
                cmd.ExecuteNonQuery();
                DataTable dtCategory = new DataTable();
                SqlDataAdapter daCategory = new SqlDataAdapter(cmd);
                daCategory.Fill(dtCategory);
                cmbkategori.ValueMember = "KategoriID";
                cmbkategori.DisplayMember = "KategoriAdi";
                cmbkategori.DataSource = dtCategory;

                cmdtedarik = new SqlCommand();
                cmdtedarik.Connection = con;
                cmdtedarik.CommandText = "SELECT TedarikciID, Sirketadi FROM Tedarikciler";
                cmdtedarik.ExecuteNonQuery();
                DataTable dtSupplier = new DataTable();
                SqlDataAdapter daSupplier = new SqlDataAdapter(cmdtedarik);
                daSupplier.Fill(dtSupplier);
                cmbtedarik.ValueMember = "TedarikciID";
                cmbtedarik.DisplayMember = "SirketAdi";
                cmbtedarik.DataSource = dtSupplier;
                con.Close();

                cmbkategori.SelectedValue = selectedCategoryId;
                cmbkategori.SelectedValue = selectedSupplierId;
                nupbirimfiyat.Value = selectedUnitPrice;
                txturunad.Text = selectedProductName;

                txturunad.Enabled = true;
                cmbkategori.Enabled = true;
                cmbtedarik.Enabled = true;
                nupbirimfiyat.Enabled = true;

                btnkaydet.Enabled = false;
                btnsil.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir satýr seçin.");
            }

        }

        private void btnspnkaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Urunekle";
            cmd.Parameters.AddWithValue("@vUrunAdi", txturunad.Text);
            cmd.Parameters.AddWithValue("@vTedarikciID", cmbtedarik.SelectedValue);
            cmd.Parameters.AddWithValue("@vKategoriID", cmbkategori.SelectedValue);
            cmd.Parameters.AddWithValue("@vBirimFiyati", nupbirimfiyat.Value);
            cmd.ExecuteNonQuery();

            con.Close();
            tazele();
        }

        private void btnspsil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UrunSil";
            cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value));

            cmd.ExecuteNonQuery();

            con.Close();
            tazele();
        }

        private void btnspara_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constr);
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Urunara";
            cmd.Parameters.AddWithValue("@vUrunadi", txturunad.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            //cmd.ExecuteNonQuery();



            con.Close();
        }

    }

}