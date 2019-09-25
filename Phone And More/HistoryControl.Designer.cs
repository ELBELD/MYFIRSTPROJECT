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
            this.serviceInvoiceControl2 = new Phone_And_More.ServiceInvoiceControl();
            this.serviceInvoiceControl1 = new Phone_And_More.ServiceInvoiceControl();
            this.panel1.SuspendLayout();
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
            this.btnSalesInvoice.Click += new System.EventHandler(this.btnSalesInvoice_Click);
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
            // serviceInvoiceControl2
            // 
            this.serviceInvoiceControl2.Location = new System.Drawing.Point(0, 136);
            this.serviceInvoiceControl2.Name = "serviceInvoiceControl2";
            this.serviceInvoiceControl2.Size = new System.Drawing.Size(1128, 646);
            this.serviceInvoiceControl2.TabIndex = 26;
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
            this.Controls.Add(this.serviceInvoiceControl2);
            this.Controls.Add(this.btnSalesInvoice);
            this.Controls.Add(this.btnServiceInvoice);
            this.Controls.Add(this.panel1);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(1134, 785);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private ServiceInvoiceControl serviceInvoiceControl2;
    }
}
