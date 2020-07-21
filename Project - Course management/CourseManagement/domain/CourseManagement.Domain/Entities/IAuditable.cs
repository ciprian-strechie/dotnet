﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.Domain.Entities
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        string ModifiedBy { get; set; }
    }
}
