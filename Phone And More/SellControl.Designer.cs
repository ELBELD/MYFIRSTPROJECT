namespace Phone_And_More
{
    partial class SellControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtselect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChekout = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barcode";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(721, 89);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(410, 35);
            this.txtbarcode.TabIndex = 5;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // txtselect
            // 
            this.txtselect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtselect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtselect.Location = new System.Drawing.Point(3, 89);
            this.txtselect.Name = "txtselect";
            this.txtselect.Size = new System.Drawing.Size(410, 35);
            this.txtselect.TabIndex = 7;
            this.txtselect.TextChanged += new System.EventHandler(this.txtselect_TextChanged);
            this.txtselect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtselect_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1128, 560);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblTotalprice
            // 
            this.lblTotalprice.AutoSize = true;
            this.lblTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalprice.Location = new System.Drawing.Point(822, 725);
            this.lblTotalprice.Name = "lblTotalprice";
            this.lblTotalprice.Size = new System.Drawing.Size(19, 20);
            this.lblTotalprice.TabIndex = 10;
            this.lblTotalprice.Text = "0";
            this.lblTotalprice.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(717, 725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Price:";
            this.label5.Visible = false;
            // 
            // btnChekout
            // 
            this.btnChekout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChekout.FlatAppearance.BorderSize = 0;
            this.btnChekout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChekout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChekout.Location = new System.Drawing.Point(9, 717);
            this.btnChekout.Name = "btnChekout";
            this.btnChekout.Size = new System.Drawing.Size(105, 39);
            this.btnChekout.TabIndex = 12;
            this.btnChekout.Text = "Checkout";
            this.btnChekout.UseVisualStyleBackColor = false;
            this.btnChekout.Visible = false;
            this.btnChekout.Click += new System.EventHandler(this.btnChekout_Click);
            // 
            // SellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChekout);
            this.Controls.Add(this.lblTotalprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtselect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.panel1);
            this.Name = "SellControl";
            this.Size = new System.Drawing.Size(1134, 785);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtselect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChekout;
        private System.Windows.Forms.Label lblid;
    }
}
