using System;

namespace Game.Domain
{
    public class GameTurnEntity
    {
        //TODO: Придумать какие свойства должны быть в этом классе, чтобы сохранять всю информацию о закончившемся туре.
        public Guid WinnerId { get; set; }
        public PlayerDecision? WinnerDecision { get; set; }
        public bool IsDraw { get; set; }
        public int TurnNumber {get; set; }
        public DateTime FinishedAt { get; set; }
    }
}