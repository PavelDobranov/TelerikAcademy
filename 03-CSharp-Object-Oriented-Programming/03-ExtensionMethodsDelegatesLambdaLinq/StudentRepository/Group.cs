
// Create a class Group with properties GroupNumber and DepartmentName.
namespace DataRepository
{
    public class Group
    {
        private const string ToStringFormat = "Group number: {0}, Department: {1}";

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return string.Format(Group.ToStringFormat, this.GroupNumber, this.DepartmentName);
        }
    }
}