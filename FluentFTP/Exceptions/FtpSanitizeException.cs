using System;
#if NETFRAMEWORK
using System.Runtime.Serialization;
#endif

namespace FluentFTP.Exceptions {

	/// <summary>
	/// FtpSanitizeException
	/// </summary>
#if NETFRAMEWORK
	[Serializable]
#endif
	public class FtpSanitizeException : FtpException {

		/// <summary>
		/// Gets the type of the issue detected by the sanitizer.
		/// </summary>
		public string IssueType { get; set; }

		/// <summary>
		/// Gets the FTP path that caused the exception.
		/// </summary>
		public string RemotePath { get; set; }

		/// <summary>
		/// Gets the config option that can be disabled.
		/// </summary>
		public string ConfigOption { get; set; }

		/// <summary>
		/// FtpSanitizeException
		/// </summary>
		public FtpSanitizeException(string type, string path, string config)
			: base(
				  "The FTP path \"" + path + "\" contains "+type+ " that might be used for FTP injection attacks! " +
				  "Set `"+config+"` to `false` to allow "+type+ ", or set `SanitizerMode` to `FtpSanitize.Rename` to silently cleanup such sequences.") {
			IssueType = type;
			RemotePath = path;
			ConfigOption = config;
		}
	}
}