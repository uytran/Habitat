namespace xHelix.Foundation.Installer
{
  public interface IProcessRunner
  {
    void Run(string commandPath, string arguments);
  }
}