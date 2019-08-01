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

        public void GetAvgMark(ref float AvgMark, out float AmountMark)
        {
            byte Quantity = 0;
            AmountMark = 0;
            foreach (Mark Grade in Marks)
            {
                Quantity++;            
                AmountMark += Grade.SubjectMark;
            }
            AvgMark = AmountMark / Quantity;            
        }

        public void ResetAllMarks()
        {
            int i = 0;
            while (i < Marks.Length)
            {                
                Marks[i].SubjectMark = 0;
                i++;
            }
        }        
    }
}