﻿using System;

namespace YSource.Commands
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class AliasAttribute : Attribute
    {
        public AliasAttribute(params string[] aliases)
        {
            Aliases = aliases;
        }
        public string[] Aliases { get; }
    }
}
