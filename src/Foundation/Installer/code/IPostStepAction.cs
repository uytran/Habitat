namespace xHelix.Foundation.Installer
{
  using System.Collections.Specialized;

  public interface IPostStepAction
  {
    void Run(NameValueCollection collection);
  }
}