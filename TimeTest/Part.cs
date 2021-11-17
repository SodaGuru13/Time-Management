﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTest
{
    // Simple business object. A PartId is used to identify the type of part
    // but the part name can change.
    internal class Part : IEquatable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }
        public override string ToString()
        {
            return "ID: " + PartId + " Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Part objAsPart = obj as Part;
            if (objAsPart == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsPart);
            }
        }
        public bool Equals(Part other)
        {
            if(other == null)
            {
                return false;
            }
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }
}
