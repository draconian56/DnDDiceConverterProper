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
            this.diceSides = new System.Windows.Forms.TextBox();
            this.outPutBox = new System.Windows.Forms.TextBox();
            this.amountOfRolls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diceSides
            // 
            this.diceSides.Location = new System.Drawing.Point(22, 42);
            this.diceSides.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diceSides.Name = "diceSides";
            this.diceSides.Size = new System.Drawing.Size(127, 20);
            this.diceSides.TabIndex = 0;
            this.diceSides.TextChanged += new System.EventHandler(this.diceSides_TextChanged);
            // 
            // outPutBox
            // 
            this.outPutBox.Location = new System.Drawing.Point(341, 122);
            this.outPutBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outPutBox.Multiline = true;
            this.outPutBox.Name = "outPutBox";
            this.outPutBox.Size = new System.Drawing.Size(120, 203);
            this.outPutBox.TabIndex = 1;
            this.outPutBox.TextChanged += new System.EventHandler(this.outPutBox_TextChanged);
            // 
            // amountOfRolls
            // 
            this.amountOfRolls.Location = new System.Drawing.Point(341, 42);
            this.amountOfRolls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountOfRolls.Name = "amountOfRolls";
            this.amountOfRolls.Size = new System.Drawing.Size(120, 20);
            this.amountOfRolls.TabIndex = 2;
            this.amountOfRolls.TextChanged += new System.EventHandler(this.amountOfRolls_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "What sided dice?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many rolls?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(337, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calcButton.Location = new System.Drawing.Point(200, 85);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(110, 25);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Roll";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(200, 325);
            this.quitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(110, 24);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfRolls);
            this.Controls.Add(this.outPutBox);
            this.Controls.Add(this.diceSides);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DnD Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diceSides;
        private System.Windows.Forms.TextBox outPutBox;
        private System.Windows.Forms.TextBox amountOfRolls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button quitButton;
    }
}

