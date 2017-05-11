namespace xHelix.Foundation.Baseline.Tests
{
  using System.Collections.Specialized;
  using System.Web;
  using System.Web.Mvc;
  using NSubstitute;
  using xHelix.Foundation.Baseline.Attributes;

  public class AutoDbMvcDataAttribute : AutoDbDataAttribute
  {
    public AutoDbMvcDataAttribute()
    {
      Fixture.Customize<ControllerContext>(c => c.Without(x => x.DisplayMode));
    }
  }
}