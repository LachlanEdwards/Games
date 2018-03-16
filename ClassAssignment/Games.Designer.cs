namespace ClassAssignment {
    partial class GamesForm {
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.gameTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.cardGameRadioButton = new System.Windows.Forms.RadioButton();
            this.diceGameRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(16, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(299, 44);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Interactive Games:";
            this.titleLabel.UseCompatibleTextRendering = true;
            // 
            // gameTypeGroupBox
            // 
            this.gameTypeGroupBox.Controls.Add(this.cardGameRadioButton);
            this.gameTypeGroupBox.Controls.Add(this.diceGameRadioButton);
            this.gameTypeGroupBox.Location = new System.Drawing.Point(16, 64);
            this.gameTypeGroupBox.Name = "gameTypeGroupBox";
            this.gameTypeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.gameTypeGroupBox.TabIndex = 1;
            this.gameTypeGroupBox.TabStop = false;
            this.gameTypeGroupBox.Text = "Select Game Type:";
            // 
            // cardGameRadioButton
            // 
            this.cardGameRadioButton.AutoSize = true;
            this.cardGameRadioButton.Location = new System.Drawing.Point(7, 57);
            this.cardGameRadioButton.Name = "cardGameRadioButton";
            this.cardGameRadioButton.Size = new System.Drawing.Size(116, 24);
            this.cardGameRadioButton.TabIndex = 1;
            this.cardGameRadioButton.Text = "Card Game";
            this.cardGameRadioButton.UseVisualStyleBackColor = true;
            this.cardGameRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // diceGameRadioButton
            // 
            this.diceGameRadioButton.AutoSize = true;
            this.diceGameRadioButton.Location = new System.Drawing.Point(7, 26);
            this.diceGameRadioButton.Name = "diceGameRadioButton";
            this.diceGameRadioButton.Size = new System.Drawing.Size(114, 24);
            this.diceGameRadioButton.TabIndex = 0;
            this.diceGameRadioButton.Text = "Dice Game";
            this.diceGameRadioButton.UseVisualStyleBackColor = true;
            this.diceGameRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(16, 171);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 50);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(16, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 291);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameTypeGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "GamesForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Games";
            this.gameTypeGroupBox.ResumeLayout(false);
            this.gameTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox gameTypeGroupBox;
        private System.Windows.Forms.RadioButton cardGameRadioButton;
        private System.Windows.Forms.RadioButton diceGameRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

