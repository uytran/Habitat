namespace xHelix.Foundation.Baseline.Pipelines.GetPageRendering
{
    using xHelix.Foundation.Baseline.Repositories;
    using Sitecore.Mvc.Pipelines.Response.GetPageRendering;

    public class ClearAssets : GetPageRenderingProcessor
    {
        public override void Process(GetPageRenderingArgs args)
        {
            AssetRepository.Current.Clear();
        }
    }
}