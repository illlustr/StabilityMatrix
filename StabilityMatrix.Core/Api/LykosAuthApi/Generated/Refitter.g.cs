// <auto-generated>
//     This code was generated by Refitter.
// </auto-generated>


using Refit;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

#nullable enable annotations

namespace StabilityMatrix.Core.Api.LykosAuthApi
{
    [System.CodeDom.Compiler.GeneratedCode("Refitter", "1.4.1.0")]
    public partial interface ILykosAuthApiV2
    {
        /// <returns>OK</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>401</term>
        /// <description>Unauthorized</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Not Found</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/v2/Accounts/me")]
        Task<AccountResponse> ApiV2AccountsMe();

        /// <returns>OK</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>400</term>
        /// <description>Bad Request</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Unauthorized</description>
        /// </item>
        /// <item>
        /// <term>403</term>
        /// <description>Forbidden</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/v2/files/download")]
        Task<FilesDownloadResponse> ApiV2FilesDownload([Query] string path);

        /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>302</term>
        /// <description>Found</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Unauthorized</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/v2/oauth/patreon/redirect")]
        Task ApiV2OauthPatreonRedirect([Query] System.Uri redirectUrl);

        /// <returns>OK</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>401</term>
        /// <description>Unauthorized</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/v2/oauth/patreon/link")]
        Task<System.Uri> ApiV2OauthPatreonLink([Query] System.Uri redirectUrl);

        /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>401</term>
        /// <description>Unauthorized</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Delete("/api/v2/oauth/patreon")]
        Task ApiV2OauthPatreon();

        /// <returns>A <see cref="Task"/> that completes when the request is finished.</returns>
        /// <exception cref="ApiException">
        /// Thrown when the request returns a non-success status code:
        /// <list type="table">
        /// <listheader>
        /// <term>Status</term>
        /// <description>Description</description>
        /// </listheader>
        /// <item>
        /// <term>302</term>
        /// <description>Found</description>
        /// </item>
        /// <item>
        /// <term>401</term>
        /// <description>Unauthorized</description>
        /// </item>
        /// <item>
        /// <term>404</term>
        /// <description>Not Found</description>
        /// </item>
        /// <item>
        /// <term>400</term>
        /// <description>Bad Request</description>
        /// </item>
        /// </list>
        /// </exception>
        [Headers("Accept: text/plain, application/json, text/json")]
        [Get("/api/v2/oauth/patreon/callback")]
        Task ApiV2OauthPatreonCallback([Query] string code, [Query] string state);


    }

}

//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 649 // Disable "CS0649 Field is never assigned to, and will always have its default value null"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"
#pragma warning disable 8625 // Disable "CS8625 Cannot convert null literal to non-nullable reference type"
#pragma warning disable 8765 // Disable "CS8765 Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes)."

namespace StabilityMatrix.Core.Api.LykosAuthApi
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AccountResponse
    {

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("roles")]
        public ICollection<string> Roles { get; set; }

        [JsonPropertyName("permissions")]
        public ICollection<string> Permissions { get; set; }

        [JsonPropertyName("patreonId")]
        public string PatreonId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FilesDownloadResponse
    {

        [JsonPropertyName("downloadUrl")]
        public System.Uri DownloadUrl { get; set; }

        [JsonPropertyName("expiresAt")]
        public System.DateTimeOffset? ExpiresAt { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProblemDetails
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("status")]
        public int? Status { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("instance")]
        public string Instance { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625