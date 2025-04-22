using UnrealBuildTool;

public class GameDevPlayerLogicEditorTarget : TargetRules
{
	public GameDevPlayerLogicEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("GameDevPlayerLogic");
	}
}
