using UnrealBuildTool;

public class GameDevPlayerLogicServerTarget : TargetRules
{
	public GameDevPlayerLogicServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("GameDevPlayerLogic");
	}
}
