﻿using System.Reflection;
using Consolation.Common.Framework.ParameterSystem;
using Consolation.Common.Utilities;

namespace Consolation
{
    /// <summary>
    /// Core <c>Consolation</c> class.
    /// </summary>
    public static class ConsoleAPI
    {
        /// <summary>
        /// Initializes <c>Consolation</c> systems.
        /// </summary>
        public static void Initialize() => ParameterLoader.Initialize(Assembly.GetCallingAssembly());

        public static void ParseParameters(string[] args)
        {
            foreach (string paramCandidate in args)
                args.ParseParameter(paramCandidate);
        }
    }
}