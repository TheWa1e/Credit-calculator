namespace MainForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTipPaymentType = new System.Windows.Forms.ToolTip(this.components);
            this.priceDiffer = new System.Windows.Forms.RadioButton();
            this.priceAnnuitet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itogSum = new System.Windows.Forms.TextBox();
            this.itogPayment = new System.Windows.Forms.TextBox();
            this.itogOverpayment = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butPriceGo = new System.Windows.Forms.Button();
            this.butPriceClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.priceInitialType = new System.Windows.Forms.ComboBox();
            this.pricePeriodCombo = new System.Windows.Forms.ComboBox();
            this.pricePeriod = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceProcent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.priceInitial = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceCreditSum1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCreditSum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceDiffer
            // 
            this.priceDiffer.AutoSize = true;
            this.priceDiffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.priceDiffer.Location = new System.Drawing.Point(218, 153);
            this.priceDiffer.Name = "priceDiffer";
            this.priceDiffer.Size = new System.Drawing.Size(163, 19);
            this.priceDiffer.TabIndex = 58;
            this.priceDiffer.TabStop = true;
            this.priceDiffer.Text = "Дифференцированный";
            this.toolTipPaymentType.SetToolTip(this.priceDiffer, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа по пог" +
        "ашению кредита постепенно уменьшается к концу периода кредитования.");
            this.priceDiffer.UseVisualStyleBackColor = true;
            // 
            // priceAnnuitet
            // 
            this.priceAnnuitet.AutoSize = true;
            this.priceAnnuitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.priceAnnuitet.Location = new System.Drawing.Point(113, 153);
            this.priceAnnuitet.Name = "priceAnnuitet";
            this.priceAnnuitet.Size = new System.Drawing.Size(102, 19);
            this.priceAnnuitet.TabIndex = 57;
            this.priceAnnuitet.TabStop = true;
            this.priceAnnuitet.Text = "Аннуитетный";
            this.toolTipPaymentType.SetToolTip(this.priceAnnuitet, "Вариант ежемесячного платежа по кредиту, когда размер ежемесячного платежа остаёт" +
        "ся постоянным на всём периоде кредитования.");
            this.priceAnnuitet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itogSum);
            this.groupBox1.Controls.Add(this.itogPayment);
            this.groupBox1.Controls.Add(this.itogOverpayment);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(409, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат расчётов";
            // 
            // itogSum
            // 
            this.itogSum.Location = new System.Drawing.Point(38, 54);
            this.itogSum.Name = "itogSum";
            this.itogSum.ReadOnly = true;
            this.itogSum.Size = new System.Drawing.Size(287, 23);
            this.itogSum.TabIndex = 15;
            // 
            // itogPayment
            // 
            this.itogPayment.Location = new System.Drawing.Point(38, 157);
            this.itogPayment.Name = "itogPayment";
            this.itogPayment.ReadOnly = true;
            this.itogPayment.Size = new System.Drawing.Size(287, 23);
            this.itogPayment.TabIndex = 14;
            // 
            // itogOverpayment
            // 
            this.itogOverpayment.Location = new System.Drawing.Point(38, 101);
            this.itogOverpayment.Name = "itogOverpayment";
            this.itogOverpayment.ReadOnly = true;
            this.itogOverpayment.Size = new System.Drawing.Size(287, 23);
            this.itogOverpayment.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(331, 163);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 17);
            this.label21.TabIndex = 12;
            this.label21.Text = "руб.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(331, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "руб.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(331, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 17);
            this.label19.TabIndex = 10;
            this.label19.Text = "руб.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Ежемесячный платеж:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Переплата по кредиту:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Итоговая стоимость:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGrafik);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(8, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "График платежей";
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvGrafik.Location = new System.Drawing.Point(9, 19);
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.Size = new System.Drawing.Size(774, 277);
            this.dgvGrafik.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Месяц";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сумма платежа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Платеж по основному долгу, руб.";
            this.Column3.Name = "Column3";
            this.Column3.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Платеж по процентам, руб.";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Остаток основного долга, руб.";
            this.Column5.Name = "Column5";
            this.Column5.Width = 190;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butPriceGo);
            this.groupBox4.Controls.Add(this.butPriceClear);
            this.groupBox4.Controls.Add(this.priceDiffer);
            this.groupBox4.Controls.Add(this.priceAnnuitet);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.priceInitialType);
            this.groupBox4.Controls.Add(this.pricePeriodCombo);
            this.groupBox4.Controls.Add(this.pricePeriod);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.priceProcent);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.priceInitial);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.priceCreditSum1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(17, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 265);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расчёт кредита";
            // 
            // butPriceGo
            // 
            this.butPriceGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.butPriceGo.Location = new System.Drawing.Point(218, 202);
            this.butPriceGo.Name = "butPriceGo";
            this.butPriceGo.Size = new System.Drawing.Size(158, 39);
            this.butPriceGo.TabIndex = 60;
            this.butPriceGo.Text = "Расчитать стоимость";
            this.butPriceGo.UseVisualStyleBackColor = true;
            this.butPriceGo.Click += new System.EventHandler(this.butPriceGo_Click);
            // 
            // butPriceClear
            // 
            this.butPriceClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.butPriceClear.Location = new System.Drawing.Point(9, 202);
            this.butPriceClear.Name = "butPriceClear";
            this.butPriceClear.Size = new System.Drawing.Size(158, 39);
            this.butPriceClear.TabIndex = 59;
            this.butPriceClear.Text = "Очистить расчёты";
            this.butPriceClear.UseVisualStyleBackColor = true;
            this.butPriceClear.Click += new System.EventHandler(this.butPriceClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(6, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Вид платежа :";
            // 
            // priceInitialType
            // 
            this.priceInitialType.AutoCompleteCustomSource.AddRange(new string[] {
            "руб.",
            "%"});
            this.priceInitialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceInitialType.FormattingEnabled = true;
            this.priceInitialType.Items.AddRange(new object[] {
            "руб.",
            "%"});
            this.priceInitialType.Location = new System.Drawing.Point(308, 57);
            this.priceInitialType.Name = "priceInitialType";
            this.priceInitialType.Size = new System.Drawing.Size(42, 24);
            this.priceInitialType.TabIndex = 55;
            // 
            // pricePeriodCombo
            // 
            this.pricePeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pricePeriodCombo.FormattingEnabled = true;
            this.pricePeriodCombo.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.pricePeriodCombo.Location = new System.Drawing.Point(267, 114);
            this.pricePeriodCombo.Name = "pricePeriodCombo";
            this.pricePeriodCombo.Size = new System.Drawing.Size(56, 24);
            this.pricePeriodCombo.TabIndex = 54;
            // 
            // pricePeriod
            // 
            this.pricePeriod.Location = new System.Drawing.Point(179, 115);
            this.pricePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricePeriod.Name = "pricePeriod";
            this.pricePeriod.Size = new System.Drawing.Size(65, 23);
            this.pricePeriod.TabIndex = 53;
            this.pricePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Срок кредита:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(264, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "% годовых";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Процентная ставка:";
            // 
            // priceProcent
            // 
            this.priceProcent.DecimalPlaces = 2;
            this.priceProcent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceProcent.Location = new System.Drawing.Point(179, 89);
            this.priceProcent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceProcent.Name = "priceProcent";
            this.priceProcent.Size = new System.Drawing.Size(65, 23);
            this.priceProcent.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Сумма кредита:";
            // 
            // priceInitial
            // 
            this.priceInitial.Location = new System.Drawing.Point(179, 57);
            this.priceInitial.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.priceInitial.Name = "priceInitial";
            this.priceInitial.Size = new System.Drawing.Size(120, 23);
            this.priceInitial.TabIndex = 45;
            this.priceInitial.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Первоначальный взнос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(305, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "руб.";
            // 
            // priceCreditSum1
            // 
            this.priceCreditSum1.Location = new System.Drawing.Point(179, 26);
            this.priceCreditSum1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.priceCreditSum1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceCreditSum1.Name = "priceCreditSum1";
            this.priceCreditSum1.Size = new System.Drawing.Size(120, 23);
            this.priceCreditSum1.TabIndex = 43;
            this.priceCreditSum1.ThousandsSeparator = true;
            this.priceCreditSum1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(179, 102);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 61;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 600);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Кредитный калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCreditSum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipPaymentType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.TextBox itogSum;
        private System.Windows.Forms.TextBox itogPayment;
        private System.Windows.Forms.TextBox itogOverpayment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button butPriceGo;
        private System.Windows.Forms.Button butPriceClear;
        private System.Windows.Forms.RadioButton priceDiffer;
        private System.Windows.Forms.RadioButton priceAnnuitet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox priceInitialType;
        private System.Windows.Forms.ComboBox pricePeriodCombo;
        private System.Windows.Forms.NumericUpDown pricePeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown priceProcent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown priceInitial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceCreditSum1;
        private System.Windows.Forms.NumericUpDown priceCreditSum;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

