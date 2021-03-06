using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Capture page screenshot.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CaptureScreenshot)]
	[SupportedBy("Chrome")]
	public class CaptureScreenshotCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data (PNG).
		/// </summary>
		public string Data { get; set; }
	}
}
