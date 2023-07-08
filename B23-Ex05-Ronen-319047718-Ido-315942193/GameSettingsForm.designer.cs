namespace GameDesign
{
    partial class GameSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettingForm));
            this.m_labelPlayersText = new System.Windows.Forms.Label();
            this.m_LabelPlayerOne = new System.Windows.Forms.Label();
            this.cb_SecondPlayer = new System.Windows.Forms.CheckBox();
            this.m_LabelPlayerTwo = new System.Windows.Forms.Label();
            this.m_TextBoxPlayerOne = new System.Windows.Forms.TextBox();
            this.m_TextBoxPlayerTwo = new System.Windows.Forms.TextBox();
            this.m_LabelBoardSize = new System.Windows.Forms.Label();
            this.numericUD_BoardSize = new System.Windows.Forms.NumericUpDown();
            this.btn_Start = new System.Windows.Forms.Button();
            this.radio_EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.radio_MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.radio_HardRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_BoardSize)).BeginInit();
            this.SuspendLayout();
            // 
            // m_labelPlayersText
            // 
            this.m_labelPlayersText.AutoSize = true;
            this.m_labelPlayersText.Location = new System.Drawing.Point(11, 21);
            this.m_labelPlayersText.Name = "m_labelPlayersText";
            this.m_labelPlayersText.Size = new System.Drawing.Size(55, 17);
            this.m_labelPlayersText.TabIndex = 0;
            this.m_labelPlayersText.Text = "Players";
            // 
            // m_LabelPlayerOne
            // 
            this.m_LabelPlayerOne.AutoSize = true;
            this.m_LabelPlayerOne.Location = new System.Drawing.Point(29, 53);
            this.m_LabelPlayerOne.Name = "m_LabelPlayerOne";
            this.m_LabelPlayerOne.Size = new System.Drawing.Size(64, 17);
            this.m_LabelPlayerOne.TabIndex = 1;
            this.m_LabelPlayerOne.Text = "Player 1:";
            // 
            // cb_SecondPlayer
            // 
            this.cb_SecondPlayer.AutoSize = true;
            this.cb_SecondPlayer.Location = new System.Drawing.Point(32, 87);
            this.cb_SecondPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_SecondPlayer.Name = "cb_SecondPlayer";
            this.cb_SecondPlayer.Size = new System.Drawing.Size(18, 17);
            this.cb_SecondPlayer.TabIndex = 1;
            this.cb_SecondPlayer.UseVisualStyleBackColor = true;
            this.cb_SecondPlayer.CheckedChanged += new System.EventHandler(this.CheckBoxIsPlayingMode_CheckedChanged);
            // 
            // m_LabelPlayerTwo
            // 
            this.m_LabelPlayerTwo.AutoSize = true;
            this.m_LabelPlayerTwo.Location = new System.Drawing.Point(56, 87);
            this.m_LabelPlayerTwo.Name = "m_LabelPlayerTwo";
            this.m_LabelPlayerTwo.Size = new System.Drawing.Size(64, 17);
            this.m_LabelPlayerTwo.TabIndex = 3;
            this.m_LabelPlayerTwo.Text = "Player 2:";
            // 
            // m_TextBoxPlayerOne
            // 
            this.m_TextBoxPlayerOne.Location = new System.Drawing.Point(148, 53);
            this.m_TextBoxPlayerOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_TextBoxPlayerOne.MaxLength = 12;
            this.m_TextBoxPlayerOne.Name = "m_TextBoxPlayerOne";
            this.m_TextBoxPlayerOne.Size = new System.Drawing.Size(133, 22);
            this.m_TextBoxPlayerOne.TabIndex = 0;
            // 
            // m_TextBoxPlayerTwo
            // 
            this.m_TextBoxPlayerTwo.Enabled = false;
            this.m_TextBoxPlayerTwo.Location = new System.Drawing.Point(148, 87);
            this.m_TextBoxPlayerTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_TextBoxPlayerTwo.MaxLength = 12;
            this.m_TextBoxPlayerTwo.Name = "m_TextBoxPlayerTwo";
            this.m_TextBoxPlayerTwo.Size = new System.Drawing.Size(133, 22);
            this.m_TextBoxPlayerTwo.TabIndex = 2;
            this.m_TextBoxPlayerTwo.Text = "[Computer]";
            // 
            // m_LabelBoardSize
            // 
            this.m_LabelBoardSize.AutoSize = true;
            this.m_LabelBoardSize.Location = new System.Drawing.Point(11, 133);
            this.m_LabelBoardSize.Name = "m_LabelBoardSize";
            this.m_LabelBoardSize.Size = new System.Drawing.Size(77, 17);
            this.m_LabelBoardSize.TabIndex = 6;
            this.m_LabelBoardSize.Text = "Game Size";
            // 
            // numericUD_BoardSize
            // 
            this.numericUD_BoardSize.Location = new System.Drawing.Point(14, 160);
            this.numericUD_BoardSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUD_BoardSize.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUD_BoardSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUD_BoardSize.Name = "numericUD_BoardSize";
            this.numericUD_BoardSize.Size = new System.Drawing.Size(45, 22);
            this.numericUD_BoardSize.TabIndex = 3;
            this.numericUD_BoardSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(17, 256);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(264, 36);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // radio_EasyRadioButton
            // 
            this.radio_EasyRadioButton.AutoSize = true;
            this.radio_EasyRadioButton.Location = new System.Drawing.Point(146, 161);
            this.radio_EasyRadioButton.Name = "radio_EasyRadioButton";
            this.radio_EasyRadioButton.Size = new System.Drawing.Size(60, 21);
            this.radio_EasyRadioButton.TabIndex = 7;
            this.radio_EasyRadioButton.TabStop = true;
            this.radio_EasyRadioButton.Text = "Easy";
            this.radio_EasyRadioButton.UseVisualStyleBackColor = true;
            this.radio_EasyRadioButton.CheckedChanged += new System.EventHandler(this.rd_EasyRadioButton_CheckedChanged);
            // 
            // radio_MediumRadioButton
            // 
            this.radio_MediumRadioButton.AutoSize = true;
            this.radio_MediumRadioButton.Location = new System.Drawing.Point(146, 188);
            this.radio_MediumRadioButton.Name = "radio_MediumRadioButton";
            this.radio_MediumRadioButton.Size = new System.Drawing.Size(78, 21);
            this.radio_MediumRadioButton.TabIndex = 8;
            this.radio_MediumRadioButton.TabStop = true;
            this.radio_MediumRadioButton.Text = "Medium";
            this.radio_MediumRadioButton.UseVisualStyleBackColor = true;
            this.radio_MediumRadioButton.CheckedChanged += new System.EventHandler(this.rd_MediumRadioButton_CheckedChanged);
            // 
            // radio_HardRadioButton
            // 
            this.radio_HardRadioButton.AutoSize = true;
            this.radio_HardRadioButton.Location = new System.Drawing.Point(146, 215);
            this.radio_HardRadioButton.Name = "radio_HardRadioButton";
            this.radio_HardRadioButton.Size = new System.Drawing.Size(60, 21);
            this.radio_HardRadioButton.TabIndex = 9;
            this.radio_HardRadioButton.TabStop = true;
            this.radio_HardRadioButton.Text = "Hard";
            this.radio_HardRadioButton.UseVisualStyleBackColor = true;
            this.radio_HardRadioButton.CheckedChanged += new System.EventHandler(this.rd_HardRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Difficulty";
            // 
            // GameSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(296, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_HardRadioButton);
            this.Controls.Add(this.radio_MediumRadioButton);
            this.Controls.Add(this.radio_EasyRadioButton);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.numericUD_BoardSize);
            this.Controls.Add(this.m_LabelBoardSize);
            this.Controls.Add(this.m_TextBoxPlayerTwo);
            this.Controls.Add(this.m_TextBoxPlayerOne);
            this.Controls.Add(this.m_LabelPlayerTwo);
            this.Controls.Add(this.cb_SecondPlayer);
            this.Controls.Add(this.m_LabelPlayerOne);
            this.Controls.Add(this.m_labelPlayersText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameSettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_BoardSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_labelPlayersText;
        private System.Windows.Forms.Label m_LabelPlayerOne;
        private System.Windows.Forms.CheckBox cb_SecondPlayer;
        private System.Windows.Forms.Label m_LabelPlayerTwo;
        private System.Windows.Forms.TextBox m_TextBoxPlayerOne;
        private System.Windows.Forms.TextBox m_TextBoxPlayerTwo;
        private System.Windows.Forms.Label m_LabelBoardSize;
        private System.Windows.Forms.NumericUpDown numericUD_BoardSize;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.RadioButton radio_EasyRadioButton;
        private System.Windows.Forms.RadioButton radio_MediumRadioButton;
        private System.Windows.Forms.RadioButton radio_HardRadioButton;
        private System.Windows.Forms.Label label1;
    }
}

