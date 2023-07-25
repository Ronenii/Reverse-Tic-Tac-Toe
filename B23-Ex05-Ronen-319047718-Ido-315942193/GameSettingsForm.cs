using System;
using System.Windows.Forms;

namespace GameDesign
{
    public partial class GameSettingForm : Form
    {
        private const string k_AiName = "Computer";
        GameSettings m_GameSettings = null;
        public GameSettings Settings { get => m_GameSettings; }

        public GameSettingForm()
        {
            InitializeComponent();
            FormClosing += GameSettingForm_FormClosing;
        }

        private void CheckBoxIsPlayingMode_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_TextBoxPlayerTwo.Text = "";
                m_TextBoxPlayerTwo.Enabled = true;
                radio_EasyRadioButton.Enabled = false;
                radio_MediumRadioButton.Enabled = false;
                radio_HardRadioButton.Enabled = false;
            }
            else
            {
                m_TextBoxPlayerTwo.Text = "[Computer]";
                m_TextBoxPlayerTwo.Enabled = false;
                radio_EasyRadioButton.Enabled = true;
                radio_MediumRadioButton.Enabled = true;
                radio_HardRadioButton.Enabled = true;
            }
        }

        // Shows MessageBox asking user if he is sure he wants to quit
        private void GameSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            int difficulty = 0;

            if (!cb_SecondPlayer.Checked)
            {
                m_TextBoxPlayerTwo.Text = k_AiName;
            }

            if (radio_EasyRadioButton.Checked)
            {
                difficulty = 3;
            }

            if (radio_MediumRadioButton.Checked)
            {
                difficulty = 5;
            }

            if (radio_HardRadioButton.Checked)
            {
                difficulty = 7;
            }

            m_GameSettings = new GameSettings(m_TextBoxPlayerOne.Text,
                m_TextBoxPlayerTwo.Text, numericUD_BoardSize.Value,
                cb_SecondPlayer.Checked,difficulty);

            this.Dispose();
        }

        private void rd_EasyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_EasyRadioButton.Checked)
            {
                radio_MediumRadioButton.Checked = false;
                radio_HardRadioButton.Checked = false;
            }
        }

        private void rd_MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_MediumRadioButton.Checked)
            {
                radio_EasyRadioButton.Checked = false;
                radio_HardRadioButton.Checked = false;
            }
        }

        private void rd_HardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_MediumRadioButton.Checked)
            {
                radio_EasyRadioButton.Checked = false;
                radio_HardRadioButton.Checked = false;
            }
        }

        private void GameSettingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
