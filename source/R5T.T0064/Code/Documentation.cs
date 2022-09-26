using System;


namespace R5T.T0064
{
    /// <summary>
    /// IServiceDefinition, IServiceImplementation, and IServiceComponent marker interfaces and accompanying attributes for identifying service component types.
    /// </summary>
    public static class Documentation
    {
        /// <summary>
        /// Marker interface names (like "IServiceDefinition") do not contain the word "Marker". The name "IServiceDefinition" was chosen over "IServiceDefinitionMarker" because all the types implementing this marker interface *are* service definitions, not service definition markers.
        /// It will make more sense to have an extension method to a service definition, instead of a service definition marker.
        /// Marker attributes however, are called "{X}MarkerAttribute" because they are indeed marker attributes.
        /// </summary>
        public static readonly object InterfaceNamesAreNotMarkers;
    }
}