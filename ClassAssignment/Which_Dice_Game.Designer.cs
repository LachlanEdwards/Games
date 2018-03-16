namespace ClassAssignment {
    partial class Which_Dice_Game {
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
            this.diceGamesGroupBox = new System.Windows.Forms.GroupBox();
            this.twoDicePigRadioButton = new System.Windows.Forms.RadioButton();
            this.singleDiePigRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.diceGamesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // diceGamesGroupBox
            // 
            this.diceGamesGroupBox.Controls.Add(this.twoDicePigRadioButton);
            this.diceGamesGroupBox.Controls.Add(this.singleDiePigRadioButton);
            this.diceGamesGroupBox.Location = new System.Drawing.Point(16, 16);
            this.diceGamesGroupBox.Name = "diceGamesGroupBox";
            this.diceGamesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.diceGamesGroupBox.TabIndex = 0;
            this.diceGamesGroupBox.TabStop = false;
            this.diceGamesGroupBox.Text = "Select which Pig to play";
            // 
            // twoDicePigRadioButton
            // 
            this.twoDicePigRadioButton.AutoSize = true;
            this.twoDicePigRadioButton.Location = new System.Drawing.Point(7, 57);
            this.twoDicePigRadioButton.Name = "twoDicePigRadioButton";
            this.twoDicePigRadioButton.Size = new System.Drawing.Size(125, 24);
            this.twoDicePigRadioButton.TabIndex = 1;
            this.twoDicePigRadioButton.Text = "Two Dice Pig";
            this.twoDicePigRadioButton.UseVisualStyleBackColor = true;
            this.twoDicePigRadioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // singleDiePigRadioButton
            // 
            this.singleDiePigRadioButton.AutoSize = true;
            this.singleDiePigRadioButton.Location = new System.Drawing.Point(7, 26);
            this.singleDiePigRadioButton.Name = "singleDiePigRadioButton";
            this.singleDiePigRadioButton.Size = new System.Drawing.Size(132, 24);
            this.singleDiePigRadioButton.TabIndex = 0;
            this.singleDiePigRadioButton.Text = "Single Die Pig";
            this.singleDiePigRadioButton.UseVisualStyleBackColor = true;
            this.singleDiePigRadioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 123);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Which_Dice_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 291);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.diceGamesGroupBox);
            this.Name = "Which_Dice_Game";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Dice Games";
            this.Load += new System.EventHandler(this.DiceGames_Load);
            this.diceGamesGroupBox.ResumeLayout(false);
            this.diceGamesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox diceGamesGroupBox;
        private System.Windows.Forms.RadioButton twoDicePigRadioButton;
        private System.Windows.Forms.RadioButton singleDiePigRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}