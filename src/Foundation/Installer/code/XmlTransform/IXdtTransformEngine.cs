namespace xHelix.Foundation.Installer.XmlTransform
{
  public interface IXdtTransformEngine
  {
    void ApplyConfigTransformation(string xmlFile, string transformFile, string targetFile);
  }
}