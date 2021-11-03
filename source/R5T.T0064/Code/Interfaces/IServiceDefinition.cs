using System;


namespace R5T.T0064
{
    /// <summary>
    /// An empty marker interface that can be implemented by a type to communicate that that type is a service definition.
    /// </summary>
    // Not itself marked with serivce marker definition attribute to avoid erroneous identification as a service definition.
    public interface IServiceDefinition : IServiceComponent
    {
    }
}
