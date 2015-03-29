namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    using SchoolClasses.Humans;
    using SchoolClasses.Interfaces;

    public class Class : IClass, ICommentable
    {
        private const string ValueNullOrEmptyErrorMessage = "Cannot be null or empty";
        private const string HumanNullErrorMessage = "Human cannot be null";
        private const string ToStringFormat = "Class: {0}";

        private string id;
        private ICollection<IHuman> humans;

        public Class(string id, ICollection<IHuman> humans = null)
        {
            this.Id = id;
            this.Humans = humans;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Class.ValueNullOrEmptyErrorMessage, "Id");
                }

                this.id = value;
            }
        }

        public ICollection<IHuman> Humans
        {
            get
            {
                return new List<IHuman>(this.humans);
            }
            private set
            {
                if (value == null)
                {
                    this.humans = new List<IHuman>();
                }
                else
                {
                    this.humans = new List<IHuman>(value.Count);

                    this.AddHumans(value);
                }
            }
        }

        public string Comment { get; set; }

        public void AddHuman(IHuman human)
        {
            Class.ValidateHuman(human);

            this.humans.Add(human);
        }

        public void RemoveHuman(IHuman human)
        {
            Class.ValidateHuman(human);

            this.humans.Remove(human);
        }

        public void AddHumans(ICollection<IHuman> humans)
        {
            foreach (var human in humans)
            {
                Class.ValidateHuman(human);

                this.humans.Add(human);
            }
        }

        public override string ToString()
        {
            return string.Format(Class.ToStringFormat, this.Id);
        }

        private static void ValidateHuman(IHuman human)
        {
            if (human == null)
            {
                throw new NullReferenceException(Class.HumanNullErrorMessage);
            }
        }
    }
}