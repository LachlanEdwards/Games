namespace ClassAssignment {
    partial class Which_Card_Game {
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
            this.whichCardGameLabel = new System.Windows.Forms.Label();
            this.whichCardGameComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whichCardGameLabel
            // 
            this.whichCardGameLabel.AutoSize = true;
            this.whichCardGameLabel.Location = new System.Drawing.Point(15, 12);
            this.whichCardGameLabel.Name = "whichCardGameLabel";
            this.whichCardGameLabel.Size = new System.Drawing.Size(374, 37);
            this.whichCardGameLabel.TabIndex = 0;
            this.whichCardGameLabel.Text = "Choose a Game to play";
            // 
            // whichCardGameComboBox
            // 
            this.whichCardGameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichCardGameComboBox.FormattingEnabled = true;
            this.whichCardGameComboBox.Items.AddRange(new object[] {
            "Solitare",
            "Twenty-One"});
            this.whichCardGameComboBox.Location = new System.Drawing.Point(22, 53);
            this.whichCardGameComboBox.Name = "whichCardGameComboBox";
            this.whichCardGameComboBox.Size = new System.Drawing.Size(200, 28);
            this.whichCardGameComboBox.TabIndex = 1;
            this.whichCardGameComboBox.SelectedIndexChanged += new System.EventHandler(this.whichCardGameComboBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(22, 87);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(400, 291);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.whichCardGameComboBox);
            this.Controls.Add(this.whichCardGameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Which_Card_Game";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Card Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whichCardGameLabel;
        private System.Windows.Forms.ComboBox whichCardGameComboBox;
        private System.Windows.Forms.Button exitButton;
    }
}