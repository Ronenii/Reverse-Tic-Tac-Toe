namespace GameDesign
{
    public class GameSettings
    {
        private readonly string m_PlayerOneName;
        private readonly string m_PlayerTwoName;
        private readonly decimal m_BoardSize;
        private readonly bool m_ModeAgainstPlayer;
        private readonly int r_Difficulty;

        public GameSettings(string i_PlayerOneName, string i_PlayerTwoName, decimal i_BoardSize, bool i_IsModeAgainstPlayer, int i_Difficulty)
        {
            m_PlayerOneName = i_PlayerOneName;
            m_PlayerTwoName = i_PlayerTwoName;
            m_BoardSize = i_BoardSize;
            m_ModeAgainstPlayer = i_IsModeAgainstPlayer;
            r_Difficulty = i_Difficulty;
        }

        public string PlayerOneName => m_PlayerOneName;

        public string PlayerTwoName => m_PlayerTwoName;

        public decimal BoardSize => m_BoardSize;

        public bool ModeAgainstPlayer => m_ModeAgainstPlayer;

        public int Difficulty => r_Difficulty;
    }
}
