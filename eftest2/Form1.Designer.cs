
namespace eftest2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salarybox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.getdetailsbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "employeeid";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(518, 80);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(230, 22);
            this.idbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "employee";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(518, 151);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(230, 22);
            this.namebox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employee salary";
            // 
            // salarybox
            // 
            this.salarybox.Location = new System.Drawing.Point(516, 229);
            this.salarybox.Name = "salarybox";
            this.salarybox.Size = new System.Drawing.Size(230, 22);
            this.salarybox.TabIndex = 2;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(518, 279);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(108, 66);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "ADD TO EMPLOYEES";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(637, 279);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(137, 66);
            this.showbutton.TabIndex = 3;
            this.showbutton.Text = "SHOW ALL EMPLOYEES";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "UPDATE EMPLOYEE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "DELETE EMPLOYEE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // getdetailsbutton
            // 
            this.getdetailsbutton.Location = new System.Drawing.Point(375, 394);
            this.getdetailsbutton.Name = "getdetailsbutton";
            this.getdetailsbutton.Size = new System.Drawing.Size(108, 33);
            this.getdetailsbutton.TabIndex = 3;
            this.getdetailsbutton.Text = "get details";
            this.getdetailsbutton.UseVisualStyleBackColor = true;
            this.getdetailsbutton.Click += new System.EventHandler(this.getdetailsbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Note : fill only id to delete or get details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.getdetailsbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.salarybox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salarybox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button getdetailsbutton;
        private System.Windows.Forms.Label label4;
    }
}

