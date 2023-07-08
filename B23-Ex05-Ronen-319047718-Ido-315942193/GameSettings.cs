namespace GameDesign
{
    public class GameSettings
    {
        private readonly string m_PlayerOneName;
        private readonly string m_PlayerTwoName;
        private readonly decimal m_BoardSize;
        private readonly bool _mIsModeAgainstPlayer;

        public GameSettings(string i_PlayerOneName, string i_PlayerTwoName, decimal i_BoardSize, bool iIsModeAgainstPlayer)
        {
            m_PlayerOneName = i_PlayerOneName;
            m_PlayerTwoName = i_PlayerTwoName;
            m_BoardSize = i_BoardSize;
            _mIsModeAgainstPlayer = iIsModeAgainstPlayer;
        }

        public string PlayerOneName => m_PlayerOneName;

        public string PlayerTwoName => m_PlayerTwoName;

        public decimal BoardSize => m_BoardSize;

        public bool IsModeAgainstPlayer => _mIsModeAgainstPlayer;
    }
}
