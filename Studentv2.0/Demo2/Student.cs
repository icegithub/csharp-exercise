using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2
{
    public class Student
    {
        private string strId;
        private string strName;
        private string strClass;
        private float chinese;
        private float math;
        private float english;
        private float all;

        public string STRID
        {
            get
            {
                return strId;
            }
            set
            {
                 strId = value;           
            }
        }

        public  string STRNAME
        {
            get
            {
                return strName;
            }
            set
            {
                 strName = value;           
            }
        }

        public string STRCLASS
        {
            get
            {
                return strClass;
            }
            set
            {
                strClass = value;
            }
        }

        public float CHINESE
        {
            get
            {
                return chinese;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Can't be negative!");
                    chinese = 0;
                }
                else
                    chinese = value;
            }
        }

        public float MATH
        {
            get
            {
                return math;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Can't be negative!");
                    math = 0;
                }
                else
                    math = value;
            }
        }

        public float ENGLISH
        {
            get
            {
                return english;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Can't be negative!");
                    english = 0;
                }
                else
                    english = value;
            }
        }
        public float ALL
        {
            get
            {
                return all;
            }
            set
            {
                if (math < 0 || chinese < 0 || english < 0)
                {
                    MessageBox.Show("Error");
                }
                else
                    all = this.CHINESE + this.MATH + this.ENGLISH;
            }
        }


    }
}
