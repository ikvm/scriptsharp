// ResourceFile.cs
// Script#/Tools
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace ScriptSharp {

    internal static class ResourceFile {

        public static string GetLocale(string fileName) {
            string extension = Path.GetExtension(fileName);

            if (String.Compare(extension, ".resx", StringComparison.OrdinalIgnoreCase) == 0) {
                fileName = Path.GetFileNameWithoutExtension(fileName);

                extension = Path.GetExtension(fileName);
                if (String.IsNullOrEmpty(extension) == false) {
                    return extension.Substring(1);
                }
            }

            return String.Empty;
        }
    }
}
