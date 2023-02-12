using System;
using System.Collections.Generic;
using System.Text;

namespace _13_fevral_heftesonu_taski
{
    internal class Course
    {
        public Group[] groups = new Group[0];

        public void AddGroup(Group _group)
        {
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = _group;
        }

        public Group GetGroupByNo(string no)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].No == no)
                {
                    return groups[i];
                }
            }

            return null;
        }

        public Group[] GetGroupsByPointRange(double minPoint, double maxPoint)
        {
            List<Group> result = new List<Group>();

            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].AvgPoint >= minPoint && groups[i].AvgPoint <= maxPoint)
                {
                    result.Add(groups[i]);
                }
            }

            return result.ToArray();
        }

        public Group[] Search(string str)
        {
            List<Group> result = new List<Group>();

            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].No.Contains(str))
                {
                    result.Add(groups[i]);
                }
            }

            return result.ToArray();
        }
    }

}
