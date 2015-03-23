namespace DataRepository
{
    using System.Collections.Generic;

    public static class GroupsData
    {
        private static ICollection<Group> groups;

        static GroupsData()
        {
            GroupsData.groups = new List<Group>();
            GroupsData.InitGroups();
        }

        public static ICollection<Group> GetGroups()
        {
            return new List<Group>(GroupsData.groups);
        }

        private static void InitGroups()
        {
            GroupsData.groups.Add(new Group(1, "Physics"));
            GroupsData.groups.Add(new Group(2, "Mathematics"));
            GroupsData.groups.Add(new Group(3, "Sport"));
            GroupsData.groups.Add(new Group(4, "Geography"));
            GroupsData.groups.Add(new Group(5, "History"));
            GroupsData.groups.Add(new Group(6, "Biology"));
        }
    }
}
