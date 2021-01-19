using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UnitDto : ModelWithNameDto
	{
	}
}
