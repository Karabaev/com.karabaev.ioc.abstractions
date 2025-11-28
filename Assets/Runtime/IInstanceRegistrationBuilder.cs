using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IInstanceRegistrationBuilder
  {
    IInstanceRegistrationBuilder As<TInterface>();
    IInstanceRegistrationBuilder As(Type type);
    IInstanceRegistrationBuilder AsSelf();
    IInstanceRegistrationBuilder AsImplementedInterfaces();

    void Build();
  }
}