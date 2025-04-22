using UnrealBuildTool;

public class GameDevPlayerLogicClientTarget : TargetRules
{
	public GameDevPlayerLogicClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("GameDevPlayerLogic");
	}
}
