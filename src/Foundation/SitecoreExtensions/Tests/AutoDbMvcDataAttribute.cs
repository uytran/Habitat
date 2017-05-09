namespace xHelix.Foundation.SitecoreExtensions.Tests
{
  using System.Collections.Specialized;
  using System.Web;
  using System.Web.Mvc;
  using NSubstitute;
  using xHelix.Foundation.Testing.Attributes;

  public class AutoDbMvcDataAttribute : AutoDbDataAttribute
  {
    public AutoDbMvcDataAttribute()
    {
      Fixture.Customize<ControllerContext>(c => c.Without(x => x.DisplayMode));
    }
  }
}