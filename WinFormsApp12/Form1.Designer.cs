namespace laba6
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
            this.EM = new System.Windows.Forms.Button();
            this.RK2 = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.iter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.h0 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EM
            // 
            this.EM.BackColor = System.Drawing.Color.LightGray;
            this.EM.Location = new System.Drawing.Point(964, 172);
            this.EM.Name = "EM";
            this.EM.Size = new System.Drawing.Size(184, 93);
            this.EM.TabIndex = 0;
            this.EM.Text = "Метод Эйлера";
            this.EM.UseVisualStyleBackColor = false;
            this.EM.Click += new System.EventHandler(this.BTN_EM);
            // 
            // RK2
            // 
            this.RK2.BackColor = System.Drawing.Color.LightGray;
            this.RK2.Location = new System.Drawing.Point(964, 362);
            this.RK2.Name = "RK2";
            this.RK2.Size = new System.Drawing.Size(184, 95);
            this.RK2.TabIndex = 3;
            this.RK2.Text = "Метод Рунге-Кутта второго порядка";
            this.RK2.UseVisualStyleBackColor = false;
            this.RK2.Click += new System.EventHandler(this.BTN_RK2);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Gray;
            this.ClearAll.Location = new System.Drawing.Point(847, 526);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(150, 59);
            this.ClearAll.TabIndex = 8;
            this.ClearAll.Text = "Очистить график";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.BTN_Clear);
            // 
            // iter
            // 
            this.iter.BackColor = System.Drawing.Color.LightGray;
            this.iter.Location = new System.Drawing.Point(730, 151);
            this.iter.Name = "iter";
            this.iter.Size = new System.Drawing.Size(144, 23);
            this.iter.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(730, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберете функцию";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(730, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите количество итераций";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(730, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Введите X0";
            // 
            // X0
            // 
            this.X0.BackColor = System.Drawing.Color.LightGray;
            this.X0.Location = new System.Drawing.Point(733, 268);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(141, 23);
            this.X0.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(730, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Введите Y0 ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Y0
            // 
            this.Y0.BackColor = System.Drawing.Color.LightGray;
            this.Y0.Location = new System.Drawing.Point(733, 338);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(141, 23);
            this.Y0.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(733, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Введите шаг";
            // 
            // h0
            // 
            this.h0.BackColor = System.Drawing.Color.LightGray;
            this.h0.Location = new System.Drawing.Point(733, 407);
            this.h0.Name = "h0";
            this.h0.Size = new System.Drawing.Size(141, 23);
            this.h0.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "y\'=3x^(2)*y",
            "y\'=3x^2y+x^2*e^(x^3)"});
            this.comboBox1.Location = new System.Drawing.Point(730, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 23);
            this.comboBox1.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(847, 612);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 59);
            this.button3.TabIndex = 31;
            this.button3.Text = "Построить точный график";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1160, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.h0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iter);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.RK2);
            this.Controls.Add(this.EM);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button EM;
        private System.Windows.Forms.Button RK2;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.TextBox iter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Y0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.Label curStep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox h0;
        private System.Windows.Forms.Button button3;
    }
}


