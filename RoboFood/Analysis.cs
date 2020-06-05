using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RoboFood
{
    public partial class Analysis : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-V5K5AGM\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True";

        public Analysis()
        {
            InitializeComponent();
        }
        static long Fact(int n)
        {
            long x = 1;
            for (int i = 2; i <= n; i++)
                x *= i;
            return x;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            double y, n, u, r, p_0, p_n, p_q, L_q, L_s, W_q, W_s;

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader ExecuteScalarAsync = null;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Order");

            try
            {
                sqlReader = await command.ExecuteScalarAsync();
                y = Convert.ToDouble(sqlReader[""]);

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

            n = Convert.ToDouble(textBox_n.Text);
            //y
            y = Convert.ToDouble(textBox_Y.Text);
            //u
            u = Convert.ToDouble(textBox_u.Text);
            r = y / u;
            //r
            textBox_r.Text = Convert.ToString(Math.Round(r, 2));
            //p_0
            p_0 = 1.5;
            for (int i = 2; i <= n; i++)
            {
                p_0 += Math.Pow(r, i) / Fact(i);
            }
            p_0 += Math.Pow(r, n + 1) / (Fact(Convert.ToInt32(n)) * (n - 1));
            p_0 = 1.0 / p_0;
            textBox_p0.Text = Convert.ToString(Math.Round(p_0 * 100, 2)) + "%";
            //P_n
            p_n = Math.Pow(r, n) / Fact(Convert.ToInt32(n)) * p_0;
            textBox_pn.Text = Convert.ToString(Math.Round(p_n * 100, 2)) + "%";
            //P_q
            p_q = Math.Pow(r, n + 1) / (Fact(Convert.ToInt32(n)) * (n - r)) * p_0;
            textBox_pq.Text = Convert.ToString(Math.Round(p_q * 100, 2)) + "%";
            //L_q
            L_q = Math.Pow(r, n + 1) * p_0 / (n * Fact(Convert.ToInt32(n)) * Math.Pow((1.0 - r / n), 2));
            textBox_lq.Text = Convert.ToString(Math.Round(L_q, 2));
            //L_s
            L_s = L_q + r;
            textBox_ls.Text = Convert.ToString(Math.Round(L_s, 2));
            //W_q
            W_q = 1.0 / y * L_q;
            textBox_wq.Text = Convert.ToString(Math.Round(W_q, 2)) + " годин";
            //W_s
            W_s = 1.0 / y * L_s;
            textBox_ws.Text = Convert.ToString(Math.Round(W_s, 2)) + " годин";
            //conclusion
            if (p_0 < 0.0||n<r) textBox_conclusion.Text = "Функцiонування ресторану з такою кiлькiстю офiцiантiв не можливо!!!";
            else
            if (W_q < 0.01) textBox_conclusion.Text = "Для економiї грошей, рекомендуэмо зменшити кiлькiсть персоналу!";
            else
            if (p_q > 0.6) textBox_conclusion.Text = "З даною кількістю офіціантів відбувається повільне обслуговування клієнтів, потрібно підвищити їх кількість!";
            else textBox_conclusion.Text = "З даною кількістю офіціантів обслуговування клієнтів проходить на оптимальному рiвнi";
            await sqlConnection.CloseAsync();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
