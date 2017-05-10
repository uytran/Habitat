namespace xHelix.Foundation.Baseline.Tests.Repositories
{
    using FluentAssertions;
    using xHelix.Foundation.Baseline.Repositories;
    using xHelix.Foundation.Testing.Attributes;
    using Sitecore.Mvc.Common;
    using Sitecore.Mvc.Presentation;
    using Xunit;

    public class RenderingPropertiesRepositoryTests
    {
        [Theory]
        [AutoDbData]
        public void ShouldInitObjectProperties()
        {
            var rendering = new Rendering();
            rendering.Properties = new RenderingProperties(rendering) {["Parameters"] = "property1=5&property2=10"};

            var repository = new RenderingPropertiesRepository();
            var resultObject = repository.Get<Model>(rendering);
            resultObject.Property1.ShouldBeEquivalentTo(5);
            resultObject.Property2.ShouldBeEquivalentTo(10);
        }

        public class Model
        {
            public string Property1 { get; set; }

            public string Property2 { get; set; }
        }
    }
}