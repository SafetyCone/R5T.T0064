﻿using System;


namespace R5T.T0064
{
    /// <summary>
    /// Marks an interface as being a service definition. Not inherited.
    /// Also allows specifying that an interface is *not* a service definition. (Useful for decorating extraneous members that also happen to be in a service definition file.)
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public sealed class ServiceDefinitionMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceDefinition;
        public bool IsServiceDefinition
        {
            get
            {
                return this.zIsServiceDefinition;
            }
        }


        public ServiceDefinitionMarkerAttribute(
            bool isServiceDefinition = true)
        {
            this.zIsServiceDefinition = isServiceDefinition;
        }
    }
}
