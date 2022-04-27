using System;


namespace R5T.T0064
{
    /// <summary>
    /// <para>Marks an interface as representing a service that is an unbound generic type (like ILogger&lt;&gt;). The interface is *not* the service, does *not* inherit from the service, and does *not* implement the service, just represents the service. This representation is useful in specifying IServiceAction&lt;T&gt; types. </para>
    /// <para>Example usage: [UnboundGenericServiceDefinitionMarker(typeof(ILogger&lt;&gt;))]</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public sealed class UnboundGenericServiceDefinitionMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceDefinition;
        public bool IsServiceDefinition
        {
            get
            {
                return this.zIsServiceDefinition;
            }
        }

        private readonly Type zUnboundType;
        public Type UnboundType
        {
            get
            {
                return this.zUnboundType;
            }
        }


        public UnboundGenericServiceDefinitionMarkerAttribute(
            Type unboundType,
            bool isServiceDefinition = true)
        {
            this.zIsServiceDefinition = isServiceDefinition;
            this.zUnboundType = unboundType;
        }
    }
}
