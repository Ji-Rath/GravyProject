// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GravyProject : ModuleRules
{
	public GravyProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
