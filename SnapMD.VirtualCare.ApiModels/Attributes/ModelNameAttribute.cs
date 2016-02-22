using System;

namespace SnapMD.VirtualCare.ApiModels.Attributes
{
    /// <summary>
    /// Use this attribute to change the name of the ModelDescription generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public class ModelNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelNameAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; private set; }
    }
}