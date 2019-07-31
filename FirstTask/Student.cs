using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Student
    {
        public int Quantity;
        public Mark[] Marks;        
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public float GetAvgMark()
        {
            byte Quantity = 0;
            float AmountMark = 0;
            foreach (Mark Grade in Marks)
            {
                Quantity++;            
                AmountMark += Grade.SubjectMark;
            }
            return AmountMark / Quantity;
        }

        public void ResetAllMarks()
        {
            //foreach (Mark Grade in Marks)
            int i = 0;
            while (i < Marks.Length)
            {
                //Grade.SubjectMark = 0;
                Marks[i].SubjectMark = 0;
                i++;
            }
        }        
    }
}