using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lab05.BUS.BUSs.SinhVienBUS;

namespace Lab05.StudentManagement
{
    public partial class frmStudent : Form
    {

        private SinhVienBUS _sinhVienUseCase;
        public frmStudent()
        {
            InitializeComponent();
            _sinhVienUseCase = new SinhVienBUS();
        }
        void AddBinDing()
        {
            txtMSSV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MSSV"));
            txtHoTen.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HoTen"));
            txtDTB.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DiemTB"));
            cbKhoa.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Khoa"));
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _sinhVienUseCase.GetSinhViens();
            AddBinDing();
        }
        private void showAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                picture.Image= null;

            }
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                picture.Image = Image.FromFile(imagePath);
                picture.Refresh();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                dataGridView1.DataSource = _sinhVienUseCase.GetSinhViensChuaDangKyChuyenNganh();
            }
            else
            {
                dataGridView1.DataSource = _sinhVienUseCase.GetSinhViensDaDangKyChuyenNganh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {

                    string mssv = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    string UrlIamge = _sinhVienUseCase.GetImageByMSSV(mssv);
                    if (UrlIamge != "Không có")
                    {
                        showAvatar(UrlIamge);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkNull(string stuID, string stuName, string stuScore)
        {
            if (string.IsNullOrEmpty(stuID) || string.IsNullOrEmpty(stuName) ||
            string.IsNullOrEmpty(stuScore))
            {
                return false;
            }
            return true;
        }
        private bool kiemTraMSS(string stuID)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null && !string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == stuID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
