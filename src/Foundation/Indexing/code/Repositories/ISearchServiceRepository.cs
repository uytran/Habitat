namespace xHelix.Foundation.Indexing.Repositories
{
    using xHelix.Foundation.Indexing.Models;
    using xHelix.Foundation.Indexing.Services;

    public interface ISearchServiceRepository
    {
        SearchService Get(ISearchSettings searchSettings);
    }
}