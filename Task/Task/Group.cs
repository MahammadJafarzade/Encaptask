using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Group
    {
        private string name;
        private int maxStuCount;
        private string[] students = new string[] { };

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Maxstucount { get
            {
                return maxStuCount;
            }
            set
            {
                maxStuCount = value;
            }
        }
        public string[] Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }
        public Group(string name, int maxstucount)
        {
            this.name = name;
            this.maxStuCount = maxStuCount;
            
        }
        public void addStudent()
        {

        }
        public void removeStudent()
        {

        }
    }
}
