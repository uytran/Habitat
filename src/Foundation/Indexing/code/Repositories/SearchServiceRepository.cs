namespace xHelix.Foundation.Indexing.Repositories
{
    using xHelix.Foundation.DependencyInjection;
    using xHelix.Foundation.Indexing.Models;
    using xHelix.Foundation.Indexing.Services;

    [Service(typeof(ISearchServiceRepository))]
    public class SearchServiceRepository : ISearchServiceRepository
    {
        public virtual SearchService Get(ISearchSettings settings)
        {
            return new SearchService(settings);
        }
    }
}