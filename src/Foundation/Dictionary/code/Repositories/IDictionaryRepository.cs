using xHelix.Foundation.Dictionary.Models;
using Sitecore.Sites;

namespace xHelix.Foundation.Dictionary.Repositories
{
  public interface IDictionaryRepository
  {
    Models.Dictionary Get(SiteContext site);
  }
}