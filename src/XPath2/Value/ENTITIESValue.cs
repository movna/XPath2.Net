﻿// Microsoft Public License (Ms-PL)
// See the file License.rtf or License.txt for the license details.

// Copyright (c) 2011, Semyon A. Chertkov (semyonc@gmail.com)
// All rights reserved.

using System;
using System.Text;

namespace Wmhelp.XPath2.Value
{
    public class ENTITIESValue
    {
        public ENTITIESValue(string[] value)
        {
            if (value == null)
                throw new ArgumentException("value");
            ValueList = value;
        }

        public string[] ValueList { get; }

        public override bool Equals(object obj)
        {
            ENTITIESValue other = obj as ENTITIESValue;
            if (other != null && other.ValueList.Length == ValueList.Length)
            {
                for (int k = 0; k < ValueList.Length; k++)
                    if (ValueList[k] != other.ValueList[k])
                        return false;
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            for (int k = 0; k < ValueList.Length; k++)
                hashCode = hashCode << 7 ^ ValueList[k].GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < ValueList.Length; k++)
            {
                if (k > 0)
                    sb.Append(" ");
                sb.Append(ValueList[k]);
            }
            return sb.ToString();
        }
    }
}
