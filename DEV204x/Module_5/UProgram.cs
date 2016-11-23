using System;

namespace Module_5
{
    public class UProgram
    {
        private string programName;
        private string departmentHead;

        private Degree degree;

        public string ProgramName
        {
            get
            {
                return programName;
            }

            set
            {
                programName = value;
            }
        }

        public string DepartmentHead
        {
            get
            {
                return departmentHead;
            }

            set
            {
                departmentHead = value;
            }
        }

        public Degree Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
            }
        }

        public void AddDegree(Degree degree)
        {
            Degree = degree;
        }

        public UProgram() { }

        public UProgram(string name)
        {
            ProgramName = name;
        }
    }
}
