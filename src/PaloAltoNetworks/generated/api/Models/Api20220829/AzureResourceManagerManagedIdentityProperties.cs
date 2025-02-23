// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Extensions;

    /// <summary>The properties of the managed service identities assigned to this resource.</summary>
    public partial class AzureResourceManagerManagedIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The active directory identifier of this principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>The Active Directory tenant id of the principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ManagedIdentityType _type;

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ManagedIdentityType Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesUserAssignedIdentities _userAssignedIdentity;

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesUserAssignedIdentities UserAssignedIdentity { get => (this._userAssignedIdentity = this._userAssignedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.AzureResourceManagerManagedIdentityPropertiesUserAssignedIdentities()); set => this._userAssignedIdentity = value; }

        /// <summary>
        /// Creates an new <see cref="AzureResourceManagerManagedIdentityProperties" /> instance.
        /// </summary>
        public AzureResourceManagerManagedIdentityProperties()
        {

        }
    }
    /// The properties of the managed service identities assigned to this resource.
    public partial interface IAzureResourceManagerManagedIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.IJsonSerializable
    {
        /// <summary>The active directory identifier of this principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The active directory identifier of this principal.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>The Active Directory tenant id of the principal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Active Directory tenant id of the principal.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ManagedIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ManagedIdentityType Type { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
    /// The properties of the managed service identities assigned to this resource.
    internal partial interface IAzureResourceManagerManagedIdentityPropertiesInternal

    {
        /// <summary>The active directory identifier of this principal.</summary>
        string PrincipalId { get; set; }
        /// <summary>The Active Directory tenant id of the principal.</summary>
        string TenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Support.ManagedIdentityType Type { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IAzureResourceManagerManagedIdentityPropertiesUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
}