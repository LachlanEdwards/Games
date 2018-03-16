namespace ClassAssignment {
    partial class Pig_with_Two_Dice_Form {
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
            this.components = new System.ComponentModel.Container();
            this.anotherGameGroupBox = new System.Windows.Forms.GroupBox();
            this.noAnotherGameRadioButton = new System.Windows.Forms.RadioButton();
            this.yesAnotherGameRadioButton = new System.Windows.Forms.RadioButton();
            this.holdButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerOneTotalLabel = new System.Windows.Forms.Label();
            this.pigPictureBox = new System.Windows.Forms.PictureBox();
            this.Pig_rollOrHoldLabel = new System.Windows.Forms.Label();
            this.pigLabelWhosTurnTo = new System.Windows.Forms.Label();
            this.pigPictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.anotherGameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // anotherGameGroupBox
            // 
            this.anotherGameGroupBox.Controls.Add(this.noAnotherGameRadioButton);
            this.anotherGameGroupBox.Controls.Add(this.yesAnotherGameRadioButton);
            this.anotherGameGroupBox.Enabled = false;
            this.anotherGameGroupBox.Location = new System.Drawing.Point(456, 264);
            this.anotherGameGroupBox.Name = "anotherGameGroupBox";
            this.anotherGameGroupBox.Size = new System.Drawing.Size(178, 80);
            this.anotherGameGroupBox.TabIndex = 19;
            this.anotherGameGroupBox.TabStop = false;
            this.anotherGameGroupBox.Text = "Another Game?";
            // 
            // noAnotherGameRadioButton
            // 
            this.noAnotherGameRadioButton.AutoSize = true;
            this.noAnotherGameRadioButton.Location = new System.Drawing.Point(6, 45);
            this.noAnotherGameRadioButton.Name = "noAnotherGameRadioButton";
            this.noAnotherGameRadioButton.Size = new System.Drawing.Size(47, 21);
            this.noAnotherGameRadioButton.TabIndex = 1;
            this.noAnotherGameRadioButton.TabStop = true;
            this.noAnotherGameRadioButton.Text = "No";
            this.noAnotherGameRadioButton.UseVisualStyleBackColor = true;
            this.noAnotherGameRadioButton.Click += new System.EventHandler(this.anotherGameRadioButton_Click);
            // 
            // yesAnotherGameRadioButton
            // 
            this.yesAnotherGameRadioButton.AutoSize = true;
            this.yesAnotherGameRadioButton.Location = new System.Drawing.Point(6, 20);
            this.yesAnotherGameRadioButton.Name = "yesAnotherGameRadioButton";
            this.yesAnotherGameRadioButton.Size = new System.Drawing.Size(53, 21);
            this.yesAnotherGameRadioButton.TabIndex = 0;
            this.yesAnotherGameRadioButton.TabStop = true;
            this.yesAnotherGameRadioButton.Text = "Yes";
            this.yesAnotherGameRadioButton.UseVisualStyleBackColor = true;
            this.yesAnotherGameRadioButton.Click += new System.EventHandler(this.anotherGameRadioButton_Click);
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Red;
            this.holdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdButton.Location = new System.Drawing.Point(197, 96);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(178, 40);
            this.holdButton.TabIndex = 18;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Lime;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(13, 96);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(178, 40);
            this.rollButton.TabIndex = 17;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Enabled = false;
            this.playerTwoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoTextBox.Location = new System.Drawing.Point(522, 46);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(111, 30);
            this.playerTwoTextBox.TabIndex = 16;
            this.playerTwoTextBox.Text = "0";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Enabled = false;
            this.playerOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneTextBox.Location = new System.Drawing.Point(522, 13);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(111, 30);
            this.playerOneTextBox.TabIndex = 15;
            this.playerOneTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Player 2 Total:";
            // 
            // playerOneTotalLabel
            // 
            this.playerOneTotalLabel.AutoSize = true;
            this.playerOneTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneTotalLabel.Location = new System.Drawing.Point(363, 13);
            this.playerOneTotalLabel.Name = "playerOneTotalLabel";
            this.playerOneTotalLabel.Size = new System.Drawing.Size(153, 25);
            this.playerOneTotalLabel.TabIndex = 13;
            this.playerOneTotalLabel.Text = "Player 1 Total:";
            // 
            // pigPictureBox
            // 
            this.pigPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pigPictureBox.Location = new System.Drawing.Point(173, 11);
            this.pigPictureBox.Name = "pigPictureBox";
            this.pigPictureBox.Size = new System.Drawing.Size(89, 80);
            this.pigPictureBox.TabIndex = 12;
            this.pigPictureBox.TabStop = false;
            // 
            // Pig_rollOrHoldLabel
            // 
            this.Pig_rollOrHoldLabel.AutoSize = true;
            this.Pig_rollOrHoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pig_rollOrHoldLabel.Location = new System.Drawing.Point(13, 34);
            this.Pig_rollOrHoldLabel.Name = "Pig_rollOrHoldLabel";
            this.Pig_rollOrHoldLabel.Size = new System.Drawing.Size(135, 25);
            this.Pig_rollOrHoldLabel.TabIndex = 11;
            this.Pig_rollOrHoldLabel.Text = "Roll or Hold?";
            // 
            // pigLabelWhosTurnTo
            // 
            this.pigLabelWhosTurnTo.AutoSize = true;
            this.pigLabelWhosTurnTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigLabelWhosTurnTo.Location = new System.Drawing.Point(13, 11);
            this.pigLabelWhosTurnTo.Name = "pigLabelWhosTurnTo";
            this.pigLabelWhosTurnTo.Size = new System.Drawing.Size(147, 25);
            this.pigLabelWhosTurnTo.TabIndex = 10;
            this.pigLabelWhosTurnTo.Text = "Whose turn to";
            // 
            // pigPictureBox2
            // 
            this.pigPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pigPictureBox2.Location = new System.Drawing.Point(268, 10);
            this.pigPictureBox2.Name = "pigPictureBox2";
            this.pigPictureBox2.Size = new System.Drawing.Size(89, 80);
            this.pigPictureBox2.TabIndex = 20;
            this.pigPictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pig_with_Two_Dice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 355);
            this.Controls.Add(this.pigPictureBox2);
            this.Controls.Add(this.anotherGameGroupBox);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerOneTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerOneTotalLabel);
            this.Controls.Add(this.pigPictureBox);
            this.Controls.Add(this.Pig_rollOrHoldLabel);
            this.Controls.Add(this.pigLabelWhosTurnTo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pig_with_Two_Dice_Form";
            this.Text = " Pig with Two Dice";
            this.anotherGameGroupBox.ResumeLayout(false);
            this.anotherGameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox anotherGameGroupBox;
        private System.Windows.Forms.RadioButton noAnotherGameRadioButton;
        private System.Windows.Forms.RadioButton yesAnotherGameRadioButton;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerOneTotalLabel;
        private System.Windows.Forms.PictureBox pigPictureBox;
        private System.Windows.Forms.Label Pig_rollOrHoldLabel;
        private System.Windows.Forms.Label pigLabelWhosTurnTo;
        private System.Windows.Forms.PictureBox pigPictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}