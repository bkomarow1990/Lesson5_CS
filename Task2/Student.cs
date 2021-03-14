using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Student
    {
        private string name="NoName";
        private List<Mark> marks= new List<Mark>();
        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name incorrect, will be used Default name");
                    return;
                }
                this.name = value;
            }
        }
        public List<Mark> Marks
        {
            get=>marks;
            set
            {
              this.marks = value;
            }
        }
        public Student(List<Mark> marks= null, string name="NoName")
        {
            Name = name;
            Marks = marks;
        }
        public void CancelMark(int pos) // no index - position
        {
            if (0>= pos || pos > marks.Count)
            {
                Console.WriteLine("Incorrect mark number");
                return;
            }      
               this.marks[pos - 1].AMark = null;
            
        }
        public void changeMarkByDate(DateTime date, Mark mark)
        {
            if (marks.Count == 0 || date == null || mark == null)
            {
                return;
            }
            marks[marks.FindIndex(0, e => mark == e)] = mark;
        } 
        public uint getAverageMark()
        {
            if (!marks.Any())
            {
                Console.WriteLine("Haven`t marks");
            }
            uint sum=0;
            foreach (var item in marks)
            {
                if (item != null)
                {
                    sum += (uint)item.AMark;
                }
            }
            return (uint)(sum /marks.Count);
        }
        public override string ToString()
        {
            return $"Student name: {name}, with marks {String.Join('\n', marks)}";
        }
    }
}
