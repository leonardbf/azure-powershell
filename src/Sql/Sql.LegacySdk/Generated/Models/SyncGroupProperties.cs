// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represent the properties of a sync group.
    /// </summary>
    public partial class SyncGroupProperties
    {
        private Microsoft.Azure.Management.Sql.LegacySdk.Models.ConflictResolutionPolicyType? _conflictResolutionPolicy;
        
        /// <summary>
        /// Optional. The policy of resolving conflicts between hub and
        /// member database in the sync group.The possible values: 'HubWin'
        /// and 'MemberWin'.
        /// </summary>
        public Microsoft.Azure.Management.Sql.LegacySdk.Models.ConflictResolutionPolicyType? ConflictResolutionPolicy
        {
            get { return this._conflictResolutionPolicy; }
            set { this._conflictResolutionPolicy = value; }
        }
        
        private string _hubDatabaseUserName;
        
        /// <summary>
        /// Optional. The user name of the hub database.
        /// </summary>
        public string HubDatabaseUserName
        {
            get { return this._hubDatabaseUserName; }
            set { this._hubDatabaseUserName = value; }
        }
        
        private int? _interval;
        
        /// <summary>
        /// Optional. Specifies the interval time of doing data synchronization.
        /// </summary>
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }
        
        private System.DateTime? _lastSyncTime;
        
        /// <summary>
        /// Optional. The last sync time of a sync group.
        /// </summary>
        public System.DateTime? LastSyncTime
        {
            get { return this._lastSyncTime; }
            set { this._lastSyncTime = value; }
        }
        
        private SyncGroupSchema _schema;
        
        /// <summary>
        /// Optional. The simple schema of sync group.
        /// </summary>
        public SyncGroupSchema Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }
        
        private string _syncDatabaseId;
        
        /// <summary>
        /// Optional. The database used to store sync meta data.
        /// </summary>
        public string SyncDatabaseId
        {
            get { return this._syncDatabaseId; }
            set { this._syncDatabaseId = value; }
        }
        
        private string _syncState;
        
        /// <summary>
        /// Optional. The sync state of a sync group. The possible values: Enum
        /// ('NotReady', 'Error', 'Warning', 'Processing', 'Good').
        /// </summary>
        public string SyncState
        {
            get { return this._syncState; }
            set { this._syncState = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupProperties class.
        /// </summary>
        public SyncGroupProperties()
        {
        }
    }
}
