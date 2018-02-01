namespace DndDiceRoller {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.outPutBox = new System.Windows.Forms.TextBox();
            this.amountOfRolls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.oneAsTwo = new System.Windows.Forms.CheckBox();
            this.RerollOnes = new System.Windows.Forms.CheckBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.DinceNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // outPutBox
            // 
            this.outPutBox.Location = new System.Drawing.Point(702, 50);
            this.outPutBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outPutBox.Multiline = true;
            this.outPutBox.Name = "outPutBox";
            this.outPutBox.Size = new System.Drawing.Size(236, 339);
            this.outPutBox.TabIndex = 4;
            this.outPutBox.TextChanged += new System.EventHandler(this.outPutBox_TextChanged);
            // 
            // amountOfRolls
            // 
            this.amountOfRolls.Location = new System.Drawing.Point(390, 65);
            this.amountOfRolls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountOfRolls.Name = "amountOfRolls";
            this.amountOfRolls.Size = new System.Drawing.Size(236, 31);
            this.amountOfRolls.TabIndex = 1;
            this.amountOfRolls.TextChanged += new System.EventHandler(this.amountOfRolls_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "What sided dice?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(383, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many rolls?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(695, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results";
            // 
            // calcButton
            // 
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calcButton.Location = new System.Drawing.Point(406, 209);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(220, 48);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Roll";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Location = new System.Drawing.Point(406, 401);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(220, 46);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // oneAsTwo
            // 
            this.oneAsTwo.AutoSize = true;
            this.oneAsTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneAsTwo.Location = new System.Drawing.Point(55, 183);
            this.oneAsTwo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.oneAsTwo.Name = "oneAsTwo";
            this.oneAsTwo.Size = new System.Drawing.Size(215, 29);
            this.oneAsTwo.TabIndex = 6;
            this.oneAsTwo.Text = "Make all 1\'s as 2\'s";
            this.oneAsTwo.UseVisualStyleBackColor = true;
            this.oneAsTwo.CheckedChanged += new System.EventHandler(this.oneAsTwo_CheckedChanged);
            // 
            // RerollOnes
            // 
            this.RerollOnes.AutoSize = true;
            this.RerollOnes.Location = new System.Drawing.Point(73, 321);
            this.RerollOnes.Name = "RerollOnes";
            this.RerollOnes.Size = new System.Drawing.Size(161, 29);
            this.RerollOnes.TabIndex = 7;
            this.RerollOnes.Text = "Reroll all 1\'s";
            this.RerollOnes.UseVisualStyleBackColor = true;
            this.RerollOnes.CheckedChanged += new System.EventHandler(this.RerollOnes_CheckedChanged);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(715, 417);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(188, 46);
            this.ClearAll.TabIndex = 8;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // DinceNumber
            // 
            this.DinceNumber.FormattingEnabled = true;
            this.DinceNumber.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "12",
            "20",
            "100"});
            this.DinceNumber.Location = new System.Drawing.Point(42, 65);
            this.DinceNumber.Name = "DinceNumber";
            this.DinceNumber.Size = new System.Drawing.Size(254, 33);
            this.DinceNumber.TabIndex = 9;
            this.DinceNumber.SelectedIndexChanged += new System.EventHandler(this.DinceNumber_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 502);
            this.Controls.Add(this.DinceNumber);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.RerollOnes);
            this.Controls.Add(this.oneAsTwo);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfRolls);
            this.Controls.Add(this.outPutBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "DnD Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox outPutBox;
        private System.Windows.Forms.TextBox amountOfRolls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.CheckBox oneAsTwo;
        private System.Windows.Forms.CheckBox RerollOnes;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.ComboBox DinceNumber;
    }
}

