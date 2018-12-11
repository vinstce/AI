﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomotiveSkill.Common.Number
{
    /// <summary>
    /// A chunk of a string, which can be either a number or a non-number
    /// substring between two numbers. Iff it is a number, its numeric value is
    /// given in addition to the substring.
    /// </summary>
    public class Chunk
    {
        public Chunk()
        {
        }

        public Chunk(string value)
        {
            this.Value = value;
        }

        public Chunk(string value, double numeric_value)
        {
            this.Value = value;
            this.NumericValue = numeric_value;
        }

        public string Value { get; }

        public double? NumericValue { get; }
    }
}
