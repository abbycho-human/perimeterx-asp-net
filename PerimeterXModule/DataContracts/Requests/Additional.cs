using System.Runtime.Serialization;

namespace PerimeterX
{
	[DataContract]
	public class Additional
	{
		[DataMember(Name = "px_cookie", EmitDefaultValue = false)]
		public object PXCookie;

		[DataMember(Name = "http_method")]
		public string HttpMethod;

		[DataMember(Name = "http_version")]
		public string HttpVersion;

		[DataMember(Name = "module_version")]
		public string ModuleVersion { get { return PxConstants.MODULE_VERSION; } set { } }

		[DataMember(Name = "s2s_call_reason")]
		public string CallReason;

		[DataMember(Name = "px_orig_cookie")]
		public string PxOrigCookie;

		[DataMember(Name = "risk_mode")]
		public ModuleMode? RiskMode;

		[DataMember(Name = "px_cookie_hmac")]
		public string PxCookieHMAC;

		[DataMember(Name = "cookie_origin")]
		public CookieOrigin CookieOrigin;

		[DataMember(Name = "original_uuid")]
		public string OriginalUUID;

		[DataMember(Name = "original_token_error")]
		public string OriginalTokenError;

		[DataMember(Name = "px_decoded_original_token")]
		public object DecodedOriginalToken;

		[DataMember(Name = "request_cookie_names")]
		public string[] RequestCookieNames;

		[DataMember(Name = "enforcer_vid_source", EmitDefaultValue = false)]
		public string VidSource;

        [DataMember(Name = "user")]
        public string Username;

        [DataMember(Name = "pass")]
        public string Password;

        [DataMember(Name = "raw_username", IsRequired = false)]
        public string RawUsername;

        [DataMember(Name = "ci_version")]
        public string CiVersion;

        [DataMember(Name = "sso_step", IsRequired = false)]
        public string SsoStep;

        [DataMember(Name = "request_id")]
        public string RequestId { get; set; }
        [DataMember(Name = "custom_param1")]
        public string customParam1 { get; set; }
        [DataMember(Name = "custom_param2")]
        public string customParam2 { get; set; }
        [DataMember(Name = "custom_param3")]
        public string customParam3 { get; set; }
        [DataMember(Name = "custom_param4")]
        public string customParam4 { get; set; }
        [DataMember(Name = "custom_param5")]
        public string customParam5 { get; set; }
        [DataMember(Name = "custom_param6")]
        public string customParam6 { get; set; }
        [DataMember(Name = "custom_param7")]
        public string custom_param7 { get; set; }
        [DataMember(Name = "custom_param8")]
        public string customParam8 { get; set; }
        [DataMember(Name = "custom_param9")]
        public string customParam9 { get; set; }
        [DataMember(Name = "custom_param10")]
        public string customParam10 { get; set; }
    }
}
