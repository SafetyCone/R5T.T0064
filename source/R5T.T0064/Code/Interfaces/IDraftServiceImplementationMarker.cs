using System;


namespace R5T.T0064
{
    /// <summary>
    /// Empty marker interface that can be implemented by a type to communicate that that type is a draft service implementation.
    /// </summary>
    // Not itself marked with serivce implementation marker attribute to avoid erroneous identification as a service implementation. Also, service implementations must be classes, not interfaces.
    public interface IDraftServiceImplementationMarker : IServiceComponentMarker
    {
    }
}
