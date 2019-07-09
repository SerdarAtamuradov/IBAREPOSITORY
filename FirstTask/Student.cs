using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Student
    {
        public Mark[] Marks = new Mark[2];
                 
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public float GetAvgMark()
        {
            byte Quantity = 0;
            float AmountMark = 0;
            for (int i = 0; i < Marks.Length; i++)
            {                
                Quantity++;
                AmountMark += Marks[i].SubjectMark;
            }            
            return AmountMark / Quantity;
        }

        public void ResetAllMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
                Marks[i].SubjectMark = 0;
        }    
    }
}