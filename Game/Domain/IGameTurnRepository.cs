using System.Collections.Generic;

namespace Game.Domain
{
    public interface IGameTurnRepository
    {
        // TODO: Спроектировать интерфейс исходя из потребностей ConsoleApp
        GameTurnEntity Insert(GameTurnEntity user);
        List<GameTurnEntity> GetTurns(int count = 5);
    }
}