// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not
    /// have the requested content cached, they attempt to fetch it from one or more of the configured origins.
    /// </summary>
    public partial class Origin :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.Resource();

        /// <summary>Origin is enabled for load balancing or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public bool? Enabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).Enabled = value ?? default(bool); }

        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string HostHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).OriginHostHeader; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).OriginHostHeader = value ?? null; }

        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).HostName = value ?? null; }

        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? HttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).HttpPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).HttpPort = value ?? default(int); }

        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? HttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).HttpsPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).HttpsPort = value ?? default(int); }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for PrivateEndpointStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PrivateEndpointStatus? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginInternal.PrivateEndpointStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).PrivateEndpointStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).PrivateEndpointStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.OriginProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginResourceState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginInternal.ResourceState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).ResourceState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).ResourceState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? Priority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).Priority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).Priority = value ?? default(int); }

        /// <summary>The approval status for the connection to the Private Link</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PrivateEndpointStatus? PrivateEndpointStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).PrivateEndpointStatus; }

        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkAlias { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkAlias; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkAlias = value ?? null; }

        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkApprovalMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkApprovalMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkApprovalMessage = value ?? null; }

        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkLocation = value ?? null; }

        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginProperties _property;

        /// <summary>The JSON object that contains the properties of the origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.OriginProperties()); set => this._property = value; }

        /// <summary>Provisioning status of the origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.FormatTable]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource status of the origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginResourceState? ResourceState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginPropertiesInternal)Property).ResourceState; }

        /// <summary>Read only system data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Type; }

        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? Weight { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).Weight; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginUpdatePropertiesParametersInternal)Property).Weight = value ?? default(int); }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="Origin" /> instance.</summary>
        public Origin()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not
    /// have the requested content cached, they attempt to fetch it from one or more of the configured origins.
    public partial interface IOrigin :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResource
    {
        /// <summary>Origin is enabled for load balancing or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Origin is enabled for load balancing or not",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint",
        SerializedName = @"originHostHeader",
        PossibleTypes = new [] { typeof(string) })]
        string HostHeader { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the HTTP port. Must be between 1 and 65535.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of the HTTPS port. Must be between 1 and 65535.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpsPort { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>The approval status for the connection to the Private Link</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The approval status for the connection to the Private Link",
        SerializedName = @"privateEndpointStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PrivateEndpointStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PrivateEndpointStatus? PrivateEndpointStatus { get;  }
        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'",
        SerializedName = @"privateLinkAlias",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkAlias { get; set; }
        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A custom message to be included in the approval request to connect to the Private Link.",
        SerializedName = @"privateLinkApprovalMessage",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkApprovalMessage { get; set; }
        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated",
        SerializedName = @"privateLinkLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'",
        SerializedName = @"privateLinkResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceId { get; set; }
        /// <summary>Provisioning status of the origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning status of the origin.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginProvisioningState? ProvisioningState { get;  }
        /// <summary>Resource status of the origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource status of the origin.",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginResourceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginResourceState? ResourceState { get;  }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Weight of the origin in given origin group for load balancing. Must be between 1 and 1000",
        SerializedName = @"weight",
        PossibleTypes = new [] { typeof(int) })]
        int? Weight { get; set; }

    }
    /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not
    /// have the requested content cached, they attempt to fetch it from one or more of the configured origins.
    internal partial interface IOriginInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal
    {
        /// <summary>Origin is enabled for load balancing or not</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        string HostHeader { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        int? HttpsPort { get; set; }

        string Location { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        int? Priority { get; set; }
        /// <summary>The approval status for the connection to the Private Link</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PrivateEndpointStatus? PrivateEndpointStatus { get; set; }
        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        string PrivateLinkAlias { get; set; }
        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        string PrivateLinkApprovalMessage { get; set; }
        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        string PrivateLinkResourceId { get; set; }
        /// <summary>The JSON object that contains the properties of the origin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginProperties Property { get; set; }
        /// <summary>Provisioning status of the origin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource status of the origin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OriginResourceState? ResourceState { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        int? Weight { get; set; }

    }
}