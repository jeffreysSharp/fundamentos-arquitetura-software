﻿namespace Fundamentals.Architecture.SOLID.DIP.DIP.Solution
{
    public class DocumentNumber
    {
        public string  Number { get; set; }

        public bool Validate()
        {
            return Number.Length == 11;
        }
    }
}
