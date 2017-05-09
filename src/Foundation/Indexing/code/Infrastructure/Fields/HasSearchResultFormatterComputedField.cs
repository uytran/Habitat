﻿#region using



#endregion

namespace xHelix.Foundation.Indexing.Infrastructure.Fields
{
  using System.Linq;
  using Sitecore.ContentSearch;
  using Sitecore.ContentSearch.ComputedFields;
  using xHelix.Foundation.Indexing.Repositories;
  using xHelix.Foundation.SitecoreExtensions.Extensions;

  public class HasSearchResultFormatterComputedField : IComputedIndexField
  {
    public string FieldName { get; set; }
    public string ReturnType { get; set; }

    public object ComputeFieldValue(IIndexable indexable)
    {
      var indexItem = indexable as SitecoreIndexableItem;
      if (indexItem == null)
      {
        return null;
      }
      var item = indexItem.Item;

      return IndexingProviderRepository.SearchResultFormatters.Any(p => p.SupportedTemplates.Any(id => item.IsDerived(id)));
    }
  }
}