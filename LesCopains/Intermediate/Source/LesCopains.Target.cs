using UnrealBuildTool;

public class LesCopainsTarget : TargetRules
{
	public LesCopainsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("LesCopains");
	}
}
