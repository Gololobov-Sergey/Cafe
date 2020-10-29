namespace Shop
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
            this.groupBoxAZS = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labSumAZS = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnSum = new System.Windows.Forms.RadioButton();
            this.radBtnAmount = new System.Windows.Forms.RadioButton();
            this.labPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCafe = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxAZS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAZS
            // 
            this.groupBoxAZS.Controls.Add(this.label5);
            this.groupBoxAZS.Controls.Add(this.label4);
            this.groupBoxAZS.Controls.Add(this.label3);
            this.groupBoxAZS.Controls.Add(this.groupBox2);
            this.groupBoxAZS.Controls.Add(this.textBoxSum);
            this.groupBoxAZS.Controls.Add(this.textBoxAmount);
            this.groupBoxAZS.Controls.Add(this.groupBox1);
            this.groupBoxAZS.Controls.Add(this.labPrice);
            this.groupBoxAZS.Controls.Add(this.label2);
            this.groupBoxAZS.Controls.Add(this.comboBoxGas);
            this.groupBoxAZS.Controls.Add(this.label1);
            this.groupBoxAZS.Location = new System.Drawing.Point(24, 54);
            this.groupBoxAZS.Name = "groupBoxAZS";
            this.groupBoxAZS.Size = new System.Drawing.Size(278, 330);
            this.groupBoxAZS.TabIndex = 0;
            this.groupBoxAZS.TabStop = false;
            this.groupBoxAZS.Text = "АЗС";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "л";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "грн";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "грн";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labSumAZS);
            this.groupBox2.Location = new System.Drawing.Point(21, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "К оплате";
            // 
            // labSumAZS
            // 
            this.labSumAZS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSumAZS.Location = new System.Drawing.Point(6, 26);
            this.labSumAZS.Name = "labSumAZS";
            this.labSumAZS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labSumAZS.Size = new System.Drawing.Size(189, 57);
            this.labSumAZS.TabIndex = 0;
            this.labSumAZS.Text = "0";
            this.labSumAZS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(134, 168);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(88, 20);
            this.textBoxSum.TabIndex = 6;
            this.textBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(134, 136);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(88, 20);
            this.textBoxAmount.TabIndex = 5;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnSum);
            this.groupBox1.Controls.Add(this.radBtnAmount);
            this.groupBox1.Location = new System.Drawing.Point(21, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radBtnSum
            // 
            this.radBtnSum.AutoSize = true;
            this.radBtnSum.Location = new System.Drawing.Point(6, 51);
            this.radBtnSum.Name = "radBtnSum";
            this.radBtnSum.Size = new System.Drawing.Size(59, 17);
            this.radBtnSum.TabIndex = 1;
            this.radBtnSum.TabStop = true;
            this.radBtnSum.Text = "Сумма";
            this.radBtnSum.UseVisualStyleBackColor = true;
            this.radBtnSum.CheckedChanged += new System.EventHandler(this.radBtnSum_CheckedChanged);
            // 
            // radBtnAmount
            // 
            this.radBtnAmount.AutoSize = true;
            this.radBtnAmount.Location = new System.Drawing.Point(6, 19);
            this.radBtnAmount.Name = "radBtnAmount";
            this.radBtnAmount.Size = new System.Drawing.Size(90, 17);
            this.radBtnAmount.TabIndex = 0;
            this.radBtnAmount.TabStop = true;
            this.radBtnAmount.Text = "Колличество";
            this.radBtnAmount.UseVisualStyleBackColor = true;
            this.radBtnAmount.CheckedChanged += new System.EventHandler(this.radBtnAmount_CheckedChanged);
            // 
            // labPrice
            // 
            this.labPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPrice.Location = new System.Drawing.Point(98, 79);
            this.labPrice.Name = "labPrice";
            this.labPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labPrice.Size = new System.Drawing.Size(124, 21);
            this.labPrice.TabIndex = 3;
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            // 
            // comboBoxGas
            // 
            this.comboBoxGas.FormattingEnabled = true;
            this.comboBoxGas.Location = new System.Drawing.Point(98, 36);
            this.comboBoxGas.Name = "comboBoxGas";
            this.comboBoxGas.Size = new System.Drawing.Size(124, 21);
            this.comboBoxGas.TabIndex = 1;
            this.comboBoxGas.SelectedIndexChanged += new System.EventHandler(this.comboBoxGas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // groupBoxCafe
            // 
            this.groupBoxCafe.Controls.Add(this.panel1);
            this.groupBoxCafe.Location = new System.Drawing.Point(328, 54);
            this.groupBoxCafe.Name = "groupBoxCafe";
            this.groupBoxCafe.Size = new System.Drawing.Size(300, 330);
            this.groupBoxCafe.TabIndex = 1;
            this.groupBoxCafe.TabStop = false;
            this.groupBoxCafe.Text = "Мини-Кафе";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 159);
            this.panel1.TabIndex = 0;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 555);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBoxCafe);
            this.Controls.Add(this.groupBoxAZS);
            this.Name = "Form1";
            this.Text = "АЗС";
            this.groupBoxAZS.ResumeLayout(false);
            this.groupBoxAZS.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCafe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAZS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labSumAZS;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnSum;
        private System.Windows.Forms.RadioButton radBtnAmount;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCafe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

