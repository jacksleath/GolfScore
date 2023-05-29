﻿using GolfScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfScore.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<bool> UpsertAsync(Course course);
    }
}
