﻿using Exiled.API.Interfaces;

namespace CassiePlugin
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
