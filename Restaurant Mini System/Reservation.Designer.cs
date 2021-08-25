namespace Restaurant_Mini_System
{
    partial class Reservation
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.monCal = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.cmbMidday = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dbReserveDataSet = new Restaurant_Mini_System.dbReserveDataSet();
            this.tblAccInfoTableAdapter = new Restaurant_Mini_System.dbReserveDataSetTableAdapters.tblAccInfoTableAdapter();
            this.tblReservationTableAdapter = new Restaurant_Mini_System.dbReserveDataSetTableAdapters.tblReservationTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbReserveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(639, 427);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.txtFirst);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtMiddle);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtSur);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtContact);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(350, 258);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Enabled = false;
            this.txtFirst.Location = new System.Drawing.Point(123, 25);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(3, 25, 25, 3);
            this.txtFirst.MaxLength = 30;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(200, 29);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 28, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname:";
            // 
            // txtMiddle
            // 
            this.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddle.Enabled = false;
            this.txtMiddle.Location = new System.Drawing.Point(123, 72);
            this.txtMiddle.Margin = new System.Windows.Forms.Padding(3, 15, 25, 3);
            this.txtMiddle.MaxLength = 20;
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(200, 29);
            this.txtMiddle.TabIndex = 4;
            this.txtMiddle.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 18, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middlename:";
            // 
            // txtSur
            // 
            this.txtSur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSur.Enabled = false;
            this.txtSur.Location = new System.Drawing.Point(123, 161);
            this.txtSur.Margin = new System.Windows.Forms.Padding(3, 15, 25, 3);
            this.txtSur.MaxLength = 30;
            this.txtSur.Name = "txtSur";
            this.txtSur.Size = new System.Drawing.Size(200, 29);
            this.txtSur.TabIndex = 2;
            this.txtSur.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(123, 208);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 15, 25, 3);
            this.txtContact.MaxLength = 30;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 29);
            this.txtContact.TabIndex = 3;
            this.txtContact.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 18, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contact No.:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(87, 255);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 15, 25, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(223, 313);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 15, 15, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.monCal);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(359, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(277, 258);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(25, 28, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of Reservation:";
            // 
            // monCal
            // 
            this.monCal.Location = new System.Drawing.Point(25, 77);
            this.monCal.Margin = new System.Windows.Forms.Padding(25, 25, 9, 9);
            this.monCal.MaxSelectionCount = 1;
            this.monCal.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monCal.Name = "monCal";
            this.monCal.TabIndex = 7;
            this.monCal.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.txtPax);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.cmbHours);
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.flowLayoutPanel4.Controls.Add(this.cmbMinutes);
            this.flowLayoutPanel4.Controls.Add(this.cmbMidday);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 267);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(633, 78);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(25, 28, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "No. of Persons:";
            // 
            // txtPax
            // 
            this.txtPax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPax.Location = new System.Drawing.Point(177, 25);
            this.txtPax.Margin = new System.Windows.Forms.Padding(10, 25, 3, 3);
            this.txtPax.MaxLength = 3;
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(70, 29);
            this.txtPax.TabIndex = 8;
            this.txtPax.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(66, 28, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time:";
            // 
            // cmbHours
            // 
            this.cmbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Location = new System.Drawing.Point(387, 25);
            this.cmbHours.Margin = new System.Windows.Forms.Padding(10, 25, 3, 3);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(50, 32);
            this.cmbHours.TabIndex = 9;
            this.cmbHours.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 28, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Location = new System.Drawing.Point(458, 25);
            this.cmbMinutes.Margin = new System.Windows.Forms.Padding(0, 25, 3, 3);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(70, 32);
            this.cmbMinutes.TabIndex = 10;
            this.cmbMinutes.TabStop = false;
            // 
            // cmbMidday
            // 
            this.cmbMidday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMidday.FormattingEnabled = true;
            this.cmbMidday.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cmbMidday.Location = new System.Drawing.Point(531, 25);
            this.cmbMidday.Margin = new System.Windows.Forms.Padding(0, 25, 3, 3);
            this.cmbMidday.Name = "cmbMidday";
            this.cmbMidday.Size = new System.Drawing.Size(70, 32);
            this.cmbMidday.TabIndex = 11;
            this.cmbMidday.TabStop = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel5.Controls.Add(this.btnReserve);
            this.flowLayoutPanel5.Controls.Add(this.txtSummary);
            this.flowLayoutPanel5.Controls.Add(this.label9);
            this.flowLayoutPanel5.Controls.Add(this.btnContinue);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 351);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(633, 73);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Location = new System.Drawing.Point(476, 10);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 10, 25, 3);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(130, 50);
            this.btnReserve.TabIndex = 17;
            this.btnReserve.TabStop = false;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click_1);
            // 
            // txtSummary
            // 
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummary.Enabled = false;
            this.txtSummary.Location = new System.Drawing.Point(253, 25);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(3, 25, 50, 3);
            this.txtSummary.MaxLength = 10;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(170, 29);
            this.txtSummary.TabIndex = 12;
            this.txtSummary.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 28, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date/Time:";
            // 
            // btnContinue
            // 
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Location = new System.Drawing.Point(6, 10);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(120, 50);
            this.btnContinue.TabIndex = 18;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(548, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dbReserveDataSet
            // 
            this.dbReserveDataSet.DataSetName = "dbReserveDataSet";
            this.dbReserveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAccInfoTableAdapter
            // 
            this.tblAccInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tblReservationTableAdapter
            // 
            this.tblReservationTableAdapter.ClearBeforeFill = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 507);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reservation_FormClosing);
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbReserveDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monCal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.ComboBox cmbMidday;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReserve;
        private dbReserveDataSet dbReserveDataSet;
        private dbReserveDataSetTableAdapters.tblAccInfoTableAdapter tblAccInfoTableAdapter;
        private System.Windows.Forms.Button btnContinue;
        private dbReserveDataSetTableAdapters.tblReservationTableAdapter tblReservationTableAdapter;
    }
}