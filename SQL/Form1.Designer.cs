namespace SQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Brigade = new System.Windows.Forms.Button();
            this.region = new System.Windows.Forms.Button();
            this.workshop = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сотрудники";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(640, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Brigade
            // 
            this.Brigade.BackColor = System.Drawing.SystemColors.Highlight;
            this.Brigade.Location = new System.Drawing.Point(12, 99);
            this.Brigade.Name = "Brigade";
            this.Brigade.Size = new System.Drawing.Size(184, 81);
            this.Brigade.TabIndex = 12;
            this.Brigade.Text = "Бригада";
            this.Brigade.UseVisualStyleBackColor = false;
            this.Brigade.Click += new System.EventHandler(this.Brigade_Click);
            // 
            // region
            // 
            this.region.BackColor = System.Drawing.SystemColors.Highlight;
            this.region.Location = new System.Drawing.Point(202, 99);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(184, 81);
            this.region.TabIndex = 14;
            this.region.Text = "Участок";
            this.region.UseVisualStyleBackColor = false;
            this.region.Click += new System.EventHandler(this.region_Click);
            // 
            // workshop
            // 
            this.workshop.BackColor = System.Drawing.SystemColors.Highlight;
            this.workshop.Location = new System.Drawing.Point(202, 12);
            this.workshop.Name = "workshop";
            this.workshop.Size = new System.Drawing.Size(184, 81);
            this.workshop.TabIndex = 13;
            this.workshop.Text = "Цеха";
            this.workshop.UseVisualStyleBackColor = false;
            this.workshop.Click += new System.EventHandler(this.workshop_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(392, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 81);
            this.button5.TabIndex = 16;
            this.button5.Text = "Тип изделия";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(12, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 81);
            this.button6.TabIndex = 15;
            this.button6.Text = "Оборудование";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(392, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 81);
            this.button7.TabIndex = 18;
            this.button7.Text = "Изделия";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Highlight;
            this.button8.Location = new System.Drawing.Point(12, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 81);
            this.button8.TabIndex = 17;
            this.button8.Text = "Цикл работы";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Highlight;
            this.button9.Location = new System.Drawing.Point(202, 273);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 81);
            this.button9.TabIndex = 20;
            this.button9.Text = "Испытательная лаборатория";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Highlight;
            this.button10.Location = new System.Drawing.Point(202, 186);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(184, 81);
            this.button10.TabIndex = 19;
            this.button10.Text = "Сборка изделия";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Highlight;
            this.button11.Location = new System.Drawing.Point(392, 273);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(184, 81);
            this.button11.TabIndex = 22;
            this.button11.Text = "Тип Испытания";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Highlight;
            this.button12.Location = new System.Drawing.Point(392, 186);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(184, 81);
            this.button12.TabIndex = 21;
            this.button12.Text = "Испытания";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 413);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.region);
            this.Controls.Add(this.workshop);
            this.Controls.Add(this.Brigade);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Brigade;
        private System.Windows.Forms.Button region;
        private System.Windows.Forms.Button workshop;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

