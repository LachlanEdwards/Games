namespace ClassAssignment {
    partial class Pig_Game_Form {
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
            this.pigLabelWhosTurnTo = new System.Windows.Forms.Label();
            this.Pig_rollOrHoldLabel = new System.Windows.Forms.Label();
            this.pigPictureBox = new System.Windows.Forms.PictureBox();
            this.playerOneTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.holdButton = new System.Windows.Forms.Button();
            this.anotherGameGroupBox = new System.Windows.Forms.GroupBox();
            this.noAnotherGameRadioButton = new System.Windows.Forms.RadioButton();
            this.yesAnotherGameRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).BeginInit();
            this.anotherGameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pigLabelWhosTurnTo
            // 
            this.pigLabelWhosTurnTo.AutoSize = true;
            this.pigLabelWhosTurnTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigLabelWhosTurnTo.Location = new System.Drawing.Point(20, 15);
            this.pigLabelWhosTurnTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pigLabelWhosTurnTo.Name = "pigLabelWhosTurnTo";
            this.pigLabelWhosTurnTo.Size = new System.Drawing.Size(231, 37);
            this.pigLabelWhosTurnTo.TabIndex = 0;
            this.pigLabelWhosTurnTo.Text = "Whose turn to";
            // 
            // Pig_rollOrHoldLabel
            // 
            this.Pig_rollOrHoldLabel.AutoSize = true;
            this.Pig_rollOrHoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pig_rollOrHoldLabel.Location = new System.Drawing.Point(20, 51);
            this.Pig_rollOrHoldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pig_rollOrHoldLabel.Name = "Pig_rollOrHoldLabel";
            this.Pig_rollOrHoldLabel.Size = new System.Drawing.Size(214, 37);
            this.Pig_rollOrHoldLabel.TabIndex = 1;
            this.Pig_rollOrHoldLabel.Text = "Roll or Hold?";
            // 
            // pigPictureBox
            // 
            this.pigPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pigPictureBox.Location = new System.Drawing.Point(259, 15);
            this.pigPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pigPictureBox.Name = "pigPictureBox";
            this.pigPictureBox.Size = new System.Drawing.Size(133, 125);
            this.pigPictureBox.TabIndex = 2;
            this.pigPictureBox.TabStop = false;
            // 
            // playerOneTotalLabel
            // 
            this.playerOneTotalLabel.AutoSize = true;
            this.playerOneTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneTotalLabel.Location = new System.Drawing.Point(400, 22);
            this.playerOneTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneTotalLabel.Name = "playerOneTotalLabel";
            this.playerOneTotalLabel.Size = new System.Drawing.Size(236, 37);
            this.playerOneTotalLabel.TabIndex = 3;
            this.playerOneTotalLabel.Text = "Player 1 Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 2 Total:";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Enabled = false;
            this.playerOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneTextBox.Location = new System.Drawing.Point(651, 19);
            this.playerOneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(297, 44);
            this.playerOneTextBox.TabIndex = 5;
            this.playerOneTextBox.Text = "0";
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Enabled = false;
            this.playerTwoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoTextBox.Location = new System.Drawing.Point(651, 71);
            this.playerTwoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(297, 44);
            this.playerTwoTextBox.TabIndex = 6;
            this.playerTwoTextBox.Text = "0";
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Lime;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(20, 148);
            this.rollButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(267, 62);
            this.rollButton.TabIndex = 7;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Red;
            this.holdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdButton.Location = new System.Drawing.Point(295, 148);
            this.holdButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(267, 62);
            this.holdButton.TabIndex = 8;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // anotherGameGroupBox
            // 
            this.anotherGameGroupBox.Controls.Add(this.noAnotherGameRadioButton);
            this.anotherGameGroupBox.Controls.Add(this.yesAnotherGameRadioButton);
            this.anotherGameGroupBox.Enabled = false;
            this.anotherGameGroupBox.Location = new System.Drawing.Point(684, 411);
            this.anotherGameGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anotherGameGroupBox.Name = "anotherGameGroupBox";
            this.anotherGameGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anotherGameGroupBox.Size = new System.Drawing.Size(267, 125);
            this.anotherGameGroupBox.TabIndex = 9;
            this.anotherGameGroupBox.TabStop = false;
            this.anotherGameGroupBox.Text = "Another Game?";
            // 
            // noAnotherGameRadioButton
            // 
            this.noAnotherGameRadioButton.AutoSize = true;
            this.noAnotherGameRadioButton.Location = new System.Drawing.Point(9, 71);
            this.noAnotherGameRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noAnotherGameRadioButton.Name = "noAnotherGameRadioButton";
            this.noAnotherGameRadioButton.Size = new System.Drawing.Size(70, 29);
            this.noAnotherGameRadioButton.TabIndex = 1;
            this.noAnotherGameRadioButton.TabStop = true;
            this.noAnotherGameRadioButton.Text = "No";
            this.noAnotherGameRadioButton.UseVisualStyleBackColor = true;
            this.noAnotherGameRadioButton.Click += new System.EventHandler(this.anotherGameRadioButton_Click);
            // 
            // yesAnotherGameRadioButton
            // 
            this.yesAnotherGameRadioButton.AutoSize = true;
            this.yesAnotherGameRadioButton.Location = new System.Drawing.Point(9, 32);
            this.yesAnotherGameRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yesAnotherGameRadioButton.Name = "yesAnotherGameRadioButton";
            this.yesAnotherGameRadioButton.Size = new System.Drawing.Size(81, 29);
            this.yesAnotherGameRadioButton.TabIndex = 0;
            this.yesAnotherGameRadioButton.TabStop = true;
            this.yesAnotherGameRadioButton.Text = "Yes";
            this.yesAnotherGameRadioButton.UseVisualStyleBackColor = true;
            this.yesAnotherGameRadioButton.Click += new System.EventHandler(this.anotherGameRadioButton_Click);
            // 
            // Pig_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 555);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pig_Game_Form";
            this.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.Text = "Pig";
            ((System.ComponentModel.ISupportInitialize)(this.pigPictureBox)).EndInit();
            this.anotherGameGroupBox.ResumeLayout(false);
            this.anotherGameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pigLabelWhosTurnTo;
        private System.Windows.Forms.Label Pig_rollOrHoldLabel;
        private System.Windows.Forms.PictureBox pigPictureBox;
        private System.Windows.Forms.Label playerOneTotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.GroupBox anotherGameGroupBox;
        private System.Windows.Forms.RadioButton noAnotherGameRadioButton;
        private System.Windows.Forms.RadioButton yesAnotherGameRadioButton;
    }
}