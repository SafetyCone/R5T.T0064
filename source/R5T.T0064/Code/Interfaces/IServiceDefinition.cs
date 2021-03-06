using System;


namespace R5T.T0064
{
    /// <summary>
    /// Empty marker interface that can be implemented by a type to communicate that that type is a service definition.
    /// </summary>
    // Not itself marked with the service definition marker attribute to avoid erroneous identification of this interface as a service definition.
    public interface IServiceDefinition : IServiceComponentMarker
    {
    }
}
