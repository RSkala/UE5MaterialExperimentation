// Copyright Richard Skala

using UnrealBuildTool;
using System.Collections.Generic;

public class MaterialGraphBasicEditorTarget : TargetRules
{
	public MaterialGraphBasicEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "MaterialGraphBasic" } );
	}
}
