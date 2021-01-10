
namespace ADO_NET_HW6_Entityframework
{
    partial class Publisher_form
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txbx = new System.Windows.Forms.TextBox();
            this.adress_lbl = new System.Windows.Forms.Label();
            this.adress_txbx = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(12, 22);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(131, 13);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Enter the publisher\'s name";
            // 
            // name_txbx
            // 
            this.name_txbx.Location = new System.Drawing.Point(15, 39);
            this.name_txbx.Name = "name_txbx";
            this.name_txbx.Size = new System.Drawing.Size(290, 20);
            this.name_txbx.TabIndex = 1;
            // 
            // adress_lbl
            // 
            this.adress_lbl.AutoSize = true;
            this.adress_lbl.Location = new System.Drawing.Point(12, 85);
            this.adress_lbl.Name = "adress_lbl";
            this.adress_lbl.Size = new System.Drawing.Size(136, 13);
            this.adress_lbl.TabIndex = 2;
            this.adress_lbl.Text = "Enter the publisher\'s adress";
            // 
            // adress_txbx
            // 
            this.adress_txbx.Location = new System.Drawing.Point(12, 101);
            this.adress_txbx.Name = "adress_txbx";
            this.adress_txbx.Size = new System.Drawing.Size(290, 20);
            this.adress_txbx.TabIndex = 3;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(15, 144);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 4;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(230, 144);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Publisher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 179);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.adress_txbx);
            this.Controls.Add(this.adress_lbl);
            this.Controls.Add(this.name_txbx);
            this.Controls.Add(this.name_lbl);
            this.Name = "Publisher_form";
            this.Text = "Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_txbx;
        private System.Windows.Forms.Label adress_lbl;
        private System.Windows.Forms.TextBox adress_txbx;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}