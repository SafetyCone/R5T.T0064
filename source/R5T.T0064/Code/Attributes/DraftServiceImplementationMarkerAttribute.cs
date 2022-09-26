using System;

using R5T.T0143;


namespace R5T.T0064
{
    /// <summary>
    /// Marks a class as being a draft service implementation.
    /// Drafting allows service implementations to be quickly created when needed, then reviewed and moved to a permanent location at a later time.
    /// This attribute is useful in surveying draft service implementations to create a kind of TODO list of service implementations that should be reviewed.
    /// Also allows marking a class as *not* being a service implementation. (Useful for decorating extraneous classes in files that happen to be in the canonical service implementation code files location.)
    /// Not inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftServiceImplementationMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceImplementation;
        public bool IsServiceImplementation
        {
            get
            {
                return this.zIsServiceImplementation;
            }
        }


        public DraftServiceImplementationMarkerAttribute(
            bool isServiceImplementation = true)
        {
            this.zIsServiceImplementation = isServiceImplementation;
        }
    }
}
