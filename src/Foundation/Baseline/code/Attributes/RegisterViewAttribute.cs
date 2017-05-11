namespace xHelix.Foundation.Baseline.Attributes
{
  using System;

  public class RegisterViewAttribute : Attribute
  {
    public string Name { get; private set; }

    public RegisterViewAttribute(string name)
    {
      this.Name = name;
    }
  }
}