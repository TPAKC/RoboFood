using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RoboFood
{
    public partial class Waiter : Form
    {
        string connectionString = @"Data Source=DESKTOP-V5K5AGM\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True";

        public Waiter()
        {
            InitializeComponent();
        }
        
        public async void Updates()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM Table WHERE Status = 'Очiкують замолвлення'");

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                int i = 0;
                while (await sqlReader.ReadAsync())
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[i].Cells[0].Value = Convert.ToString(sqlReader["Name"]);
                    dataGridView.Rows[i].Cells[1].Value = Convert.ToString(sqlReader["WaiterName"]);
                    dataGridView.Rows[i].Cells[2].Value = Convert.ToString(sqlReader["OrderTime"]);
                    dataGridView.Rows[i].Cells[3].Value = Convert.ToString(sqlReader["NumberOrder"]);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxStatus.Text)
            {

                case "Вiльний":
                    {
                        comboBoxWaiter.Visible = false;
                        labelWaiter.Visible = false;
                        textBoxOrderNumber.Visible = false;
                        labelOrderNumber.Visible = false;
                        textBoxTime.Visible = false;
                        labelTime.Visible = false;
                        break;
                    }
                case "Очiкують замолвлення":
                    {
                        comboBoxWaiter.Visible = true;
                        labelWaiter.Visible = true;
                        textBoxOrderNumber.Visible = true;
                        labelOrderNumber.Visible = true;
                        textBoxTime.Visible = false;
                        labelTime.Visible = false;
                        break;
                    }
                case "Зайнятий":
                    {
                        comboBoxWaiter.Visible = true;
                        labelWaiter.Visible = true;
                        textBoxOrderNumber.Visible = false;
                        labelOrderNumber.Visible = false;
                        textBoxTime.Visible = false;
                        labelTime.Visible = false;
                        break;
                    }
                case "Потрiбно прибирання":
                    {
                        comboBoxWaiter.Visible = true;
                        labelWaiter.Visible = true;
                        textBoxOrderNumber.Visible = false;
                        labelOrderNumber.Visible = false;
                        textBoxTime.Visible = false;
                        labelTime.Visible = false;
                        break;
                    }
                case "Заброньовано":
                    {
                        comboBoxWaiter.Visible = false;
                        labelWaiter.Visible = false;
                        textBoxOrderNumber.Visible = false;
                        labelOrderNumber.Visible = false;
                        textBoxTime.Visible = true;
                        labelTime.Visible = true;
                        break;
                    }
            }
        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            Updates();
        }
    }
}
