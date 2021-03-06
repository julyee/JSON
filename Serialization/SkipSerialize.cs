﻿using System;

namespace Julyee.JSON.Serialization
{
    /// <summary>
    /// Simple utility class used to skip properties/fields during serialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class SkipSerialize : Attribute
    {
        // empty class
    }
}
