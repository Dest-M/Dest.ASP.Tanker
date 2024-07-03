namespace Dest.ASP.Tester.Game
{
    public interface IGameManager
    {

        IGameTanks GetGameTanks(IGameCredentials? credentials);

    }
}
