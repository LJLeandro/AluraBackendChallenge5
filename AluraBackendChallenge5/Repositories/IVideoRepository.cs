using AluraBackendChallenge5.Data.ValueObjects;

namespace AluraBackendChallenge5.Repositories
{
    public interface IVideoRepository : IDataRepository<VideoVO>
    {
        public Task<IEnumerable<VideoVO>> FindVideosByCategoryId(int id);

        public Task<IEnumerable<VideoVO>> FindVideosByName(string name);
    }
}
