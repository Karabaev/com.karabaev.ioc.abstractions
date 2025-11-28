using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IRegistrationBuilder
  {
    IRegistrationBuilder As<TInterface>();
    IRegistrationBuilder AsImplementedInterfaces();
    IRegistrationBuilder AsSelf();
    IRegistrationBuilder As(Type type);

    IRegistrationBuilder AsSingleton();
    IRegistrationBuilder AsScoped();
    IRegistrationBuilder AsTransient();
  }
}