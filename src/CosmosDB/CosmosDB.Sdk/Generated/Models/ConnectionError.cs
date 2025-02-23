// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    public partial class ConnectionError
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionError class.
        /// </summary>
        public ConnectionError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionError class.
        /// </summary>

        /// <param name="connectionState">The kind of connection error that occurred.
        /// Possible values include: 'Unknown', 'OK',
        /// 'OperatorToDataCenterNetworkError', 'DatacenterToDatacenterNetworkError',
        /// 'InternalOperatorToDataCenterCertificateError', 'InternalError'</param>

        /// <param name="ipFrom">The IP of host that originated the failed connection.
        /// </param>

        /// <param name="ipTo">The IP that the connection attempted to reach.
        /// </param>

        /// <param name="port">The TCP port the connection was attempted on.
        /// </param>

        /// <param name="exception">Detailed error message about the failed connection.
        /// </param>
        public ConnectionError(string connectionState = default(string), string ipFrom = default(string), string ipTo = default(string), int? port = default(int?), string exception = default(string))

        {
            this.ConnectionState = connectionState;
            this.IPFrom = ipFrom;
            this.IPTo = ipTo;
            this.Port = port;
            this.Exception = exception;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the kind of connection error that occurred. Possible values include: &#39;Unknown&#39;, &#39;OK&#39;, &#39;OperatorToDataCenterNetworkError&#39;, &#39;DatacenterToDatacenterNetworkError&#39;, &#39;InternalOperatorToDataCenterCertificateError&#39;, &#39;InternalError&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "connectionState")]
        public string ConnectionState {get; set; }

        /// <summary>
        /// Gets or sets the IP of host that originated the failed connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "iPFrom")]
        public string IPFrom {get; set; }

        /// <summary>
        /// Gets or sets the IP that the connection attempted to reach.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "iPTo")]
        public string IPTo {get; set; }

        /// <summary>
        /// Gets or sets the TCP port the connection was attempted on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "port")]
        public int? Port {get; set; }

        /// <summary>
        /// Gets or sets detailed error message about the failed connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exception")]
        public string Exception {get; set; }
    }
}