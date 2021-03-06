﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.NodejsTools.Telemetry
{
    /// <summary>
    /// Telemetry event names
    /// </summary>
    internal static class TelemetryEvents
    {
        private const string Prefix = "VS/NodejsTools/";

        /// <summary>
        /// User created a new project from existing code.
        /// </summary>
        public const string ProjectImported = Prefix + "ProjectImported";

        /// <summary>
        /// User started debugging.
        /// </summary>
        public const string DebbugerStarted = Prefix + "DebuggerStarted";

        /// <summary>
        /// User queried NPM for a package.
        /// </summary>
        public const string SearchNpm = Prefix + "SearchNpm";

        /// <summary>
        /// User installed NPM package.
        /// </summary>
        public const string InstallNpm = Prefix + "InstallNpm";

        /// <summary>
        /// User uninstalled package.
        /// </summary>
        public const string UnInstallNpm = Prefix + "UnInstallNpm";

        /// <summary>
        /// User executed some script in the interactive window.
        /// </summary>
        public const string UsedRepl = Prefix + "UsedRepl";
        
        public const string OperationRegistrationFaulted = Prefix + "OperationRegistrationFaulted";
    }

    internal static class TelemetryProperties
    {
        private const string Prefix = "VS.NodejsTools.";

        /// <summary>
        /// The engine the user is using to debug node. Expected entries are:
        ///  * Node6
        ///  * Chrome
        ///  * ChromeV2
        ///  * None
        /// </summary>
        public const string DebuggerEngine = Prefix + "DebuggerEngine";

        /// <summary>
        /// Wether the user started debugging inside a project or in AnyCode.
        /// </summary>
        public const string IsProject = Prefix + "IsProject";

        /// <summary>
        /// The version of Node the user is using.
        /// </summary>
        public const string NodeVersion = Prefix + "NodeVersion";
    }
}
