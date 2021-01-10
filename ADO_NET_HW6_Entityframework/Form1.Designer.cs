
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
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Books_tab = new System.Windows.Forms.TabPage();
            this.Authors_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Main_form = new System.Windows.Forms.TabControl();
            this.Publishers_tab = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.Authors_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Main_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(192, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(4, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(97, 3);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.remove_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 29);
            this.panel1.TabIndex = 7;
            // 
            // Books_tab
            // 
            this.Books_tab.Location = new System.Drawing.Point(4, 22);
            this.Books_tab.Name = "Books_tab";
            this.Books_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Books_tab.Size = new System.Drawing.Size(542, 395);
            this.Books_tab.TabIndex = 1;
            this.Books_tab.Text = "Books";
            this.Books_tab.UseVisualStyleBackColor = true;
            // 
            // Authors_tab
            // 
            this.Authors_tab.Controls.Add(this.dataGridView1);
            this.Authors_tab.Location = new System.Drawing.Point(4, 22);
            this.Authors_tab.Name = "Authors_tab";
            this.Authors_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Authors_tab.Size = new System.Drawing.Size(542, 395);
            this.Authors_tab.TabIndex = 0;
            this.Authors_tab.Text = "Authors";
            this.Authors_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // Main_form
            // 
            this.Main_form.Controls.Add(this.Authors_tab);
            this.Main_form.Controls.Add(this.Books_tab);
            this.Main_form.Controls.Add(this.Publishers_tab);
            this.Main_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_form.Location = new System.Drawing.Point(0, 0);
            this.Main_form.Name = "Main_form";
            this.Main_form.SelectedIndex = 0;
            this.Main_form.Size = new System.Drawing.Size(550, 421);
            this.Main_form.TabIndex = 8;
            this.Main_form.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Publishers_tab
            // 
            this.Publishers_tab.Location = new System.Drawing.Point(4, 22);
            this.Publishers_tab.Name = "Publishers_tab";
            this.Publishers_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Publishers_tab.Size = new System.Drawing.Size(542, 395);
            this.Publishers_tab.TabIndex = 2;
            this.Publishers_tab.Text = "Publishers";
            this.Publishers_tab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.Main_form);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Entityframework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.Authors_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Main_form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Books_tab;
        private System.Windows.Forms.TabPage Authors_tab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl Main_form;
        private System.Windows.Forms.TabPage Publishers_tab;
    }
}

