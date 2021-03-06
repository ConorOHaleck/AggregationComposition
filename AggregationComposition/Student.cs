﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    class Student
    {
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public List<Course> Schedule { get; set; }
    }
}
