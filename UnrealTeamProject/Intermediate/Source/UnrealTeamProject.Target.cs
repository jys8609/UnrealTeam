using UnrealBuildTool;

public class UnrealTeamProjectTarget : TargetRules
{
	public UnrealTeamProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("UnrealTeamProject");
	}
}
