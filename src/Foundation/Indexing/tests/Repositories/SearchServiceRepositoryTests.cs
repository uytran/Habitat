namespace xHelix.Foundation.Indexing.Tests
{
  using FluentAssertions;
  using Ploeh.AutoFixture.Xunit2;
  using xHelix.Foundation.Indexing.Models;
  using xHelix.Foundation.Indexing.Repositories;
  using xHelix.Foundation.Indexing.Services;
  using xHelix.Foundation.Testing.Attributes;
  using Xunit;

  public class SearchServiceRepositoryTests
  {
    [Theory]
    [AutoDbData]
    public void Get_ReturnsSearchService([Frozen] ISearchSettings settings, SearchServiceRepository serviceRepository)
    {
      var result = serviceRepository.Get(settings);
      result.Should().BeOfType<SearchService>();
    }
  }
}
