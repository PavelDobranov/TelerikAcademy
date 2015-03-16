namespace VersionAttribute
{
    ﻿using System;

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        private const string VersionNullOrEmptyErrorMessage = "Version cannot be null or empty";

        private string version;

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version 
        {
            get 
            {
                return this.version;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("version", VersionAttribute.VersionNullOrEmptyErrorMessage);
                }

                this.version = value;
            } 
        }

        public override string ToString()
        {
            return this.Version;
        }
    }
}