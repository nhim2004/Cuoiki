using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace C_CuoiKi
{
    public partial class FormQLSP : Form
    {
        string connectstring = "Data Source=DESKTOP-OVN06OJ\\MSSQLSERVER02;Database=ShoeStoreDB;User ID=sa;Password = 123456789; TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dtb = new DataTable();
        private ImageHelper imageHelper;

        private int targetHeight = 200;
        private int currentHeight = 0;

        public FormQLSP()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
            loadData();
            dataGridView1.ReadOnly = true;

            groupBox2.Visible = false;
            buttonAdd.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonRefreshInfo.Visible = false;
            groupBox2.Height = currentHeight;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);

        }

        private void loadData()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from Products", con);
                adt = new SqlDataAdapter(cmd);

                dtb.Clear();
                adt.Fill(dtb);
                dataGridView1.DataSource = dtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int i = e.RowIndex;

                    textBox1.Text = dataGridView1.Rows[i].Cells[1].Value?.ToString();
                    textBox2.Text = dataGridView1.Rows[i].Cells[2].Value?.ToString();
                    textBox3.Text = dataGridView1.Rows[i].Cells[3].Value?.ToString();
                    textBox4.Text = dataGridView1.Rows[i].Cells[4].Value?.ToString();
                    textBox5.Text = dataGridView1.Rows[i].Cells[5].Value?.ToString();
                    textBox6.Text = dataGridView1.Rows[i].Cells[6].Value?.ToString();

                    string imagePath = dataGridView1.Rows[i].Cells[7].Value?.ToString();
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string imagePath = textBox7.Text;

                cmd = new SqlCommand("CreateProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                cmd.Parameters.AddWithValue("@Size", textBox3.Text);
                cmd.Parameters.AddWithValue("@Color", textBox4.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@StockQuantity", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sản phẩm thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string imagePath = dataGridView1.CurrentRow.Cells[7].Value?.ToString();

                int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                cmd = new SqlCommand("UPDATE Products SET Name = @Name, Description = @Description, Size = @Size, Color = @Color, Price = @Price, StockQuantity = @StockQuantity, ImagePath = @ImagePath WHERE ProductID = @ProductID", con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Description", textBox2.Text);
                cmd.Parameters.AddWithValue("@Size", textBox3.Text);
                cmd.Parameters.AddWithValue("@Color", textBox4.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@StockQuantity", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                cmd.Parameters.AddWithValue("@ProductID", productId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                    return;
                }

                int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @productId", con);
                        cmd.Parameters.AddWithValue("@productId", productId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        loadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void buttonRefreshInfo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            pictureBox1.Image = null;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            groupBox2.Visible = true;
            buttonDelete.Visible = true;
            buttonRefreshInfo.Visible = true;
            buttonAdd.Visible = true;
            buttonEdit.Visible = true;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentHeight < targetHeight)
            {
                currentHeight += 10;
                groupBox2.Height = currentHeight;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Chọn hình ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                textBox7.Text = imagePath;
            }
        }
    }
}
