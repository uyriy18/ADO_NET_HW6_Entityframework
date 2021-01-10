
namespace ADO_NET_HW6_Entityframework
{
    partial class Add_Author
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
            this.firstname_lbl = new System.Windows.Forms.Label();
            this.lastname_lbl = new System.Windows.Forms.Label();
            this.firstname_txbx = new System.Windows.Forms.TextBox();
            this.lastname_txbx = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstname_lbl
            // 
            this.firstname_lbl.AutoSize = true;
            this.firstname_lbl.Location = new System.Drawing.Point(13, 13);
            this.firstname_lbl.Name = "firstname_lbl";
            this.firstname_lbl.Size = new System.Drawing.Size(117, 13);
            this.firstname_lbl.TabIndex = 0;
            this.firstname_lbl.Text = "Enter author\'s firstname";
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Location = new System.Drawing.Point(13, 81);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(117, 13);
            this.lastname_lbl.TabIndex = 1;
            this.lastname_lbl.Text = "Enter author\'s lastname";
            // 
            // firstname_txbx
            // 
            this.firstname_txbx.Location = new System.Drawing.Point(12, 29);
            this.firstname_txbx.Name = "firstname_txbx";
            this.firstname_txbx.Size = new System.Drawing.Size(255, 20);
            this.firstname_txbx.TabIndex = 2;
            // 
            // lastname_txbx
            // 
            this.lastname_txbx.Location = new System.Drawing.Point(12, 97);
            this.lastname_txbx.Name = "lastname_txbx";
            this.lastname_txbx.Size = new System.Drawing.Size(255, 20);
            this.lastname_txbx.TabIndex = 3;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(12, 160);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 4;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(192, 160);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Add_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 202);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.lastname_txbx);
            this.Controls.Add(this.firstname_txbx);
            this.Controls.Add(this.lastname_lbl);
            this.Controls.Add(this.firstname_lbl);
            this.Name = "Add_Author";
            this.Text = "Add_Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname_lbl;
        private System.Windows.Forms.Label lastname_lbl;
        private System.Windows.Forms.TextBox firstname_txbx;
        private System.Windows.Forms.TextBox lastname_txbx;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}