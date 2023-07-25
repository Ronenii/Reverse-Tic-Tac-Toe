namespace GameLogic
{
    public enum ePlayers
    {
        PlayerOne,
        PlayerTwo
    }

    public class Player
    {
        private ePlayers m_PlayerId;
        public ePlayers PlayerId => m_PlayerId;

        private int m_Score;
        public int Score { get; set; }

        private string m_Name;
        public string Name => m_Name;

        private readonly eCellType m_CellType;
        public eCellType CellType => m_CellType;

        

        public Player(ePlayers i_PlayerId, eCellType i_CellType, int i_Score, string i_Name)
        {
            m_PlayerId = i_PlayerId;
            m_CellType = i_CellType;
            m_Score = i_Score;
            m_Name = i_Name;
        }
    }
}
