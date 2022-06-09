using System;


namespace R5T.T0064
{
    /// <summary>
    /// Marks an interface as being a draft service definition.
    /// Drafting allows service definitions to be quickly created when needed, then reviewed and moved to a permanent location at a later time.
    /// This attribute is useful in surveying draft service definitions to create a kind of TODO list of service definitions that should be reviewed.
    /// Also allows specifying that an interface is *not* a service definition. (Useful for decorating extraneous intefaces in files that happen to be in the canonical draft service definition files location.)
    /// Not inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public sealed class DraftServiceDefinitionMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceDefinition;
        public bool IsServiceDefinition
        {
            get
            {
                return this.zIsServiceDefinition;
            }
        }


        public DraftServiceDefinitionMarkerAttribute(
            bool isServiceDefinition = true)
        {
            this.zIsServiceDefinition = isServiceDefinition;
        }
    }
}
