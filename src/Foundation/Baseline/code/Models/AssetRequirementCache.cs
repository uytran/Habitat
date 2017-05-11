namespace xHelix.Foundation.Baseline.Models
{
  using Sitecore.Caching;
  using Sitecore.Data;

  internal class AssetRequirementCache : CustomCache
  {
    public AssetRequirementCache(long maxSize) : base("xHelix.Foundation.AssetRequirements", maxSize)
    {
    }

    public AssetRequirementList Get(ID cacheKey)
    {
      return (AssetRequirementList)this.GetObject(cacheKey.ToString());
    }

    public void Set(ID cacheKey, AssetRequirementList requirementList)
    {
      this.SetObject(cacheKey.ToString(), requirementList);
    }
  }
}