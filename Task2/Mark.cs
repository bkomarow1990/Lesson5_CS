using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Mark
    {
        private DateTime mark_date = new DateTime();
        private uint? mark;
        public DateTime MarkDate
        {
            get => mark_date;
            set
            {
                if (value== null)
                {
                    mark_date = new DateTime();
                    return;
                }
                this.mark_date = value;
            }
        }
        public uint? AMark
        {
            get => mark;
            set
            {
                if (value == null)
                {
                    this.mark = 0;
                    return;
                }
                this.mark = value;
            }
        }
        public Mark( DateTime mark_date, uint? mark= null)
        {
            MarkDate = mark_date;
            AMark = mark;
        }
        public override string ToString()
        {
            return $"Date mark:{MarkDate}, Mark: {mark}";
        }
    }
}
