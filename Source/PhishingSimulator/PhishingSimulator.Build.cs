// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PhishingSimulator : ModuleRules
{
	public PhishingSimulator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
