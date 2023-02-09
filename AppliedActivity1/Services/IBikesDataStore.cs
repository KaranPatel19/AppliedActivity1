using AndroidAppliedActivity1.Model;
namespace AndroidAppliedActivity1.Services
{
	interface IBikeDataStore<T>
	{
		Task<IEnumerable<bikes>>GetBikesAsync(int count);
	}
}

