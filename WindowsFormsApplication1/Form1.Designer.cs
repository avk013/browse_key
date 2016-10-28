namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.tb_str1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_str2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 513);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.geckoWebBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "рабочее поле";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_str2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_str1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(531, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 20);
            this.button6.TabIndex = 12;
            this.button6.Text = "считываем из файла";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSalmon;
            this.button5.Location = new System.Drawing.Point(499, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 75);
            this.button5.TabIndex = 11;
            this.button5.Text = "лишнее";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(499, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 77);
            this.button4.TabIndex = 10;
            this.button4.Text = "подходит";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(17, 51);
            this.textBox1.MaxLength = 63;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "ВАО";
            this.textBox1.WordWrap = false;
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Location = new System.Drawing.Point(3, 0);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(676, 340);
            this.geckoWebBrowser1.TabIndex = 8;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // tb_str1
            // 
            this.tb_str1.Location = new System.Drawing.Point(7, 31);
            this.tb_str1.Name = "tb_str1";
            this.tb_str1.Size = new System.Drawing.Size(545, 20);
            this.tb_str1.TabIndex = 0;
            this.tb_str1.Text = "https://www.yandex.ru/search/?text=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "базовая строка (https://www.google.com.ua/search?client=opera&&q=мечта&&sourceid=" +
    "opera&&ie=UTF-8&&oe=UTF-8)";
            // 
            // tb_str2
            // 
            this.tb_str2.Location = new System.Drawing.Point(161, 57);
            this.tb_str2.Name = "tb_str2";
            this.tb_str2.Size = new System.Drawing.Size(391, 20);
            this.tb_str2.TabIndex = 2;
            this.tb_str2.Text = " &lr=213&clid=9582&rstr=-213";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "разный текст из файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "go_cite";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_str1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_str2;
    }
}

