using System;

namespace ElectroTS
{
    partial class ElectroTransport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTransportID = new System.Windows.Forms.Label();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStops = new System.Windows.Forms.TextBox();
            this.lblStops = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.nudTranportID = new System.Windows.Forms.NumericUpDown();
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranportID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransportID
            // 
            this.lblTransportID.AutoSize = true;
            this.lblTransportID.BackColor = System.Drawing.Color.Transparent;
            this.lblTransportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransportID.Location = new System.Drawing.Point(59, 115);
            this.lblTransportID.Name = "lblTransportID";
            this.lblTransportID.Size = new System.Drawing.Size(150, 20);
            this.lblTransportID.TabIndex = 1;
            this.lblTransportID.Text = "Номер транспорту";
            // 
            // txtFinish
            // 
            this.txtFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinish.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFinish.Location = new System.Drawing.Point(221, 177);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(201, 26);
            this.txtFinish.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtFinish, "Введіть кінцеву зупинку");
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(59, 180);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(136, 20);
            this.lblFinish.TabIndex = 3;
            this.lblFinish.Text = "Кінець маршруту";
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInterval.Location = new System.Drawing.Point(221, 209);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(201, 26);
            this.txtInterval.TabIndex = 6;
            this.toolTip.SetToolTip(this.txtInterval, "Введіть інтервал руху");
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.BackColor = System.Drawing.Color.Transparent;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(59, 212);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(112, 20);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "Інтервал руху";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStart.Location = new System.Drawing.Point(221, 145);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(201, 26);
            this.txtStart.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtStart, "Введіть початкову зупинку");
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(59, 148);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(152, 20);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Початок маршруту";
            // 
            // txtStops
            // 
            this.txtStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStops.Location = new System.Drawing.Point(221, 241);
            this.txtStops.Multiline = true;
            this.txtStops.Name = "txtStops";
            this.txtStops.Size = new System.Drawing.Size(201, 169);
            this.txtStops.TabIndex = 10;
            this.toolTip.SetToolTip(this.txtStops, "Введіть зупинки маршруту");
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.lblStops.BackColor = System.Drawing.Color.Transparent;
            this.lblStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStops.Location = new System.Drawing.Point(59, 244);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(71, 20);
            this.lblStops.TabIndex = 9;
            this.lblStops.Text = "Зупинки";
            // 
            // cmbType
            // 
            this.cmbType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Тролейбус",
            "Трамвай"});
            this.cmbType.Location = new System.Drawing.Point(221, 416);
            this.cmbType.MaxDropDownItems = 3;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(201, 28);
            this.cmbType.TabIndex = 11;
            this.toolTip.SetToolTip(this.cmbType, "Оберіть тип електричного транспорту");
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(59, 419);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(127, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Тип транспорту";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(603, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Додати";
            this.toolTip.SetToolTip(this.btnAdd, "Натисніть, щоб додати новий маршрут");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(810, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 41);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Оновити";
            this.toolTip.SetToolTip(this.btnUpdate, "Натисніть, щоб оновити доданий маршрут");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(257, 474);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистити";
            this.toolTip.SetToolTip(this.btnClear, "Натисніть, щоб очистити текстові поля");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1016, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Видалити";
            this.toolTip.SetToolTip(this.btnDelete, "Натисніть, щоб видалити доданий маршрут");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(553, 151);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(640, 288);
            this.dgvContactList.TabIndex = 17;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Пошук";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(613, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(580, 26);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLogo.Location = new System.Drawing.Point(115, 62);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(1001, 36);
            this.lblLogo.TabIndex = 20;
            this.lblLogo.Text = "ДОВІДНИК РУХУ ЕЛЕКТРИЧНОГО ТРАНСПОРТУ МІСТА ЛЬВОВА";
            // 
            // nudTranportID
            // 
            this.nudTranportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTranportID.Location = new System.Drawing.Point(221, 113);
            this.nudTranportID.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.nudTranportID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTranportID.Name = "nudTranportID";
            this.nudTranportID.Size = new System.Drawing.Size(201, 26);
            this.nudTranportID.TabIndex = 21;
            this.toolTip.SetToolTip(this.nudTranportID, "Введіть номер транспорту");
            this.nudTranportID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.Location = new System.Drawing.Point(1139, 542);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(102, 15);
            this.lblVersion.TabIndex = 22;
            this.lblVersion.Text = "Бета-версія 0.06";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Підказка";
            // 
            // ElectroTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 566);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.nudTranportID);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtStops);
            this.Controls.Add(this.lblStops);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblTransportID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ElectroTransport";
            this.Text = "Довідник руху електричного транспорту м. Львова";
            this.Load += new System.EventHandler(this.MarshrutDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranportID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Label lblTransportID;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStops;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.NumericUpDown nudTranportID;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

