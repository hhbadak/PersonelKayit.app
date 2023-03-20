namespace PersonelKayit
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.btn_personalAdd = new System.Windows.Forms.Button();
            this.btn_personalList = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_personalUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_personalAdd
            // 
            this.btn_personalAdd.Location = new System.Drawing.Point(45, 87);
            this.btn_personalAdd.Name = "btn_personalAdd";
            this.btn_personalAdd.Size = new System.Drawing.Size(135, 50);
            this.btn_personalAdd.TabIndex = 0;
            this.btn_personalAdd.Text = "Personel Ekle";
            this.btn_personalAdd.UseVisualStyleBackColor = true;
            this.btn_personalAdd.Click += new System.EventHandler(this.btn_personalAdd_Click);
            // 
            // btn_personalList
            // 
            this.btn_personalList.Location = new System.Drawing.Point(45, 143);
            this.btn_personalList.Name = "btn_personalList";
            this.btn_personalList.Size = new System.Drawing.Size(135, 50);
            this.btn_personalList.TabIndex = 1;
            this.btn_personalList.Text = "Personel Listele";
            this.btn_personalList.UseVisualStyleBackColor = true;
            this.btn_personalList.Click += new System.EventHandler(this.btn_personalList_Click);
            // 
            // btn_salary
            // 
            this.btn_salary.Location = new System.Drawing.Point(45, 199);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(135, 50);
            this.btn_salary.TabIndex = 2;
            this.btn_salary.Text = "Maaş Hesapla";
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_personalUpdate
            // 
            this.btn_personalUpdate.Location = new System.Drawing.Point(45, 255);
            this.btn_personalUpdate.Name = "btn_personalUpdate";
            this.btn_personalUpdate.Size = new System.Drawing.Size(135, 50);
            this.btn_personalUpdate.TabIndex = 3;
            this.btn_personalUpdate.Text = "Personel Bilgileri Güncelle";
            this.btn_personalUpdate.UseVisualStyleBackColor = true;
            this.btn_personalUpdate.Click += new System.EventHandler(this.btn_personalUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(250, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_personalUpdate);
            this.Controls.Add(this.btn_salary);
            this.Controls.Add(this.btn_personalList);
            this.Controls.Add(this.btn_personalAdd);
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "HomeScreen";
            this.Text = "Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_personalAdd;
        private System.Windows.Forms.Button btn_personalList;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_personalUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}