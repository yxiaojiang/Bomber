﻿// Copyright (c) Yevhenii Selivanov.

using UnrealBuildTool;

public class MySettingsWidgetConstructorEditor : ModuleRules
{
	public MySettingsWidgetConstructorEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Latest;

		PublicDependencyModuleNames.AddRange(new[]
			{
				"Core"
				//My modules
				, "MyEditorUtils" // Created FSettingsPickerCustomization, FAssetTypeActions_SettingsDataTable, FAssetTypeActions_SettingsUserWidget
			}
		);

		PrivateDependencyModuleNames.AddRange(new[]
			{
				"CoreUObject", "Engine", "Slate", "SlateCore" // Core
				, "GameplayTagsEditor" // FGameplayTagCustomizationPublic
				, "AssetTools" // RegisterAdvancedAssetCategory
				, "UnrealEd" // Editor globals like GEditor
				, "Projects" // IPluginManager::Get()
				// My modules
				, "MySettingsWidgetConstructor" // USettingsDataTable
			}
		);
	}
}
