using ElectroTransport.Classes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElectroTS {
    public partial class ElectroTransport : Form {
        public ElectroTransport() {
            InitializeComponent();
        }

        electroClass m = new electroClass();
        private void btnAdd_Click(object sender, EventArgs e) {
            if (nudTranportID.Text == "" || txtStart.Text == "" || txtFinish.Text == "" || txtInterval.Text == "" || txtStops.Text == "" || cmbType.Text == "") {
                MessageBox.Show("Заповніть усі поля та спробуйте ще раз.");
            } else {
                //Взяття даних з вхідних полів
            m.TransportID = Convert.ToInt32(nudTranportID.Text);
            m.Start = txtStart.Text;
            m.Finish = txtFinish.Text;
            m.Interval = txtInterval.Text;
            m.Stops = txtStops.Text;
            m.Type = cmbType.Text;

                //Запис даних в БД
                bool success = m.Insert(m);
                if (success == true) {
                    MessageBox.Show("Новий маршурт успішно додано!");
                    Clear();
                } else if (m.TransportID == Convert.ToInt32(nudTranportID.Text)) {
                    MessageBox.Show("Маршрут з таким номером вже записаний!");
                } else {
                    MessageBox.Show("Помилка при додаванні маршруту, спробуйте ще раз.");
                }
            }
            //Завантаження даних у Data GridView
            DataTable dt = m.Select();
            dgvContactList.DataSource = dt;
        }

        private void MarshrutDB_Load(object sender, EventArgs e) {
            //Завантаження даних у Data GridView
            DataTable dt = m.Select();
            dgvContactList.DataSource = dt;
        }

        //Метод для очищення полів
        public void Clear() {
            nudTranportID.Text = "";
            txtStart.Text = "";
            txtFinish.Text = "";
            txtInterval.Text = "";
            txtStops.Text = "";
            cmbType.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (nudTranportID.Text == "" || txtStart.Text == "" || txtFinish.Text == "" || txtInterval.Text == "" || txtStops.Text == "" || cmbType.Text == "") {
                MessageBox.Show("Виберіть маршрут або заповніть усі поля та спробуйте ще раз.");
            } else {
                //Взяття даних з вхідних полів
                m.TransportID = int.Parse(nudTranportID.Text);
                m.Start = txtStart.Text;
                m.Finish = txtFinish.Text;
                m.Interval = txtInterval.Text;
                m.Stops = txtStops.Text;
                m.Type = cmbType.Text;
            
         
                //Оновлення даних в БД
                bool success = m.Update(m);
                if (success == true) {
                    MessageBox.Show("Маршрут успішно оновлено!");
                    //Завантаження даних у Data GridView
                    DataTable dt = m.Select();
                    dgvContactList.DataSource = dt;
                    Clear();
                } else {
                    MessageBox.Show("Помилка при оновленні маршруту, спробуйте ще раз.");
                }
            }
        }

        private void dgvContactList_Click(object sender, DataGridViewCellMouseEventArgs e) {
            //Отримання даних з Dаta Grid View та завантаження їх в текстові поля
            //Ідентифікація рядка, на якому натискається миша
            int rowIndex = e.RowIndex;
            nudTranportID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtStart.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtFinish.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtInterval.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtStops.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbType.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (nudTranportID.Text == "" || txtStart.Text == "" || txtFinish.Text == "" || txtInterval.Text == "" || txtStops.Text == "" || cmbType.Text == "") {
                MessageBox.Show("Виберіть маршрут та спробуйте ще раз.");
            } else {
                //Отримання ID транспорту з програми
                m.TransportID = Convert.ToInt32(nudTranportID.Text);
                bool success = m.Delete(m);
                if (success == true) {
                    MessageBox.Show("Маршрут успішно видалено!");
                    //Оновлення Data GridView
                    //Завантаження даних у Data GridView
                    DataTable dt = m.Select();
                    dgvContactList.DataSource = dt;
                    Clear();
                } else {
                    MessageBox.Show("Помилка при видаленні маршруту, спробуйте ще раз.");
                }
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            //Взяття данх з текстового поля "Пошук"
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM table_marshrut WHERE TransportID LIKE '%" + keyword + "%' OR Start LIKE '%" + keyword + "%' OR Finish LIKE '%" + keyword + "%' OR Stops LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e) {
            btnClear.BackColor = System.Drawing.Color.Orange;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e) {
            btnClear.BackColor = System.Drawing.Color.Gold;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e) {
            btnAdd.BackColor = System.Drawing.Color.Green;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e) {
            btnAdd.BackColor = System.Drawing.Color.LimeGreen;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e) {
            btnUpdate.BackColor = System.Drawing.Color.Blue;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e) {
            btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e) {
            btnDelete.BackColor = System.Drawing.Color.Maroon;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e) {
            btnDelete.BackColor = System.Drawing.Color.Red;
        }

        private void btnHide_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            //this.Close();
            Application.Exit();
        }
    }
}