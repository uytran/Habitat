namespace xHelix.Foundation.Baseline.Tests.Extensions
{
  using FluentAssertions;
  using xHelix.Foundation.Baseline.Extensions;
  using Xunit;

  public class StringExtensionsTests
  {
    [Theory]
    [InlineData("TestString", "Test String")]
    [InlineData("Test String", "Test String")]
    public void Humanize_ShouldReturnValueSplittedWithWhitespaces(string input, string expected)
    {
      input.Humanize().Should().Be(expected);
    }

    [Theory]
    [InlineData("  ", "none")]
    [InlineData("", "none")]
    [InlineData("somePath", "url('somePath')")]
    public void ToCssUrlValue_ShouldReturnValueSplittedWithWhitespaces(string input, string expected)
    {
      input.ToCssUrlValue().Should().Be(expected);
    }
  }
}