﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }

    }
}
