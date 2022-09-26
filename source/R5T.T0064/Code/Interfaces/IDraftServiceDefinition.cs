using System;


namespace R5T.T0064
{
    /// <summary>
    /// Empty marker interface that can be implemented by a type to communicate that that type is a draft service definition.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.InterfaceNamesAreNotMarkers" path="/summary"/>
    /// </remarks>
    // Not itself marked with the service definition marker attribute to avoid erroneous identification of this interface as a service definition.
    public interface IDraftServiceDefinition : IServiceComponent
    {
    }
}
