// Copyright Richard Skala

using UnrealBuildTool;
using System.Collections.Generic;

public class MaterialGraphBasicTarget : TargetRules
{
	public MaterialGraphBasicTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "MaterialGraphBasic" } );
	}
}
