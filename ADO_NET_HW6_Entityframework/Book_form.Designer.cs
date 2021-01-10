
namespace ADO_NET_HW6_Entityframework
{
    partial class Book_form
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.pages_lbl = new System.Windows.Forms.Label();
            this.authorId_lbl = new System.Windows.Forms.Label();
            this.title_txbx = new System.Windows.Forms.TextBox();
            this.price_txbx = new System.Windows.Forms.TextBox();
            this.pages_txbx = new System.Windows.Forms.TextBox();
            this.authorId_txbx = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.publisherId_lbl = new System.Windows.Forms.Label();
            this.publisherId_txbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(13, 23);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(69, 13);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Enter the title";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(13, 74);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(76, 13);
            this.price_lbl.TabIndex = 1;
            this.price_lbl.Text = "Enter the price";
            // 
            // pages_lbl
            // 
            this.pages_lbl.AutoSize = true;
            this.pages_lbl.Location = new System.Drawing.Point(13, 125);
            this.pages_lbl.Name = "pages_lbl";
            this.pages_lbl.Size = new System.Drawing.Size(132, 13);
            this.pages_lbl.TabIndex = 2;
            this.pages_lbl.Text = "Enter the number of pages";
            // 
            // authorId_lbl
            // 
            this.authorId_lbl.AutoSize = true;
            this.authorId_lbl.Location = new System.Drawing.Point(13, 176);
            this.authorId_lbl.Name = "authorId_lbl";
            this.authorId_lbl.Size = new System.Drawing.Size(95, 13);
            this.authorId_lbl.TabIndex = 3;
            this.authorId_lbl.Text = "Enter the author Id";
            // 
            // title_txbx
            // 
            this.title_txbx.Location = new System.Drawing.Point(13, 40);
            this.title_txbx.Name = "title_txbx";
            this.title_txbx.Size = new System.Drawing.Size(258, 20);
            this.title_txbx.TabIndex = 4;
            // 
            // price_txbx
            // 
            this.price_txbx.Location = new System.Drawing.Point(13, 90);
            this.price_txbx.Name = "price_txbx";
            this.price_txbx.Size = new System.Drawing.Size(258, 20);
            this.price_txbx.TabIndex = 5;
            // 
            // pages_txbx
            // 
            this.pages_txbx.Location = new System.Drawing.Point(13, 141);
            this.pages_txbx.Name = "pages_txbx";
            this.pages_txbx.Size = new System.Drawing.Size(258, 20);
            this.pages_txbx.TabIndex = 6;
            // 
            // authorId_txbx
            // 
            this.authorId_txbx.Location = new System.Drawing.Point(13, 192);
            this.authorId_txbx.Name = "authorId_txbx";
            this.authorId_txbx.Size = new System.Drawing.Size(258, 20);
            this.authorId_txbx.TabIndex = 7;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(16, 293);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(196, 293);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // publisherId_lbl
            // 
            this.publisherId_lbl.AutoSize = true;
            this.publisherId_lbl.Location = new System.Drawing.Point(13, 228);
            this.publisherId_lbl.Name = "publisherId_lbl";
            this.publisherId_lbl.Size = new System.Drawing.Size(107, 13);
            this.publisherId_lbl.TabIndex = 10;
            this.publisherId_lbl.Text = "Enter the publisher Id";
            // 
            // publisherId_txbx
            // 
            this.publisherId_txbx.Location = new System.Drawing.Point(12, 244);
            this.publisherId_txbx.Name = "publisherId_txbx";
            this.publisherId_txbx.Size = new System.Drawing.Size(258, 20);
            this.publisherId_txbx.TabIndex = 11;
            // 
            // Book_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 340);
            this.Controls.Add(this.publisherId_txbx);
            this.Controls.Add(this.publisherId_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.authorId_txbx);
            this.Controls.Add(this.pages_txbx);
            this.Controls.Add(this.price_txbx);
            this.Controls.Add(this.title_txbx);
            this.Controls.Add(this.authorId_lbl);
            this.Controls.Add(this.pages_lbl);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.title_lbl);
            this.Name = "Book_form";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label pages_lbl;
        private System.Windows.Forms.Label authorId_lbl;
        private System.Windows.Forms.TextBox title_txbx;
        private System.Windows.Forms.TextBox price_txbx;
        private System.Windows.Forms.TextBox pages_txbx;
        private System.Windows.Forms.TextBox authorId_txbx;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label publisherId_lbl;
        private System.Windows.Forms.TextBox publisherId_txbx;
    }
}