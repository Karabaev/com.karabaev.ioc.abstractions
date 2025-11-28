using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IScopeContainerBuilder
  {
    IRegistrationBuilder Register<T>();
    IRegistrationBuilder Register(Type type);
    IInstanceRegistrationBuilder RegisterInstance(object instance);
  }
}