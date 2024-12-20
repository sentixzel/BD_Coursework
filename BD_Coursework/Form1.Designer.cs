namespace BD_Coursework
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
            this.textBox_Nagruzka = new System.Windows.Forms.TextBox();
            this.textBox_Moschnost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NachNaprezhenie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Skorost = new System.Windows.Forms.TextBox();
            this.textBox_ProfilRemnya = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MinDiamShkiv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_UgolObhvata = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_TipDvigatelya = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_SposobNatyazheniya = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_Nagruzka
            // 
            this.textBox_Nagruzka.Location = new System.Drawing.Point(53, 52);
            this.textBox_Nagruzka.Name = "textBox_Nagruzka";
            this.textBox_Nagruzka.Size = new System.Drawing.Size(156, 20);
            this.textBox_Nagruzka.TabIndex = 0;
            this.textBox_Nagruzka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nagruzka_KeyPress);
            // 
            // textBox_Moschnost
            // 
            this.textBox_Moschnost.Location = new System.Drawing.Point(243, 52);
            this.textBox_Moschnost.Name = "textBox_Moschnost";
            this.textBox_Moschnost.Size = new System.Drawing.Size(156, 20);
            this.textBox_Moschnost.TabIndex = 1;
            this.textBox_Moschnost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Moschnost_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пусковая нагрузка, %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мощность, Вт";
            // 
            // textBox_NachNaprezhenie
            // 
            this.textBox_NachNaprezhenie.Location = new System.Drawing.Point(243, 99);
            this.textBox_NachNaprezhenie.Name = "textBox_NachNaprezhenie";
            this.textBox_NachNaprezhenie.Size = new System.Drawing.Size(156, 20);
            this.textBox_NachNaprezhenie.TabIndex = 3;
            this.textBox_NachNaprezhenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NachNaprezhenie_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начальное напряжение, МПа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скорость ремня, м/с";
            // 
            // textBox_Skorost
            // 
            this.textBox_Skorost.Location = new System.Drawing.Point(240, 327);
            this.textBox_Skorost.Name = "textBox_Skorost";
            this.textBox_Skorost.Size = new System.Drawing.Size(156, 20);
            this.textBox_Skorost.TabIndex = 8;
            this.textBox_Skorost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Skorost_KeyPress);
            // 
            // textBox_ProfilRemnya
            // 
            this.textBox_ProfilRemnya.Location = new System.Drawing.Point(53, 327);
            this.textBox_ProfilRemnya.MaxLength = 1;
            this.textBox_ProfilRemnya.Name = "textBox_ProfilRemnya";
            this.textBox_ProfilRemnya.Size = new System.Drawing.Size(156, 20);
            this.textBox_ProfilRemnya.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Профиль ремня";
            // 
            // textBox_MinDiamShkiv
            // 
            this.textBox_MinDiamShkiv.Location = new System.Drawing.Point(53, 192);
            this.textBox_MinDiamShkiv.Name = "textBox_MinDiamShkiv";
            this.textBox_MinDiamShkiv.Size = new System.Drawing.Size(156, 20);
            this.textBox_MinDiamShkiv.TabIndex = 4;
            this.textBox_MinDiamShkiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MinDiamShkiv_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Минимальный расчетный\r\nдиаметр шкива, мм";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Угол обхвата";
            // 
            // textBox_UgolObhvata
            // 
            this.textBox_UgolObhvata.Location = new System.Drawing.Point(243, 192);
            this.textBox_UgolObhvata.Name = "textBox_UgolObhvata";
            this.textBox_UgolObhvata.Size = new System.Drawing.Size(156, 20);
            this.textBox_UgolObhvata.TabIndex = 5;
            this.textBox_UgolObhvata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_UgolObhvata_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Тип двигателя";
            // 
            // textBox_TipDvigatelya
            // 
            this.textBox_TipDvigatelya.Location = new System.Drawing.Point(53, 99);
            this.textBox_TipDvigatelya.MaxLength = 1;
            this.textBox_TipDvigatelya.Name = "textBox_TipDvigatelya";
            this.textBox_TipDvigatelya.Size = new System.Drawing.Size(156, 20);
            this.textBox_TipDvigatelya.TabIndex = 2;
            this.textBox_TipDvigatelya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TipDvigatelya_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Способ натяжения";
            // 
            // textBox_SposobNatyazheniya
            // 
            this.textBox_SposobNatyazheniya.Location = new System.Drawing.Point(53, 242);
            this.textBox_SposobNatyazheniya.Name = "textBox_SposobNatyazheniya";
            this.textBox_SposobNatyazheniya.Size = new System.Drawing.Size(156, 20);
            this.textBox_SposobNatyazheniya.TabIndex = 6;
            this.textBox_SposobNatyazheniya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SposobNatyazheniya_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 19;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Значение должно быть равно 1 или 2";
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 15000;
            this.toolTip3.InitialDelay = 500;
            this.toolTip3.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 554);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_SposobNatyazheniya);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_TipDvigatelya);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_UgolObhvata);
            this.Controls.Add(this.textBox_MinDiamShkiv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ProfilRemnya);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Skorost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NachNaprezhenie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Moschnost);
            this.Controls.Add(this.textBox_Nagruzka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nagruzka;
        private System.Windows.Forms.TextBox textBox_Moschnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NachNaprezhenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Skorost;
        private System.Windows.Forms.TextBox textBox_ProfilRemnya;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MinDiamShkiv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_UgolObhvata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_TipDvigatelya;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_SposobNatyazheniya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

