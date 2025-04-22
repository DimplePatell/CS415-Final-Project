using UnrealBuildTool;

public class GameDevPlayerLogicTarget : TargetRules
{
	public GameDevPlayerLogicTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameDevPlayerLogic");
	}
}
