using System;

namespace GenericControllersExample.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GeneratedControllerAttribute : Attribute
    {
        public GeneratedControllerAttribute(string route)
        {
            Route = route;
        }

        public string Route { get; set; }
    }
}
