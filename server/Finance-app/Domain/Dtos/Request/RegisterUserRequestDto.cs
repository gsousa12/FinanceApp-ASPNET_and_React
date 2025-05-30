﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public record RegisterUserRequestDto
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
