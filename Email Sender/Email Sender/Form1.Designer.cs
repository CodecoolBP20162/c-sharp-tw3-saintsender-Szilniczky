namespace Email_Sender
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtreceiver = new System.Windows.Forms.TextBox();
            this.txtattachment = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(365, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receiver Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Add attachment";
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.Color.Blue;
            this.txtemail.Location = new System.Drawing.Point(126, 22);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(222, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.ForeColor = System.Drawing.Color.Blue;
            this.txtpassword.Location = new System.Drawing.Point(442, 22);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(222, 20);
            this.txtpassword.TabIndex = 7;
            // 
            // txtreceiver
            // 
            this.txtreceiver.ForeColor = System.Drawing.Color.Blue;
            this.txtreceiver.Location = new System.Drawing.Point(126, 65);
            this.txtreceiver.Name = "txtreceiver";
            this.txtreceiver.Size = new System.Drawing.Size(538, 20);
            this.txtreceiver.TabIndex = 8;
            // 
            // txtattachment
            // 
            this.txtattachment.Enabled = false;
            this.txtattachment.ForeColor = System.Drawing.Color.Blue;
            this.txtattachment.Location = new System.Drawing.Point(126, 99);
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.Size = new System.Drawing.Size(457, 20);
            this.txtattachment.TabIndex = 9;
            // 
            // txtsubject
            // 
            this.txtsubject.ForeColor = System.Drawing.Color.Blue;
            this.txtsubject.Location = new System.Drawing.Point(126, 132);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(538, 20);
            this.txtsubject.TabIndex = 10;
            // 
            // txtbody
            // 
            this.txtbody.ForeColor = System.Drawing.Color.Blue;
            this.txtbody.Location = new System.Drawing.Point(126, 176);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(538, 159);
            this.txtbody.TabIndex = 11;
            // 
            // btnsend
            // 
            this.btnsend.ForeColor = System.Drawing.Color.Black;
            this.btnsend.Location = new System.Drawing.Point(589, 341);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 12;
            this.btnsend.Text = "Send ";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.ForeColor = System.Drawing.Color.Black;
            this.btnbrowse.Location = new System.Drawing.Point(589, 96);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 25);
            this.btnbrowse.TabIndex = 13;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 381);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(705, 381);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.txtreceiver);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.Text = "Email Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtreceiver;
        private System.Windows.Forms.TextBox txtattachment;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

