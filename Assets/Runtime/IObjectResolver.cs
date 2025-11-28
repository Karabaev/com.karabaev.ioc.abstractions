using System;

namespace com.karabaev.ioc.abstractions
{
  public interface IObjectResolver
  {
    object Resolve(Type type);
    bool TryResolve(Type type, out object obj);
    T Resolve<T>();
    bool TryResolve<T>(Type type, out T obj);

    void Inject(object target);
  }
}