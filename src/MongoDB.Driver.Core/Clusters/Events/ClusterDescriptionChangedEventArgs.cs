﻿/* Copyright 2013-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Misc;

namespace MongoDB.Driver.Core.Clusters.Events
{
    public class ClusterDescriptionChangedEventArgs : EventArgs
    {
        // fields
        private readonly ClusterDescription _oldClusterDescription;
        private readonly ClusterDescription _newClusterDescription;

        // constructors
        public ClusterDescriptionChangedEventArgs(ClusterDescription oldClusterDescription, ClusterDescription newClusterDescription)
        {
            _oldClusterDescription = Ensure.IsNotNull(oldClusterDescription, "oldClusterDescription");
            _newClusterDescription = Ensure.IsNotNull(newClusterDescription, "newClusterDescription");
        }

        // properties
        public ClusterDescription OldClusterDescription
        {
            get { return _oldClusterDescription; }
        }

        public ClusterDescription NewClusterDescription
        {
            get { return _newClusterDescription; }
        }
    }
}