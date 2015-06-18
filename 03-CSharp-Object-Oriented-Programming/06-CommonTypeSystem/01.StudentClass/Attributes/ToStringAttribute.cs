namespace StudentClass.Attributes
{
    using System;

    class ToStringAttribute : Attribute
    {
        private readonly string name;

        public ToStringAttribute(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}