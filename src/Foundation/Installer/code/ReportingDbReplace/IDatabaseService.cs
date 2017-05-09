namespace xHelix.Foundation.Installer.ReportingDbReplace
{
  public interface IDatabaseService
  {
    void ReplaceDatabase(string connectionString, string dbReplacementPath);
  }
}