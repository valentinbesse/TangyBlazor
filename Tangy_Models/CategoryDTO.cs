﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models
{
#pragma warning disable S101 // Types should be named in PascalCase
    public class CategoryDTO
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter name...")]
        public string Name { get; set; }
    }
}
