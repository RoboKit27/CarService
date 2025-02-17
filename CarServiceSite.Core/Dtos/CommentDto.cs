﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int Rating { get; set; }
        public UserDto Author { get; set; }
    }
}
