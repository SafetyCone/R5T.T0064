using System;


namespace R5T.T0064
{
    /// <summary>
    /// Marks a method parameter as being a service component (either definition or implementation), even if it its type cannot be found in the list of service definitions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class ParameterServiceComponentMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceComponent;
        public bool IsServiceComponent
        {
            get
            {
                return this.zIsServiceComponent;
            }
        }


        public ParameterServiceComponentMarkerAttribute(
            bool isServiceComponent = true)
        {
            this.zIsServiceComponent = isServiceComponent;
        }
    }
}
