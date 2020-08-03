namespace JustAFunProgram
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
            this.Dobro = new System.Windows.Forms.Label();
            this.Применить = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.CheckBox();
            this.notepad = new System.Windows.Forms.CheckBox();
            this.cmd = new System.Windows.Forms.CheckBox();
            this.calcAmount = new System.Windows.Forms.TextBox();
            this.notepadAmount = new System.Windows.Forms.TextBox();
            this.cmdAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shutdownPC = new System.Windows.Forms.CheckBox();
            this.restartPC = new System.Windows.Forms.CheckBox();
            this.BSoD = new System.Windows.Forms.CheckBox();
            this.toQuitProgram = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dobro
            // 
            this.Dobro.AutoSize = true;
            this.Dobro.Location = new System.Drawing.Point(12, 9);
            this.Dobro.Name = "Dobro";
            this.Dobro.Size = new System.Drawing.Size(270, 13);
            this.Dobro.TabIndex = 0;
            this.Dobro.Text = "Добро пожаловать! Выбери что ты хочешь сделать:";
            // 
            // Применить
            // 
            this.Применить.Location = new System.Drawing.Point(138, 203);
            this.Применить.Name = "Применить";
            this.Применить.Size = new System.Drawing.Size(86, 31);
            this.Применить.TabIndex = 1;
            this.Применить.Text = "Применить";
            this.Применить.UseVisualStyleBackColor = true;
            this.Применить.Click += new System.EventHandler(this.Применить_Click);
            // 
            // calc
            // 
            this.calc.AutoSize = true;
            this.calc.Location = new System.Drawing.Point(6, 23);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(150, 17);
            this.calc.TabIndex = 2;
            this.calc.Text = "открыть калькуляторов:";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.CheckedChanged += new System.EventHandler(this.calc_CheckedChanged);
            // 
            // notepad
            // 
            this.notepad.AutoSize = true;
            this.notepad.Location = new System.Drawing.Point(6, 46);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(127, 17);
            this.notepad.TabIndex = 3;
            this.notepad.Text = "открыть блокнотов:";
            this.notepad.UseVisualStyleBackColor = true;
            this.notepad.CheckedChanged += new System.EventHandler(this.notepad_CheckedChanged);
            // 
            // cmd
            // 
            this.cmd.AutoSize = true;
            this.cmd.Location = new System.Drawing.Point(6, 69);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(163, 17);
            this.cmd.TabIndex = 4;
            this.cmd.Text = "открыть командных строк:";
            this.cmd.UseVisualStyleBackColor = true;
            this.cmd.CheckedChanged += new System.EventHandler(this.cmd_CheckedChanged);
            // 
            // calcAmount
            // 
            this.calcAmount.Location = new System.Drawing.Point(402, 19);
            this.calcAmount.Name = "calcAmount";
            this.calcAmount.Size = new System.Drawing.Size(100, 20);
            this.calcAmount.TabIndex = 5;
            this.calcAmount.Text = "0";
            // 
            // notepadAmount
            // 
            this.notepadAmount.Location = new System.Drawing.Point(402, 43);
            this.notepadAmount.Name = "notepadAmount";
            this.notepadAmount.Size = new System.Drawing.Size(100, 20);
            this.notepadAmount.TabIndex = 6;
            this.notepadAmount.Text = "0";
            // 
            // cmdAmount
            // 
            this.cmdAmount.Location = new System.Drawing.Point(402, 67);
            this.cmdAmount.Name = "cmdAmount";
            this.cmdAmount.Size = new System.Drawing.Size(100, 20);
            this.cmdAmount.TabIndex = 7;
            this.cmdAmount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рандомизировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shutdownPC
            // 
            this.shutdownPC.AutoSize = true;
            this.shutdownPC.Location = new System.Drawing.Point(6, 92);
            this.shutdownPC.Name = "shutdownPC";
            this.shutdownPC.Size = new System.Drawing.Size(91, 17);
            this.shutdownPC.TabIndex = 9;
            this.shutdownPC.Text = "Выключить /";
            this.shutdownPC.UseVisualStyleBackColor = true;
            // 
            // restartPC
            // 
            this.restartPC.AutoSize = true;
            this.restartPC.Location = new System.Drawing.Point(94, 92);
            this.restartPC.Name = "restartPC";
            this.restartPC.Size = new System.Drawing.Size(198, 17);
            this.restartPC.TabIndex = 10;
            this.restartPC.Text = "Перезагрузить компьютер через:";
            this.restartPC.UseVisualStyleBackColor = true;
            this.restartPC.CheckedChanged += new System.EventHandler(this.restartPC_CheckedChanged);
            // 
            // BSoD
            // 
            this.BSoD.AutoSize = true;
            this.BSoD.Location = new System.Drawing.Point(6, 115);
            this.BSoD.Name = "BSoD";
            this.BSoD.Size = new System.Drawing.Size(101, 17);
            this.BSoD.TabIndex = 11;
            this.BSoD.Text = "Вызвать BSoD";
            this.BSoD.UseVisualStyleBackColor = true;
            this.BSoD.CheckedChanged += new System.EventHandler(this.BSoD_CheckedChanged);
            // 
            // toQuitProgram
            // 
            this.toQuitProgram.AutoSize = true;
            this.toQuitProgram.Location = new System.Drawing.Point(281, 211);
            this.toQuitProgram.Name = "toQuitProgram";
            this.toQuitProgram.Size = new System.Drawing.Size(232, 17);
            this.toQuitProgram.TabIndex = 12;
            this.toQuitProgram.Text = "после применения выйти из программы";
            this.toQuitProgram.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secAmount);
            this.groupBox1.Controls.Add(this.BSoD);
            this.groupBox1.Controls.Add(this.calc);
            this.groupBox1.Controls.Add(this.notepad);
            this.groupBox1.Controls.Add(this.cmdAmount);
            this.groupBox1.Controls.Add(this.cmd);
            this.groupBox1.Controls.Add(this.notepadAmount);
            this.groupBox1.Controls.Add(this.restartPC);
            this.groupBox1.Controls.Add(this.calcAmount);
            this.groupBox1.Controls.Add(this.shutdownPC);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 151);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные функции";
            // 
            // secAmount
            // 
            this.secAmount.Location = new System.Drawing.Point(402, 90);
            this.secAmount.Name = "secAmount";
            this.secAmount.Size = new System.Drawing.Size(100, 20);
            this.secAmount.TabIndex = 12;
            this.secAmount.Text = "в секундах";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(525, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toQuitProgram);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Применить);
            this.Controls.Add(this.Dobro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "JustAFunProgram; made by SCAPIFOL v 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dobro;
        private System.Windows.Forms.Button Применить;
        private System.Windows.Forms.CheckBox calc;
        private System.Windows.Forms.CheckBox notepad;
        private System.Windows.Forms.CheckBox cmd;
        private System.Windows.Forms.TextBox calcAmount;
        private System.Windows.Forms.TextBox notepadAmount;
        private System.Windows.Forms.TextBox cmdAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox shutdownPC;
        private System.Windows.Forms.CheckBox restartPC;
        private System.Windows.Forms.CheckBox BSoD;
        private System.Windows.Forms.CheckBox toQuitProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox secAmount;
    }
}

