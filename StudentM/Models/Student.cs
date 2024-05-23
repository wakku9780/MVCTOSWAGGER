﻿using System.ComponentModel.DataAnnotations;

namespace StudentM.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }
}
