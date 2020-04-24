namespace task8
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
            this.serch_type = new System.Windows.Forms.TextBox();
            this.number_of_house = new System.Windows.Forms.RadioButton();
            this.number_of_flat = new System.Windows.Forms.RadioButton();
            this.last_name = new System.Windows.Forms.RadioButton();
            this.type = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.RadioButton();
            this.show_serch = new System.Windows.Forms.TextBox();
            this.Serch = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.delete_text = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serch_type
            // 
            this.serch_type.Location = new System.Drawing.Point(294, 77);
            this.serch_type.Name = "serch_type";
            this.serch_type.Size = new System.Drawing.Size(100, 20);
            this.serch_type.TabIndex = 0;
            this.serch_type.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number_of_house
            // 
            this.number_of_house.AutoSize = true;
            this.number_of_house.Checked = true;
            this.number_of_house.Location = new System.Drawing.Point(434, 77);
            this.number_of_house.Name = "number_of_house";
            this.number_of_house.Size = new System.Drawing.Size(88, 17);
            this.number_of_house.TabIndex = 1;
            this.number_of_house.TabStop = true;
            this.number_of_house.Text = "Номер дома";
            this.number_of_house.UseVisualStyleBackColor = true;
            this.number_of_house.CheckedChanged += new System.EventHandler(this.number_of_house_CheckedChanged);
            this.number_of_house.Click += new System.EventHandler(this.number_of_house_Click);
            // 
            // number_of_flat
            // 
            this.number_of_flat.AutoSize = true;
            this.number_of_flat.Location = new System.Drawing.Point(434, 100);
            this.number_of_flat.Name = "number_of_flat";
            this.number_of_flat.Size = new System.Drawing.Size(111, 17);
            this.number_of_flat.TabIndex = 2;
            this.number_of_flat.TabStop = true;
            this.number_of_flat.Text = "Номер квартиры";
            this.number_of_flat.UseVisualStyleBackColor = true;
            this.number_of_flat.CheckedChanged += new System.EventHandler(this.number_of_flat_CheckedChanged);
            this.number_of_flat.Click += new System.EventHandler(this.number_of_flat_Click);
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(434, 124);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(74, 17);
            this.last_name.TabIndex = 3;
            this.last_name.TabStop = true;
            this.last_name.Text = "Владелец";
            this.last_name.UseVisualStyleBackColor = true;
            this.last_name.CheckedChanged += new System.EventHandler(this.last_name_CheckedChanged);
            this.last_name.Click += new System.EventHandler(this.last_name_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(434, 148);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(90, 17);
            this.type.TabIndex = 4;
            this.type.TabStop = true;
            this.type.Text = "Тип платежа";
            this.type.UseVisualStyleBackColor = true;
            this.type.CheckedChanged += new System.EventHandler(this.type_CheckedChanged);
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(434, 172);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(51, 17);
            this.date.TabIndex = 5;
            this.date.TabStop = true;
            this.date.Text = "Дата";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // show_serch
            // 
            this.show_serch.Location = new System.Drawing.Point(61, 211);
            this.show_serch.Multiline = true;
            this.show_serch.Name = "show_serch";
            this.show_serch.Size = new System.Drawing.Size(308, 210);
            this.show_serch.TabIndex = 6;
            // 
            // Serch
            // 
            this.Serch.Location = new System.Drawing.Point(152, 71);
            this.Serch.Name = "Serch";
            this.Serch.Size = new System.Drawing.Size(136, 94);
            this.Serch.TabIndex = 7;
            this.Serch.Text = "Поиск";
            this.Serch.UseVisualStyleBackColor = true;
            this.Serch.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(448, 211);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(76, 64);
            this.delete.TabIndex = 8;
            this.delete.Text = "Удалить запись с номером";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // delete_text
            // 
            this.delete_text.Location = new System.Drawing.Point(563, 233);
            this.delete_text.Name = "delete_text";
            this.delete_text.Size = new System.Drawing.Size(100, 20);
            this.delete_text.TabIndex = 9;
            this.delete_text.TextChanged += new System.EventHandler(this.delete_text_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(478, 373);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(185, 48);
            this.add.TabIndex = 10;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(448, 482);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(589, 482);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(719, 482);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(317, 584);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(448, 584);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(589, 584);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(719, 584);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Номер дома";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "номер квартиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "фамилия владельца";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "вид платежа";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "дата платежа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "сумма платежа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "процент пени";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "На сколько дней просрочен";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 694);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete_text);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Serch);
            this.Controls.Add(this.show_serch);
            this.Controls.Add(this.date);
            this.Controls.Add(this.type);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.number_of_flat);
            this.Controls.Add(this.number_of_house);
            this.Controls.Add(this.serch_type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serch_type;
        private System.Windows.Forms.RadioButton number_of_house;
        private System.Windows.Forms.RadioButton number_of_flat;
        private System.Windows.Forms.RadioButton last_name;
        private System.Windows.Forms.RadioButton type;
        private System.Windows.Forms.RadioButton date;
        private System.Windows.Forms.TextBox show_serch;
        private System.Windows.Forms.Button Serch;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox delete_text;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

