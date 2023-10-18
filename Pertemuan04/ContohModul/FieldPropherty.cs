using Cntoh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cntoh
{
    internal class FieldPropherty
    {
        private string materi;

        public string Materi
        {
            get { return materi; }
            set { materi = value; }
        }

        public bool Nilai { get; internal set; }

        public class Person
        {
            private int nilai = 0;
            public int Nilai
            {
                get { return nilai; }
                set
                {
                    if (value > 50)
                        nilai = value;
                }
            }
        }
    }
}