namespace xHelix.Foundation.Baseline.Pipelines.GetPageRendering
{
    using System.Linq;
    using Sitecore;
    using Sitecore.Data;
    using Sitecore.Data.Fields;
    using Sitecore.Data.Items;
    using xHelix.Foundation.Baseline.Models;
    using xHelix.Foundation.Baseline.Repositories;
    using xHelix.Foundation.Baseline.Extensions;
    using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
    using Sitecore.Mvc.Presentation;

    public class AddThemeAssets : AddRenderingAssets
    {
        public override void Process(GetPageRenderingArgs args)
        {
            this.AddAssets();
        }

        private void AddAssets()
        {
            var themeItem = this.GetThemeItem(PageContext.Current.Item);
            if (themeItem == null || !themeItem.IsDerived(Templates.RenderingAssets.ID))
                return;

            AddAssetsFromItem(themeItem);
        }

        private Item GetThemeItem(Item item)
        {
            var hasThemeItems = item.GetAncestorsAndSelfOfTemplate(Templates.HasTheme.ID);
            var ancestorItem = hasThemeItems.Select(i => i.TargetItem(Templates.HasTheme.Fields.Theme)).FirstOrDefault(i => i != null && i.IsDerived(Templates.RenderingAssets.ID));
            if (ancestorItem != null)
                return ancestorItem;
            var hasThemeItem = Context.Site.GetContextItem(Templates.HasTheme.ID);
            return hasThemeItem?.TargetItem(Templates.HasTheme.Fields.Theme);
        }
    }
}