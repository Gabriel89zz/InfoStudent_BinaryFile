using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoStudent_BinaryFile
{
    internal class Student
    {
		private int tuition;

		public int Tuition
        {
			get { return tuition; }
			set { tuition = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int grade;

		public int Grade
		{
			get { return grade; }
			set { grade = value; }
		}

        public Student(int tuition, string name, int grade)
        {
            Tuition = tuition;
            Name = name;
            Grade = grade;
        }


    }
}
