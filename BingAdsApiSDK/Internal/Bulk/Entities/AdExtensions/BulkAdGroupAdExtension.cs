﻿//=====================================================================================================================================================
// Bing Ads .NET SDK ver. 10.4
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MS-PL License
// 
// This license governs use of the accompanying software. If you use the software, you accept this license. 
//  If you do not accept the license, do not use the software.
// 
// 1. Definitions
// 
// The terms reproduce, reproduction, derivative works, and distribution have the same meaning here as under U.S. copyright law. 
//  A contribution is the original software, or any additions or changes to the software. 
//  A contributor is any person that distributes its contribution under this license. 
//  Licensed patents  are a contributor's patent claims that read directly on its contribution.
// 
// 2. Grant of Rights
// 
// (A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, 
//  each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, 
//  prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.
// 
// (B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, 
//  each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, 
//  sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.
// 
// 3. Conditions and Limitations
// 
// (A) No Trademark License - This license does not grant you rights to use any contributors' name, logo, or trademarks.
// 
// (B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, 
//  your patent license from such contributor to the software ends automatically.
// 
// (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, 
//  and attribution notices that are present in the software.
// 
// (D) If you distribute any portion of the software in source code form, 
//  you may do so only under this license by including a complete copy of this license with your distribution. 
//  If you distribute any portion of the software in compiled or object code form, you may only do so under a license that complies with this license.
// 
// (E) The software is licensed *as-is.* You bear the risk of using it. The contributors give no express warranties, guarantees or conditions.
//  You may have additional consumer rights under your local laws which this license cannot change. 
//  To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, 
//  fitness for a particular purpose and non-infringement.
//=====================================================================================================================================================

using Microsoft.BingAds.Bulk.Entities;
using Microsoft.BingAds.Internal.Bulk.Mappings;

// ReSharper disable once CheckNamespace


namespace Microsoft.BingAds.Internal.Bulk.Entities
{
    /// <summary>
    /// <para>This abstract class provides properties that are shared by all bulk ad group with ad extension association classes.</para>
    /// <para>For more information, see <see href="http://go.microsoft.com/fwlink/?LinkID=511639">Bulk File Schema</see>.</para>
    /// </summary>
    public abstract class BulkAdGroupAdExtension : BulkAdExtensionAssociation
    {
        /// <summary>
        /// The name of the ad group that is associated with the ad extension.
        /// Corresponds to the 'Ad Group' field in the bulk file. 
        /// </summary>
        public string AdGroupName
        {
            get { return ParentName; }
            set { ParentName = value; }
        }

        /// <summary>
        /// The name of the parent campaign which contains the ad group that is associated with the ad extension.
        /// Corresponds to the 'Campaign' field in the bulk file. 
        /// </summary>
        public string CampaignName { get; set; }

        /// <summary>
        /// The identifier of the ad group that is associated with the ad extension.
        /// Corresponds to the 'Id' field in the bulk file. 
        /// </summary>
        public long? AdGroupId
        {
            get { return EntityId; }
            set { EntityId = value; }
        }

        private static readonly IBulkMapping<BulkAdGroupAdExtension>[] Mappings =
        {
            new SimpleBulkMapping<BulkAdGroupAdExtension>(StringTable.Campaign,
                c => c.CampaignName,
                (v, c) => c.CampaignName = v
            )
        };

        internal override void ProcessMappingsToRowValues(RowValues values)
        {
            base.ProcessMappingsToRowValues(values);

            this.ConvertToValues(values, Mappings);
        }

        internal override void ProcessMappingsFromRowValues(RowValues values)
        {
            base.ProcessMappingsFromRowValues(values);

            values.ConvertToEntity(this, Mappings);
        }

        /// <summary>
        /// Reserved for internal use.
        /// </summary>
        protected override string ParentColumnName
        {
            get { return StringTable.AdGroup; }
        }        
    }
}
