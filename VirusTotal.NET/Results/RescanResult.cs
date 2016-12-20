using Newtonsoft.Json;
using VirusTotalNET.ResponseCodes;

namespace VirusTotalNET.Results
{
    public class RescanResult
    {
        /// <summary>
        /// A unique link to this particular scan result.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// Id of the resource.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The scan response code. Use this to determine the status of the scan.
        /// </summary>
        [JsonProperty("response_code")]
        public ScanResponseCode ResponseCode { get; set; }

        /// <summary>
        /// The unique scan id of the resource.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        /// <summary>
        /// SHA256 hash of the resource.
        /// </summary>
        public string SHA256 { get; set; }
    }
}