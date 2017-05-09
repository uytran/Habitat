namespace xHelix.Foundation.Indexing.Services
{
    using Sitecore.ContentSearch;
    using xHelix.Foundation.DependencyInjection;

    [Service]
    public class SearchIndexResolver
    {
        public virtual ISearchIndex GetIndex(SitecoreIndexableItem contextItem)
        {
            return ContentSearchManager.GetIndex(contextItem);
        }
    }
}