﻿using System;

namespace TMLPatcher.Common.TML
{
    public readonly struct ModData
    {
        public readonly string modName;
        public readonly Version modVersion;
        public readonly Version modLoaderVersion;

        public ModData(string modName, Version modVersion, Version modLoaderVersion)
        {
            this.modName = modName;
            this.modVersion = modVersion;
            this.modLoaderVersion = modLoaderVersion;
        }
    }
}