using System;


namespace R5T.T0064
{
    /// <summary>
    /// Specifies the single service definition interface to use for a service implementation class with multiple service definitions in its base types list.
    /// Useful in situations where a service implementation implements multiple service definition interfaces, only one of which should be considered its service definition. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class SpecifyServiceDefinitionAttribute : Attribute
    {
        private readonly Type zType;
        public Type Type
        {
            get
            {
                return this.zType;
            }
        }


        public SpecifyServiceDefinitionAttribute(Type type)
        {
            this.zType = type;
        }
    }
}
