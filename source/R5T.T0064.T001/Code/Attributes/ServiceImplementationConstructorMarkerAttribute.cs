using System;


namespace R5T.T0064
{
    /// <summary>
    /// If a service implementation has multiple constructors (which for Automatic Construction, they shouldn't), allow marking one of them as the constructor that should be used.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public sealed class ServiceImplementationConstructorMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceImplementationConstructor;
        public bool IsServiceImplementationConstructor
        {
            get
            {
                return this.zIsServiceImplementationConstructor;
            }
        }


        public ServiceImplementationConstructorMarkerAttribute(
            bool isServiceImplementationConstructor = true)
        {
            this.zIsServiceImplementationConstructor = isServiceImplementationConstructor;
        }
    }
}
