using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btNhom
{
    public partial class Menu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        //string str = "Data Source=LAPTOP-C7FI6G26\\MAYAO;Initial Catalog=QLQCC;Integrated Security=True";
        string str = "Data Source=.;Initial Catalog=BTNhom;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        void loaddata()
        {
            //////////////////////// NhaCungCap //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhaCungCap "; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvNhacc.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// MatHang //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select MaMH, TenMH, GiaMH, TenSz, SoLgTon from MatHang mh join LoaiSize ls on mh.MaSz = ls.MaSz "; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvMH.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// KhachHang //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from KhachHang"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvKH.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// NguyenLieu //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NguyenLieu"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvNL.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// CongThuc //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from CongThuc"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCT.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// Ca //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Ca"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCa.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// NhanVien//////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhanVien";
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvNhanVien.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// HoaDon//////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from HoaDon";
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvHoaDon.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// CTHDon//////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from CTHDon";
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCTHDon.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// LoaiSize //////////////////////////
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from LoaiSize"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvLoaisz.DataSource = table; // dgv lấy dữ liệu trong table
            //////////////////////// ThongKe //////////////////////////
            
        }
            public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTNhomDataSet6.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.bTNhomDataSet6.MatHang);
            // TODO: This line of code loads data into the 'bTNhomDataSet5.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.bTNhomDataSet5.HoaDon);
            // TODO: This line of code loads data into the 'bTNhomDataSet4.CTHDon' table. You can move, or remove it, as needed.
            this.cTHDonTableAdapter.Fill(this.bTNhomDataSet4.CTHDon);
            // TODO: This line of code loads data into the 'bTNhomDataSet3.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.bTNhomDataSet3.KhachHang);
            // TODO: This line of code loads data into the 'bTNhomDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.bTNhomDataSet2.NhanVien);
            // TODO: This line of code loads data into the 'bTNhomDataSet1.Ca' table. You can move, or remove it, as needed.
            this.caTableAdapter.Fill(this.bTNhomDataSet1.Ca);
            // TODO: This line of code loads data into the 'bTNhomDataSet.LoaiSize' table. You can move, or remove it, as needed.
            this.loaiSizeTableAdapter.Fill(this.bTNhomDataSet.LoaiSize);
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }
        //--------------------------------NHACUNGCAP---------------------------
        private void dgvNhacc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhacc.CurrentRow.Index;
            tbMancc.Text = dgvNhacc.Rows[i].Cells[0].Value.ToString();
            tbTenncc.Text = dgvNhacc.Rows[i].Cells[1].Value.ToString();
            tbDchincc.Text = dgvNhacc.Rows[i].Cells[2].Value.ToString();
            tbEmailncc.Text = dgvNhacc.Rows[i].Cells[3].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into NhaCungCap values ('" + tbMancc.Text + "', N'" + tbTenncc.Text + "', N'" + tbDchincc.Text + "', '" + tbEmailncc.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng ct
            cmd.CommandText = "delete from CongThuc where MaNL in (select MaNL from NguyenLieu where MaNCC in (select MaNCC from NhaCungCap where MaNCC = @MaNCC))";
            cmd.Parameters.AddWithValue("@MaNCC", tbMancc.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng Ncc
            cmd.CommandText = "delete from NguyenLieu where MaNCC in (select MaNCC from NhaCungCap where MaNCC = @MaNCC)";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng HoaDon
            cmd.CommandText = "delete from NhaCungCap where MaNCC = @MaNCC";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update NhaCungCap set TenNcc = '" + tbTenncc.Text + "', DiaChi = N'" + tbDchincc.Text + "', Email = '" + tbEmailncc.Text + "' where MaNcc = '" + tbMancc.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }
        private void btnKTncc_Click(object sender, EventArgs e)
        {
            tbMancc.Text = "";
            tbTenncc.Text = "";
            tbDchincc.Text = "";
            tbEmailncc.Text = "";
        }
        //------------------------------------------MATHANG--------------------------------

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select MaSz from LoaiSize WHERE TenSz = N'"+cbLoaisz.Text+"'";
            string LoaiSize = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    LoaiSize = reader["MaSz"].ToString();

                }
            }
            MessageBox.Show(LoaiSize);
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into MatHang values ('" + tbMaMH.Text + "', N'" + tbTenMH.Text + "', N'" + tbGiaMH.Text + "', '" + LoaiSize + "', '" + nudSoLgTon.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void dgvMH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //tbMaMH.ReadOnly = true;
            int i;
            i = dgvMH.CurrentRow.Index;
            tbMaMH.Text = dgvMH.Rows[i].Cells[0].Value.ToString();
            tbTenMH.Text = dgvMH.Rows[i].Cells[1].Value.ToString();
            tbGiaMH.Text = dgvMH.Rows[i].Cells[2].Value.ToString();
            cbLoaisz.Text = dgvMH.Rows[i].Cells[3].Value.ToString();
            nudSoLgTon.Text = dgvMH.Rows[i].Cells[4].Value.ToString();
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng ct
            cmd.CommandText = "delete from CongThuc where MaMH in (select MaMH from MatHang where MaMH = @MaMH)";
            cmd.Parameters.AddWithValue("@MaMH", tbMaMH.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng cthd
            cmd.CommandText = "delete from CTHDon where MaMH in (select MaMH from MatHang where MaMH = @MaMH)";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng mh
            cmd.CommandText = "delete from MatHang where MaMH = @MaMH";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }
        // loi
        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update MatHang set TenMH = N'" + tbTenMH.Text + "', GiaMH = '" + tbGiaMH.Text + "', MaSz = '" + cbLoaisz.Text + "', SoLgTon = '" + nudSoLgTon.Text + "' where MaMH = '" + tbMaMH.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }
        private void btnKTMH_Click(object sender, EventArgs e)
        {
            tbMaMH.Text = "";
            tbTenMH.Text = "";
            tbGiaMH.Text = "";
            cbLoaisz.Text = "";
            nudSoLgTon.Text = "";
        }
        //---------------------------------- KHACHHANG-----------------------
        private void dgvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            tbMaKH.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            tbHoKH.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            tbTenKH.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            tbDchiKH.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            tbSdtKH.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into KhachHang values ('" + tbMaKH.Text + "', N'" + tbHoKH.Text + "', N'" + tbTenKH.Text + "', N'" + tbDchiKH.Text + "', '" + tbSdtKH.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng CTHDon
            cmd.CommandText = "delete from CTHDon where MaHD in (select MaHD from HoaDon where MaKH = @MaKH)";
            cmd.Parameters.AddWithValue("@MaKH", tbMaKH.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng HoaDon
            cmd.CommandText = "delete from HoaDon where MaKH = @MaKH";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng KhachHang
            cmd.CommandText = "delete from KhachHang where MaKH = @MaKH";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update KhachHang set HoKH = N'" + tbHoKH.Text + "', TenKH = N'" + tbTenKH.Text + "', DiaChi = N'" + tbDchiKH.Text + "', Sdt = '" + tbSdtKH.Text + "' where MaKH = '" + tbMaKH.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();

        }

        private void btnKTKH_Click(object sender, EventArgs e)
        {
            tbMaKH.Text = "";
            tbHoKH.Text = "";
            tbTenKH.Text = "";
            tbDchiKH.Text = "";
            tbSdtKH.Text = "";
        }
        //---------------------------NGUYENLIEU--------------------
        private void dgvNL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNL.CurrentRow.Index;
            tbMaNL.Text = dgvNL.Rows[i].Cells[0].Value.ToString();
            tbTenNL.Text = dgvNL.Rows[i].Cells[1].Value.ToString();
            nudSoLg.Text = dgvNL.Rows[i].Cells[2].Value.ToString();
            tbDvt.Text = dgvNL.Rows[i].Cells[3].Value.ToString();
            tbMancc1.Text = dgvNL.Rows[i].Cells[4].Value.ToString();
        }
        private void btnThemNL_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into NguyenLieu values ('" + tbMaNL.Text + "', N'" + tbTenNL.Text + "', '" + nudSoLg.Text + "', N'" + tbDvt.Text + "', N'" + tbMancc1.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng ct
            cmd.CommandText = "delete from CongThuc where MaNL in (select MaNL from NguyenLieu where MaNL = @MaNL)";
            cmd.Parameters.AddWithValue("@MaNL", tbMaNL.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng nl
            cmd.CommandText = "delete from NguyenLieu where MaNL = @MaNL";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }

        private void btnSuaNL_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update NguyenLieu set TenNL = N'" + tbTenNL.Text + "', SoLuong = '" + nudSoLg.Text + "', DVT = '" + tbDvt.Text + "', MaNcc = '" + tbMancc1.Text + "' where MaNL = '" + tbMaNL.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnKTNL_Click(object sender, EventArgs e)
        {
            tbMaNL.Text = "";
            tbTenNL.Text = "";
            nudSoLg.Text = "";
            tbDvt.Text = "";
            tbMancc1.Text = "";
        }
        //---------------------------CONGTHUC--------------------------
        private void dgvCT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvCT.CurrentRow.Index;
            tbMaNL1.Text = dgvCT.Rows[i].Cells[0].Value.ToString();
            tbMaMH1.Text = dgvCT.Rows[i].Cells[1].Value.ToString();
            nudSoLgCT.Text = dgvCT.Rows[i].Cells[2].Value.ToString();
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into CongThuc values ('" + tbMaNL1.Text + "', N'" + tbMaMH1.Text + "', '" + nudSoLgCT.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from CongThuc where MaMH = '" + tbMaMH1.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update CongThuc set MaNl = '" + tbMaNL1.Text + "', SoLuong = '" + nudSoLgCT.Text + "' where MaMH = '" + tbMaMH1.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnKTCT_Click(object sender, EventArgs e)
        {
            tbMaNL1.Text = "";
            tbMaMH1.Text = "";
            nudSoLgCT.Text = "";
        }
        //---------------------------CA------------------------
        private void dgvCa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvCa.CurrentRow.Index;
            tbMaca.Text = dgvCa.Rows[i].Cells[0].Value.ToString();
            tbTenca.Text = dgvCa.Rows[i].Cells[1].Value.ToString();
            dtmBD.Text = dgvCa.Rows[i].Cells[2].Value.ToString();
            dtmKT.Text = dgvCa.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Ca values ('" + tbMaca.Text + "', N'" + tbTenca.Text + "', '" + dtmBD.Text + "', '" + dtmKT.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng CTHDon
            cmd.CommandText = "delete from CTHDon where MaHD in (select MaHD from HoaDon where MaNV in (select MaNV from NhanVien where MaCa = @MaCa))";
            cmd.Parameters.AddWithValue("@MaCa", tbMaca.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng HoaDon
            cmd.CommandText = "delete from HoaDon where MaNV in (select MaNV from NhanVien where MaCa = @MaCa)";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng nhanvien
            cmd.CommandText = "delete from NhanVien where MaNV in (select MaNV from NhanVien where MaCa = @MaCa)";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng ca
            cmd.CommandText = "delete from Ca where MaCa = @MaCa";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }

        private void btnSuaCa_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update Ca set TenCa = N'" + tbTenca.Text + "', TGBatDau = '" + dtmBD.Text + "', TGKetThuc = '" + dtmKT.Text + "' where MaCa = '" + tbMaca.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnKTCa_Click(object sender, EventArgs e)
        {
            tbMaca.Text = "";
            tbTenca.Text = "";
            dtmBD.Text = "";
            dtmKT.Text = "";
        }
        //-------------------Size-----------
        private void dgvLoaisz_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvLoaisz.CurrentRow.Index;
            tbMasz.Text = dgvLoaisz.Rows[i].Cells[0].Value.ToString();
            cbTenSz.Text = dgvLoaisz.Rows[i].Cells[1].Value.ToString();
            tbGiasz.Text = dgvLoaisz.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThemLsz_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into LoaiSize values ('" + tbMasz.Text + "', N'" + cbTenSz.Text + "', '" + tbGiasz.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaLsz_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng ct
            cmd.CommandText = "delete from CongThuc where MaMH in (select MaMH from MatHang where MaSz = @Masz)";
            cmd.Parameters.AddWithValue("@MaSz", tbMasz.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng cthd
            cmd.CommandText = "delete from CTHDon where MaMH in (select MaMH from MatHang where MaSz = @Masz)";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng mh
            cmd.CommandText = "delete from MatHang where MaSz = @Masz";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng mh
            cmd.CommandText = "delete from LoaiSize where MaSz = @Masz";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }

        private void btnSuaLsz_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update LoaiSize set TenSz = N'" + cbTenSz.Text + "', GiaSz = '" + tbGiasz.Text + "' where MaSz = '" + tbMasz.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnKTLsz_Click(object sender, EventArgs e)
        {
            tbMasz.Text = "";
            cbTenSz.Text = "";
            tbGiasz.Text = "";
        }
        

        //-------------------NhanVien-----------

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into NhanVien values ('" + tbManv.Text + "', N'" + tbHonv.Text + "', N'" + tbTennv.Text + "', '" + dtmvl.Text + "', N'" + cbPhai.Text + "', '" + tbSdtnv.Text + "', '" + cbMaca.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update NhanVien set HoNV=N'" + tbHonv.Text + "', TenNV = N'" + tbTennv.Text + "', NgayVaoLam = '" + dtmvl.Text + "', Phai = N'" + cbPhai.Text + "', Sdt = '" + tbSdtnv.Text + "', MaCa = '" + cbMaca.Text + "' where MaNV = '" + tbManv.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null; // Khai báo biến transaction
            // Mở kết nối đến CSDL
            con.Close();
            con.Open();

            // Bắt đầu giao dịch
            transaction = con.BeginTransaction();
            cmd = con.CreateCommand();
            cmd.Transaction = transaction;

            // Xóa dữ liệu trong bảng CTHDon
            cmd.CommandText = "delete from CTHDon where MaHD in (select MaHD from HoaDon where MaNV = @MaNV)";
            cmd.Parameters.AddWithValue("@MaNV", tbManv.Text);
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng HoaDon
            cmd.CommandText = "delete from HoaDon where MaNV = @MaNV";
            cmd.ExecuteNonQuery();

            // Xóa dữ liệu trong bảng nhanvien
            cmd.CommandText = "delete from NhanVien where MaNV = @MaNV";
            cmd.ExecuteNonQuery();

            // Hoàn tất giao dịch
            transaction.Commit();

            // Đóng kết nối đến CSDL
            con.Close();

            // Reload dữ liệu
            loaddata();
        }
        private void btKTNV_Click(object sender, EventArgs e)
        {
            tbManv.Text = "";
            tbHonv.Text = "";
            tbTennv.Text = "";
            dtmvl.Text = "";
            cbPhai.Text = "";
            tbSdtnv.Text = "";
            cbMaca.Text = "";
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            tbManv.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            tbHonv.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            tbTennv.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            dtmvl.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            cbPhai.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            tbSdtnv.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            cbMaca.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
        }
        //-------------------HoaDon-----------

        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvHoaDon.CurrentRow.Index;
            tbMahd.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
            tbMKH.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
            tbMNV.Text = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
            dtmNL.Text = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into HoaDon values ('" + tbMahd.Text + "', '" + tbMKH.Text + "', '" + tbMNV.Text + "', '" + dtmNL.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from HoaDon where MaHD = '" + tbMahd.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update HoaDon set MaKH='" + tbMKH.Text + "', MaNV = '" + tbMNV.Text + "', NgayLap = '" + dtmNL.Text + "' where MaNV = '" + tbMNV.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnKTHD_Click(object sender, EventArgs e)
        {
            tbMahd.Text = "";
            tbMKH.Text = "";
            tbMNV.Text = "";
            dtmNL.Text = "";
        }


        //-------------------ctHoaDon-----------

        private void dgvCTHDon_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvCTHDon.CurrentRow.Index;
            cbMHD.Text = dgvCTHDon.Rows[i].Cells[0].Value.ToString();
            cbMMH.Text = dgvCTHDon.Rows[i].Cells[1].Value.ToString();
            nudSoLgHD.Text = dgvCTHDon.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into CTHDon values ('" + cbMHD.Text + "', '" + cbMMH.Text + "', '" + nudSoLgHD.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from CTHDon where MaHD = '" + cbMHD.Text + "'and MaMH = '" + cbMMH.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "update CTHDon set SoLuong='" + nudSoLgHD.Text + "' where MaHD = '" + cbMHD.Text + "'and MaMH = '" + cbMMH.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
        }

        private void btnKTCTHD_Click(object sender, EventArgs e)
        {
            cbMHD.Text = "";
            cbMMH.Text = "";
            nudSoLgHD.Text = "";
        }





        //----------------------THONGKE------------
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //DateTime nl1 = DateTime.ParseExact(dtmBDTKe.Text, "mm/dd/yyyy", CultureInfo.InvariantCulture);
            //string nl1_sql = nl1.ToString("yyyy-MM-dd");
            //DateTime nl2 = DateTime.ParseExact(dtmKTTKe.Text, "mm/dd/yyyy", CultureInfo.InvariantCulture);
            //string nl2_sql = nl2.ToString("yyyy-MM-dd");
            cmd = con.CreateCommand();
            cmd.CommandText = "select ct.MaHD, MaKH, MaNV, MaMH, NgayLap, SoLuong from HoaDon hd join CTHDon ct on hd.MaHD = ct.MaHD where NgayLap between '"+dtmBDTKe.Text+"' and '"+dtmKTTKe.Text+"'";
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvBaoCao.DataSource = table; // dgv lấy dữ liệu trong table
            DateTime selectedDate = dtmBDTKe.Value; // chọn ngày datetimengay dd//mm//yyyy
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            DateTime selectedDate1 = dtmKTTKe.Value;
            int year1 = selectedDate1.Year; // chọn ra năm
            int month1 = selectedDate1.Month;
            int day1 = selectedDate1.Day;
            day1++;
            cmd = con.CreateCommand();
            cmd.CommandText = "select sum(SoLuong) as TongSl from HoaDon hd join CTHDon ct on hd.MaHD = ct.MaHD where NgayLap between '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    tbTongSoLg.Text = reader["TongSl"].ToString();

                }
            }

            cmd = con.CreateCommand();
            cmd.CommandText = "select sum(SoLuong*(GiaMH + GiaSz)) as ThanhTien from HoaDon hd join CTHDon ct on hd.MaHD = ct.MaHD join MatHang mh on mh.MaMH = ct.MaMH join LoaiSize ls on ls.MaSz = mh.MaSz where NgayLap between '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    tbTongTien.Text = reader["ThanhTien"].ToString();

                }
            }
        }

        //--------------------------------TRUYVAN-----------------------------------------
        private void tbTimKH_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from KhachHang where MaKH like N'%" + tbTimKH.Text + "%' or HoKH like N'%" + tbTimKH.Text + "%' or DiaChi like N'%" + tbTimKH.Text + "%' or Sdt like N'%" + tbTimKH.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvKH.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimCa_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Ca where MaCa like '%" + tbTimCa.Text + "%' or TenCa like N'%" + tbTimCa.Text + "%' or TGBatDau like '%" + tbTimCa.Text + "%' or TGKetThuc like '%" + tbTimCa.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCa.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimLSz_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from LoaiSize where MaSz like '%" + tbTimLSz.Text + "%' or TenSz like N'%" + tbTimLSz.Text + "%' or GiaSz like N'%" + tbTimLSz.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvLoaisz.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimncc_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhaCungCap where MaNcc like '%" + tbTimncc.Text + "%' or TenNcc like N'%" + tbTimncc.Text + "%' or DiaChi like N'%" + tbTimncc.Text + "%' or Email like '%" + tbTimncc.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvNhacc.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimMH_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from MatHang where MaMH like '%" + tbTimMH.Text + "%' or TenMh like N'%" + tbTimMH.Text + "%' or GiaMH like N'%" + tbTimMH.Text + "%' or MaSz like '%" + tbTimMH.Text + "%' or SoLgTon like '%" + tbTimMH.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvMH.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimNL_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NguyenLieu where MaNL like '%" + tbTimNL.Text + "%' or TenNL like N'%" + tbTimNL.Text + "%' or SoLuong like N'%" + tbTimNL.Text + "%' or DVT like '%" + tbTimNL.Text + "%' or Mancc like '%" + tbTimNL.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvNL.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimCT_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from CongThuc where MaNL like '%" + tbTimCT.Text + "%' or MaMH like N'%" + tbTimCT.Text + "%' or SoLuong like N'%" + tbTimCT.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCT.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimNV_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhanVien where MaNV like '%" + tbTimNV.Text + "%' or HoNV like N'%" + tbTimNV.Text + "%' or TenNV like N'%" + tbTimNV.Text + "%' or NgayVaoLam like '%" + tbTimNV.Text + "%' or Phai like N'%" + tbTimNV.Text + "%' or Sdt like N'%" + tbTimNV.Text + "%' or MaCa like N'%" + tbTimNV.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvNhanVien.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimHD_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from HoaDon where MaHD like '%" + tbTimHD.Text + "%' or MaKH like N'%" + tbTimHD.Text + "%' or MaNV like N'%" + tbTimHD.Text + "%' or format(NgayLap, 'MM/dd/yyyy') like '%" + tbTimHD.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvHoaDon.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimCTHD_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from CTHDon where MaHD like '%" + tbTimCTHD.Text + "%' or MaMH like N'%" + tbTimCTHD.Text + "%' or SoLuong like N'%" + tbTimCTHD.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCTHDon.DataSource = table; // dgv lấy dữ liệu trong table
        }

        private void tbTimTK_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select ct.MaHD, MaKH, MaNV, MaMH, NgayLap, SoLuong from HoaDon hd join CTHDon ct on hd.MaHD = ct.MaHD where MaHD like '%" + tbTimTK.Text + "%' or MaMH like N'%" + tbTimTK.Text + "%' or SoLuong like N'%" + tbTimTK.Text + "%' or MaKH like N'%" + tbTimTK.Text + "%' or MaNV like N'%" + tbTimTK.Text + "%' or NgayLap like N'%" + tbTimTK.Text + "%'"; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            //table.Clear(); // xóa cho sạch, không có cũng được
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvCTHDon.DataSource = table; // dgv lấy dữ liệu trong table
        }
    }
}
