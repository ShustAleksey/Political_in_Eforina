namespace Political_in_Eforina
{
    partial class FAvtorizac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFas = new System.Windows.Forms.RadioButton();
            this.rbMon = new System.Windows.Forms.RadioButton();
            this.rbLib = new System.Windows.Forms.RadioButton();
            this.rbSoc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.rbFas);
            this.groupBox1.Controls.Add(this.rbMon);
            this.groupBox1.Controls.Add(this.rbLib);
            this.groupBox1.Controls.Add(this.rbSoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите партию";
            // 
            // rbFas
            // 
            this.rbFas.AutoSize = true;
            this.rbFas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbFas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbFas.Location = new System.Drawing.Point(6, 150);
            this.rbFas.Name = "rbFas";
            this.rbFas.Size = new System.Drawing.Size(202, 33);
            this.rbFas.TabIndex = 3;
            this.rbFas.Text = "Консерваторы";
            this.rbFas.UseVisualStyleBackColor = true;
            // 
            // rbMon
            // 
            this.rbMon.AutoSize = true;
            this.rbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMon.ForeColor = System.Drawing.Color.Gray;
            this.rbMon.Location = new System.Drawing.Point(6, 111);
            this.rbMon.Name = "rbMon";
            this.rbMon.Size = new System.Drawing.Size(177, 33);
            this.rbMon.TabIndex = 2;
            this.rbMon.Text = "Монархисты";
            this.rbMon.UseVisualStyleBackColor = true;
            // 
            // rbLib
            // 
            this.rbLib.AutoSize = true;
            this.rbLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLib.ForeColor = System.Drawing.Color.Green;
            this.rbLib.Location = new System.Drawing.Point(6, 72);
            this.rbLib.Name = "rbLib";
            this.rbLib.Size = new System.Drawing.Size(151, 33);
            this.rbLib.TabIndex = 1;
            this.rbLib.Text = "Либералы";
            this.rbLib.UseVisualStyleBackColor = true;
            // 
            // rbSoc
            // 
            this.rbSoc.AutoSize = true;
            this.rbSoc.Checked = true;
            this.rbSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSoc.ForeColor = System.Drawing.Color.DarkRed;
            this.rbSoc.Location = new System.Drawing.Point(6, 33);
            this.rbSoc.Name = "rbSoc";
            this.rbSoc.Size = new System.Drawing.Size(179, 33);
            this.rbSoc.TabIndex = 0;
            this.rbSoc.TabStop = true;
            this.rbSoc.Text = "Социалисты";
            this.rbSoc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(777, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать играть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(753, 229);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 453);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FAvtorizac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 487);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FAvtorizac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFas;
        private System.Windows.Forms.RadioButton rbMon;
        private System.Windows.Forms.RadioButton rbLib;
        private System.Windows.Forms.RadioButton rbSoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Splitter splitter1;
    }
}

