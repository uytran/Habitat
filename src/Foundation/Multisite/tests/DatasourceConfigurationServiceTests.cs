namespace xHelix.Foundation.Multisite.Tests
{
  using FluentAssertions;
  using xHelix.Foundation.Multisite.Providers;
  using xHelix.Foundation.Multisite.Tests.Extensions;
  using Xunit;

  public class DatasourceConfigurationServiceTests
  {
    [Theory]
    [AutoDbData]
    public void GetSiteDatasourceConfigurationName_CorrectSettingsString_ReturnSettingName()
    {
      var setting = "media";
      var name = $"site:{setting}";
      var settingName = DatasourceConfigurationService.GetSiteDatasourceConfigurationName(name);
      settingName.Should().BeEquivalentTo(setting);
    }

    [Theory]
    [AutoDbData]
    public void GetSiteDatasourceConfigurationName_IncorrectSettings_NullOrEmpty()
    {
      var setting = "med.ia";
      var name = $"site:{setting}";
      var settingName = DatasourceConfigurationService.GetSiteDatasourceConfigurationName(name);
      settingName.Should().BeNullOrEmpty();
    }
  }
}
