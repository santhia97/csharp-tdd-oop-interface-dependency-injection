﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_internal_interface_dependency_injection.CSharp.Main
{
    // IAlphabet Interface: Blueprint for alphabet implementations
    public interface IAlphabet
    {
        Dictionary<char, int> GetLetterScores();
    }
}
