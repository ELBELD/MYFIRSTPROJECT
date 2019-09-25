namespace Phone_And_More
{
    partial class HistoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalesInvoice = new System.Windows.Forms.Button();
            this.btnServiceInvoice = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalsell = new System.Windows.Forms.TextBox();
            this.txttotalprofit = new System.Windows.Forms.TextBox();
            this.serviceInvoiceControl1 = new Phone_And_More.ServiceInvoiceControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 51);
            this.panel1.TabIndex = 2;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(506, 26);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            // 
            // btnSalesInvoice
            // 
            this.btnSalesInvoice.FlatAppearance.BorderSize = 0;
            this.btnSalesInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesInvoice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesInvoice.Image")));
            this.btnSalesInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesInvoice.Location = new System.Drawing.Point(539, 57);
            this.btnSalesInvoice.Name = "btnSalesInvoice";
            this.btnSalesInvoice.Size = new System.Drawing.Size(188, 73);
            this.btnSalesInvoice.TabIndex = 25;
            this.btnSalesInvoice.Text = "Sales Invoices";
            this.btnSalesInvoice.UseVisualStyleBackColor = true;
            // 
            // btnServiceInvoice
            // 
            this.btnServiceInvoice.FlatAppearance.BorderSize = 0;
            this.btnServiceInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceInvoice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceInvoice.Image")));
            this.btnServiceInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceInvoice.Location = new System.Drawing.Point(345, 57);
            this.btnServiceInvoice.Name = "btnServiceInvoice";
            this.btnServiceInvoice.Size = new System.Drawing.Size(188, 73);
            this.btnServiceInvoice.TabIndex = 24;
            this.btnServiceInvoice.Text = "Service  Invoice";
            this.btnServiceInvoice.UseVisualStyleBackColor = true;
            this.btnServiceInvoice.Click += new System.EventHandler(this.btnServiceInvoice_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 35);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date  :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 489);
            this.dataGridView1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 695);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total Sell ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 727);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Total Profit";
            // 
            // txttotalsell
            // 
            this.txttotalsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsell.Location = new System.Drawing.Point(121, 692);
            this.txttotalsell.Name = "txttotalsell";
            this.txttotalsell.ReadOnly = true;
            this.txttotalsell.Size = new System.Drawing.Size(217, 26);
            this.txttotalsell.TabIndex = 37;
            // 
            // txttotalprofit
            // 
            this.txttotalprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprofit.Location = new System.Drawing.Point(121, 724);
            this.txttotalprofit.Name = "txttotalprofit";
            this.txttotalprofit.ReadOnly = true;
            this.txttotalprofit.Size = new System.Drawing.Size(217, 26);
            this.txttotalprofit.TabIndex = 38;
            // 
            // serviceInvoiceControl1
            // 
            this.serviceInvoiceControl1.Location = new System.Drawing.Point(6, 136);
            this.serviceInvoiceControl1.Name = "serviceInvoiceControl1";
            this.serviceInvoiceControl1.Size = new System.Drawing.Size(1128, 631);
            this.serviceInvoiceControl1.TabIndex = 26;
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txttotalprofit);
            this.Controls.Add(this.txttotalsell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.serviceInvoiceControl1);
            this.Controls.Add(this.btnSalesInvoice);
            this.Controls.Add(this.btnServiceInvoice);
            this.Controls.Add(this.panel1);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(1134, 785);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServiceInvoice;
        private System.Windows.Forms.Button btnSalesInvoice;
        private ServiceInvoiceControl serviceInvoiceControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotalsell;
        private System.Windows.Forms.TextBox txttotalprofit;
    }
}
