
namespace ADO_NET_HW6_Entityframework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.authors_btn = new System.Windows.Forms.Button();
            this.books_btn = new System.Windows.Forms.Button();
            this.publishers_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // authors_btn
            // 
            this.authors_btn.Location = new System.Drawing.Point(624, 16);
            this.authors_btn.Name = "authors_btn";
            this.authors_btn.Size = new System.Drawing.Size(75, 23);
            this.authors_btn.TabIndex = 1;
            this.authors_btn.Text = "Authors";
            this.authors_btn.UseVisualStyleBackColor = true;
            this.authors_btn.Click += new System.EventHandler(this.authors_btn_Click);
            // 
            // books_btn
            // 
            this.books_btn.Location = new System.Drawing.Point(624, 45);
            this.books_btn.Name = "books_btn";
            this.books_btn.Size = new System.Drawing.Size(75, 23);
            this.books_btn.TabIndex = 2;
            this.books_btn.Text = "Books";
            this.books_btn.UseVisualStyleBackColor = true;
            this.books_btn.Click += new System.EventHandler(this.books_btn_Click);
            // 
            // publishers_btn
            // 
            this.publishers_btn.Location = new System.Drawing.Point(624, 74);
            this.publishers_btn.Name = "publishers_btn";
            this.publishers_btn.Size = new System.Drawing.Size(75, 23);
            this.publishers_btn.TabIndex = 3;
            this.publishers_btn.Text = "Publishers";
            this.publishers_btn.UseVisualStyleBackColor = true;
            this.publishers_btn.Click += new System.EventHandler(this.publishers_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(624, 230);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(624, 172);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(624, 201);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.publishers_btn);
            this.Controls.Add(this.books_btn);
            this.Controls.Add(this.authors_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button authors_btn;
        private System.Windows.Forms.Button books_btn;
        private System.Windows.Forms.Button publishers_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
    }
}

