using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IScopeContainerBuilder
  {
    IRegistrationBuilder Register<T>();
    IRegistrationBuilder Register<TInterface, TInstance>();
    IRegistrationBuilder Register(Type type);
    IRegistrationBuilder RegisterInstance<TInterface>(TInterface instance);
  }
}