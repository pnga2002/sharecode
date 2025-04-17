using System;
using System.Collections.Generic;
using System.Linq;

public class DIContainer
{
    // _registrations: ds các cái service mà mình muón nó tự khởi tạo : Các service được đăng ký
    // key: interface (IServiceA, IServiceB,....)
    // value: class thực thực thi interface tưởng ứng (inplement interface)
    private readonly Dictionary<Type, Type> _registrations = new();

    // Đăng ký 1 interface với 1 class cụ thể
    public void Register<TService, TImplementation>()
    {
        // tại key có kiểu dữ liệu là TService có value là kiểu tương ứng thực thi TImplementation
        _registrations[typeof(TService)] = typeof(TImplementation);
        // đăng ký service với implementation   A và B
    }

    // Resolve 1 service => instance
    // tạo ra instance(đối tượng) của service đã đăng kýa
    public TService Resolve<TService>()
    {
        return (TService)Resolve(typeof(TService));
    }


/// <summary>
/// Resolve 1 service
/// Tìm kiếm trong danh sách các service đã đăng ký
/// </summary>
/// <param name="serviceType"></param>
/// <returns></returns>
/// <exception cref="Exception"></exception>
    private object Resolve(Type serviceType)
    {
        // Nếu là interface đã đăng ký thì lấy implementation
        if (_registrations.ContainsKey(serviceType))
        {
            var implementationType = _registrations[serviceType];
            return CreateInstance(implementationType);
        }

        // Nếu là class cụ thể, chưa đăng ký thì tự khởi tạo
        if (!serviceType.IsAbstract)
        {
            return CreateInstance(serviceType);
        }

        throw new Exception($"Không thể resolve kiểu {serviceType.Name}");
    }

// kiểm tra quét qua các param -> kiểm xem đã khởi tạo chưa 
    private object CreateInstance(Type implementationType)
    {
        // Kiểm tra xem có constructor nào không
        var constructor = implementationType.GetConstructors().First();
        // lấy ra các param -> danh sách
        var parameters = constructor.GetParameters()
            .Select(p => Resolve(p.ParameterType))
            .ToArray();

        return Activator.CreateInstance(implementationType, parameters);
    }
}
