namespace FluentFTP {
	/// <summary>
	/// Determines how we sanitize FTP filepaths.
	/// </summary>
	public enum FtpSanitize {

		/// <summary>
		/// Secure. Throws exceptions when FTP filepaths/filenames contain bad chars.
		/// All the `Sanitize*` settings are honored.
		/// </summary>
		Throw,

		/// <summary>
		/// Secure. Silently renames FTP filepaths/filenames to remove bad chars used for FTP attacks.
		/// All the `Sanitize*` settings are honored.
		/// </summary>
		Rename,

		/// <summary>
		/// Insecure. Disables sanitizer completely. Ignores all other `Sanitize*` settings.
		/// </summary>
		Disabled,

	}
}
