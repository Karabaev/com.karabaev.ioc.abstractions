using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IScope : IDisposable
  {
    public string Name { get; }
    IScope? Parent { get; }
    IObjectResolver ObjectResolver { get; }
    
    IScope CreateChild(string name, IScopeInstaller installer);
    IScope CreateChild(string name, Action<IScopeContainerBuilder> installer);
  }
}