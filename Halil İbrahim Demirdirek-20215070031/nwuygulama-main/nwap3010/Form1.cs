
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
    }

}