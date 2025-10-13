// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CS3141_Backrooms : ModuleRules
{
	public CS3141_Backrooms(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CS3141_Backrooms",
			"CS3141_Backrooms/Variant_Horror",
			"CS3141_Backrooms/Variant_Horror/UI",
			"CS3141_Backrooms/Variant_Shooter",
			"CS3141_Backrooms/Variant_Shooter/AI",
			"CS3141_Backrooms/Variant_Shooter/UI",
			"CS3141_Backrooms/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
