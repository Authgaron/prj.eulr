﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public interface IProblem<TInput>
    {
        long Solve(TInput input);
    }
}
