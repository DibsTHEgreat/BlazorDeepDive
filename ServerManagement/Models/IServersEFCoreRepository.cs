
namespace ServerManagement.Models
{
    public interface IServersEFCoreRepository
    {
        void AddServer(Server server);
        void DeleteServer(int Id);
        Server? GetServerById(int Id);
        List<Server> GetServers();
        List<Server> GetServersByCity(string cityName);
        List<Server> SearchServers(string serverFilter);
        void UpdateServer(int Id, Server server);
    }
}