using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IScope : IDisposable
  {
    IScope? Parent { get; }
    
    IScope CreateChild(IScopeInstaller installer);
    IScope CreateChild(Action<IScopeContainerBuilder> installer);
    
    IObjectResolver ObjectResolver { get; }
  }
}