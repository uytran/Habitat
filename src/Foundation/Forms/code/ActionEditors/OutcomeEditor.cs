namespace xHelix.Foundation.Forms.ActionEditors
{
    using System;
    using Sitecore;
    using Sitecore.Data;
    using xHelix.Foundation.Forms.Services;
    using xHelix.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Web.UI.HtmlControls;
    using Constants = xHelix.Foundation.Forms.Constants;

    public class OutcomeEditor : BaseActionEditor
    {
        public OutcomeEditor(ISheerService sheerService) : base(sheerService)
        {
        }

        public OutcomeEditor() : this(new SheerService())
        {
        }

        public DataContext ItemDataContext { get; set; }
        public DataTreeview ItemLister { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!Context.ClientPage.IsEvent)
            {
                var outcomeId = this.Parameters[Constants.OutcomeParameter];
                if (!string.IsNullOrEmpty(outcomeId) && ID.IsID(outcomeId))
                {
                    this.ItemDataContext.DefaultItem = outcomeId;
                }
            }

            this.ItemLister.OnDblClick += this.OnOK;
        }

        protected override void OnOK(object sender, EventArgs args)
        {
            var item = this.ItemLister?.GetSelectionItem();
            if (item == null || !item.IsDerived(Templates.Outcome.ID))
            {
                this.SheerService.Alert("Please, select outcome");
                return;
            }

            this.Parameters.Set(Constants.OutcomeParameter, item.ID.ToString());

            base.OnOK(sender, args);
        }
    }
}