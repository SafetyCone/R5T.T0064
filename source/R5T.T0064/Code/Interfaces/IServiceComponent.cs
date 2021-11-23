using System;


namespace R5T.T0064
{
    /// <summary>
    /// Empty marker interface to communicate that that type is a service component.
    /// This interface should not be used directly. Instead, service definitions should implement <see cref="IServiceDefinition"/>, and service implementations should implement <see cref="IServiceImplementation"/>.
    /// </summary>
    public interface IServiceComponent
    {
    }
}
