using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[CommandResponse(ProtocolName.Worker.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
