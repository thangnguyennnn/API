﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DTO
{
    public class DocumentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfQuiz { get; set; }
        public string DataCreate { get; set; }
        public int AuthorID { get; set; }
    }
}
