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


namespace Microsoft.BingAds.Bulk
{
    /// <summary>
    /// Defines the possible status values of the bulk upload.
    /// </summary>
    /// <seealso cref="BulkOperation{TStatus}.GetStatusAsync"/>
    /// <seealso cref="BulkOperation{TStatus}.TrackAsync()"/>
    public enum UploadStatus
    {
        /// <summary>
        /// The upload completed with one or more errors.
        /// </summary>
        Completed,
        /// <summary>
        /// The upload completed with one or more errors.
        /// While the overall upload was successful, one or more add or update errors could have occurred. 
        /// As a best practice you should request error information via the <see cref="SubmitUploadParameters.ResponseMode"/> element 
        /// when calling the upload service and check the result file for any errors.
        /// </summary>
        CompletedWithErrors,
        /// <summary>
        /// The entire upload failed due to an unexpected error. You may submit a new upload with fewer entities or try again to submit the same upload later. 
        /// </summary>
        Failed,
        /// <summary>
        /// The upload request has been received and is in the queue for processing.
        /// </summary>
        FileUploaded,   
        /// <summary>
        /// The upload file has been accepted and the upload is in progress.
        /// </summary>
        InProgress,
        /// <summary>
        /// The upload file has not been received for the corresponding RequestId.
        /// </summary>
        PendingFileUpload,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        Aborted,
        /// <summary>
        ///  Reserved for future use.
        /// </summary>
        Expired
    }
}
