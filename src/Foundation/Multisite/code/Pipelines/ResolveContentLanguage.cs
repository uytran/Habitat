﻿namespace xHelix.Foundation.Multisite.Pipelines
{
    using Sitecore;
    using Sitecore.Configuration;
    using Sitecore.Links;
    using Sitecore.Pipelines.HttpRequest;

    /// <summary>
    /// Overrides Sitecore.ExperienceEditor.Pipelines.HttpRequest.ResolveContentLanguage.
    /// Preserve current domain in returned link
    /// </summary>
    public class ResolveContentLanguage : Sitecore.ExperienceEditor.Pipelines.HttpRequest.ResolveContentLanguage
    {
        private const string DefaultSiteSetting = "Preview.DefaultSite";

        public override void Process(HttpRequestArgs args)
        {
            if (Context.Item == null)
                return;

            var siteContext = LinkManager.GetPreviewSiteContext(Context.Item);

            using (new SettingsSwitcher(DefaultSiteSetting, siteContext.Name))
            {
                base.Process(args);
            }
        }
    }
}