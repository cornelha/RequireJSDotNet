﻿using System.Collections.Generic;
using System.Text;

namespace RequireJsNet.Compressor.RequireProcessing
{
    internal static class ConfigProcessorFactory
    {
        public static ConfigProcessor Create(bool autoBundles, string projectPath, string packagePath, string entryPointOverride, List<string> filePaths, Encoding encoding)
        {
            if (autoBundles)
            {
                return new AutoBundleConfigProcessor(projectPath, packagePath, entryPointOverride, filePaths, encoding);
            }

            return new SimpleBundleConfigProcessor(projectPath, packagePath, entryPointOverride, filePaths);
        }
    }
}
