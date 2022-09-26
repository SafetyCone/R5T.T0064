using System;


namespace R5T.T0064
{
    /// <summary>
    /// Marks a method parameter as *not* being a service component.
    /// This is useful for constructor-based service implementations for which constructors take data values.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class NotServiceComponentAttribute : Attribute
    {
        // No un-ignore option.
    }
}
