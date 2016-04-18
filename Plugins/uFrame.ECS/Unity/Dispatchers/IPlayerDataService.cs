namespace uFrame.ECS
{
    public interface IPlayerDataService
    {
        void Save(SavePlayerData data);
        void Load(LoadPlayerData data);
    }
}