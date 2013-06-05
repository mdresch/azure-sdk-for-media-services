//-----------------------------------------------------------------------
// <copyright file="KnownApiVersions.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>

using System;

namespace Microsoft.WindowsAzure.MediaServices.Client.Versioning
{
    

    /// <summary>
    /// The list of API versions.
    /// </summary>
    public static class KnownApiVersions
    {
        /// <summary>
        /// Version 2.0.
        /// </summary>
        public static readonly Version Version2 = new Version(major: 2, minor: 0);
        public static readonly Version Version2_1 = new Version(major: 2, minor: 1);


        /// <summary>
        /// Gets the Media Service API version.
        /// </summary>
        public static Version Current
        {
            get { return Version2_1; }
        }
    }
}