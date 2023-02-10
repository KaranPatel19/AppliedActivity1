using AppliedActivity1.Models;
using System.Threading.Tasks;
namespace AppliedActivity1.Services
{
    interface IGOTDataStore<T>
    {
        Task<IEnumerable<GOT>> GetGOTAsync();
    }
}

