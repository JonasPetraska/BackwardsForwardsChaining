﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwardsForwardsChaining.Abstractions
{
    public interface IAlgorithm : IDisposable
    {
        void Execute();
    }
}
