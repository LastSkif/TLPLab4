
namespace TIP_lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputStringTextBox = new System.Windows.Forms.TextBox();
            this.addTranslationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showResultTextBox = new System.Windows.Forms.TextBox();
            this.checkStringButton = new System.Windows.Forms.Button();
            this.tableTranslationsListBox = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.deleteTranslationButton = new System.Windows.Forms.Button();
            this.clearTableButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.machineGroupBox = new System.Windows.Forms.GroupBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.loadMachineStateButton = new System.Windows.Forms.Button();
            this.inputTransitionsGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.inputStringsGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hintInput = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.machineGroupBox.SuspendLayout();
            this.inputTransitionsGroupBox.SuspendLayout();
            this.inputStringsGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputStringTextBox
            // 
            this.inputStringTextBox.Location = new System.Drawing.Point(6, 21);
            this.inputStringTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputStringTextBox.Multiline = true;
            this.inputStringTextBox.Name = "inputStringTextBox";
            this.inputStringTextBox.Size = new System.Drawing.Size(427, 22);
            this.inputStringTextBox.TabIndex = 1;
            // 
            // addTranslationButton
            // 
            this.addTranslationButton.Location = new System.Drawing.Point(339, 21);
            this.addTranslationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTranslationButton.Name = "addTranslationButton";
            this.addTranslationButton.Size = new System.Drawing.Size(123, 28);
            this.addTranslationButton.TabIndex = 2;
            this.addTranslationButton.Text = "Добавить";
            this.addTranslationButton.UseVisualStyleBackColor = true;
            this.addTranslationButton.Click += new System.EventHandler(this.addTranslationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.MaximumSize = new System.Drawing.Size(175, 150);
            this.label1.MinimumSize = new System.Drawing.Size(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "(q";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 27);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 21);
            this.label2.MaximumSize = new System.Drawing.Size(175, 150);
            this.label2.MinimumSize = new System.Drawing.Size(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = ",";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(89, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(20, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 21);
            this.label3.MaximumSize = new System.Drawing.Size(175, 150);
            this.label3.MinimumSize = new System.Drawing.Size(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = ",";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 27);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(20, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(163, 21);
            this.label4.MaximumSize = new System.Drawing.Size(175, 150);
            this.label4.MinimumSize = new System.Drawing.Size(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = ")->(q";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 27);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(20, 20);
            this.textBox6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(258, 21);
            this.label5.MaximumSize = new System.Drawing.Size(175, 150);
            this.label5.MinimumSize = new System.Drawing.Size(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = ",";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(280, 27);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(20, 20);
            this.textBox7.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(306, 21);
            this.label6.MaximumSize = new System.Drawing.Size(175, 150);
            this.label6.MinimumSize = new System.Drawing.Size(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = ")";
            // 
            // showResultTextBox
            // 
            this.showResultTextBox.Location = new System.Drawing.Point(3, 110);
            this.showResultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showResultTextBox.Multiline = true;
            this.showResultTextBox.Name = "showResultTextBox";
            this.showResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showResultTextBox.Size = new System.Drawing.Size(439, 281);
            this.showResultTextBox.TabIndex = 14;
            // 
            // checkStringButton
            // 
            this.checkStringButton.Location = new System.Drawing.Point(183, 47);
            this.checkStringButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkStringButton.Name = "checkStringButton";
            this.checkStringButton.Size = new System.Drawing.Size(82, 22);
            this.checkStringButton.TabIndex = 16;
            this.checkStringButton.Text = "Проверить";
            this.checkStringButton.UseVisualStyleBackColor = true;
            this.checkStringButton.Click += new System.EventHandler(this.checkStringButton_Click);
            // 
            // tableTranslationsListBox
            // 
            this.tableTranslationsListBox.FormattingEnabled = true;
            this.tableTranslationsListBox.ItemHeight = 15;
            this.tableTranslationsListBox.Location = new System.Drawing.Point(6, 21);
            this.tableTranslationsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableTranslationsListBox.Name = "tableTranslationsListBox";
            this.tableTranslationsListBox.Size = new System.Drawing.Size(456, 229);
            this.tableTranslationsListBox.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(740, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 15);
            this.label18.TabIndex = 36;
            // 
            // deleteTranslationButton
            // 
            this.deleteTranslationButton.Location = new System.Drawing.Point(467, 21);
            this.deleteTranslationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteTranslationButton.Name = "deleteTranslationButton";
            this.deleteTranslationButton.Size = new System.Drawing.Size(82, 71);
            this.deleteTranslationButton.TabIndex = 37;
            this.deleteTranslationButton.Text = "Удалить";
            this.deleteTranslationButton.UseVisualStyleBackColor = true;
            this.deleteTranslationButton.Click += new System.EventHandler(this.deleteTranslationButton_Click);
            // 
            // clearTableButton
            // 
            this.clearTableButton.Location = new System.Drawing.Point(468, 96);
            this.clearTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearTableButton.Name = "clearTableButton";
            this.clearTableButton.Size = new System.Drawing.Size(82, 70);
            this.clearTableButton.TabIndex = 48;
            this.clearTableButton.Text = "Очистить";
            this.clearTableButton.UseVisualStyleBackColor = true;
            this.clearTableButton.Click += new System.EventHandler(this.clearTableButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.machineGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.inputTransitionsGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.resultLabel);
            this.splitContainer1.Panel2.Controls.Add(this.inputStringsGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.showResultTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1011, 394);
            this.splitContainer1.SplitterDistance = 562;
            this.splitContainer1.TabIndex = 49;
            // 
            // machineGroupBox
            // 
            this.machineGroupBox.Controls.Add(this.filePath);
            this.machineGroupBox.Controls.Add(this.loadFromFileButton);
            this.machineGroupBox.Controls.Add(this.loadMachineStateButton);
            this.machineGroupBox.Controls.Add(this.clearTableButton);
            this.machineGroupBox.Controls.Add(this.deleteTranslationButton);
            this.machineGroupBox.Controls.Add(this.tableTranslationsListBox);
            this.machineGroupBox.Location = new System.Drawing.Point(3, 3);
            this.machineGroupBox.Name = "machineGroupBox";
            this.machineGroupBox.Size = new System.Drawing.Size(556, 313);
            this.machineGroupBox.TabIndex = 51;
            this.machineGroupBox.TabStop = false;
            this.machineGroupBox.Text = "Автомат";
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filePath.Location = new System.Drawing.Point(6, 268);
            this.filePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filePath.Multiline = true;
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(456, 36);
            this.filePath.TabIndex = 17;
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadFromFileButton.Location = new System.Drawing.Point(468, 268);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(81, 36);
            this.loadFromFileButton.TabIndex = 53;
            this.loadFromFileButton.Text = "Загрузить из файла";
            this.loadFromFileButton.UseVisualStyleBackColor = true;
            this.loadFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // loadMachineStateButton
            // 
            this.loadMachineStateButton.Location = new System.Drawing.Point(468, 171);
            this.loadMachineStateButton.Name = "loadMachineStateButton";
            this.loadMachineStateButton.Size = new System.Drawing.Size(82, 79);
            this.loadMachineStateButton.TabIndex = 52;
            this.loadMachineStateButton.Text = "Загрузить автомат по умолчанию";
            this.loadMachineStateButton.UseVisualStyleBackColor = true;
            this.loadMachineStateButton.Click += new System.EventHandler(this.loadMachineStateButton_Click);
            // 
            // inputTransitionsGroupBox
            // 
            this.inputTransitionsGroupBox.Controls.Add(this.addTranslationButton);
            this.inputTransitionsGroupBox.Controls.Add(this.label1);
            this.inputTransitionsGroupBox.Controls.Add(this.textBox3);
            this.inputTransitionsGroupBox.Controls.Add(this.label2);
            this.inputTransitionsGroupBox.Controls.Add(this.textBox4);
            this.inputTransitionsGroupBox.Controls.Add(this.label3);
            this.inputTransitionsGroupBox.Controls.Add(this.textBox5);
            this.inputTransitionsGroupBox.Controls.Add(this.label4);
            this.inputTransitionsGroupBox.Controls.Add(this.textBox6);
            this.inputTransitionsGroupBox.Controls.Add(this.label5);
            this.inputTransitionsGroupBox.Controls.Add(this.textBox7);
            this.inputTransitionsGroupBox.Controls.Add(this.label6);
            this.inputTransitionsGroupBox.Location = new System.Drawing.Point(3, 322);
            this.inputTransitionsGroupBox.Name = "inputTransitionsGroupBox";
            this.inputTransitionsGroupBox.Size = new System.Drawing.Size(556, 69);
            this.inputTransitionsGroupBox.TabIndex = 50;
            this.inputTransitionsGroupBox.TabStop = false;
            this.inputTransitionsGroupBox.Text = "Добавление перехода";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Вывод:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(71, 7);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 37;
            // 
            // inputStringsGroupBox
            // 
            this.inputStringsGroupBox.Controls.Add(this.inputStringTextBox);
            this.inputStringsGroupBox.Controls.Add(this.checkStringButton);
            this.inputStringsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.inputStringsGroupBox.Name = "inputStringsGroupBox";
            this.inputStringsGroupBox.Size = new System.Drawing.Size(439, 92);
            this.inputStringsGroupBox.TabIndex = 36;
            this.inputStringsGroupBox.TabStop = false;
            this.inputStringsGroupBox.Text = "Цепочка";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintInput});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1035, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hintInput
            // 
            this.hintInput.Name = "hintInput";
            this.hintInput.Size = new System.Drawing.Size(668, 17);
            this.hintInput.Text = "qo - начальное состояние, qf - конечное состояние,  Z - пустой символ в стеке, *" +
    " - конец цепочки и удаление символа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 431);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label18);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.machineGroupBox.ResumeLayout(false);
            this.machineGroupBox.PerformLayout();
            this.inputTransitionsGroupBox.ResumeLayout(false);
            this.inputTransitionsGroupBox.PerformLayout();
            this.inputStringsGroupBox.ResumeLayout(false);
            this.inputStringsGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputStringTextBox;
        private System.Windows.Forms.Button addTranslationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox showResultTextBox;
        private System.Windows.Forms.Button checkStringButton;
        private System.Windows.Forms.ListBox tableTranslationsListBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button deleteTranslationButton;
        private System.Windows.Forms.Button clearTableButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox inputTransitionsGroupBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hintInput;
        private System.Windows.Forms.GroupBox inputStringsGroupBox;
        private System.Windows.Forms.GroupBox machineGroupBox;
        private System.Windows.Forms.Button loadMachineStateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button loadFromFileButton;
        private System.Windows.Forms.TextBox filePath;
    }
}

