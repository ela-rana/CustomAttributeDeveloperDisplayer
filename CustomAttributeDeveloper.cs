//A class library to create a custom attribute named Developer that consists of info about the developer
//of a class, method, field, etc. that has this attribute

using System;

namespace CustomAttributeDeveloper
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class DeveloperAttribute:Attribute
    {
        /// <summary>
        ///Name of the developer
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Skill level of the developer (0, 1, 2, 3 and so on)
        /// </summary>
        public int Level { get; }

        /// <summary>
        /// Whether the developer reviewed the code (true) or not (false)
        /// </summary>
        public bool Reviewed { get; }

        /// <summary>
        /// Attribute consisting of info about the developer of the type that had this attribute
        /// </summary>
        /// <param name="Name">Name of the developer</param>
        /// <param name="Level">Skill level of the developer (0, 1, 2, 3 and so on)</param>
        /// <param name="Reviewed">Whether the developer reviewed the code (true) or not (false)</param>
        public DeveloperAttribute(string Name, int Level, bool Reviewed)
        {
            this.Name = Name;
            this.Level = Level;
            this.Reviewed = Reviewed;
        }
    }
}
