﻿// Copyright (c) Yevhenii Selivanov.

using UnrealBuildTool;

public class MyEditorUtils : ModuleRules
{
	public MyEditorUtils(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Latest;

		PublicDependencyModuleNames.AddRange(
			new[]
			{
				"Core"
				, "PropertyEditor" // Created FFunctionPickerCustomization
				, "AssetTools" // Created FAssetTypeActions_MyDataTable
				, "UnrealEd" // Created UMyDataTableFactory
				, "UMGEditor" // Created UMyUserWidgetFactory
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new[]
			{
				"CoreUObject", "Engine", "Slate", "SlateCore" // Core
				, "EditorFramework" // FEditorDelegates::FToolkitManager
				, "EditorStyle" // Property types customizations
				, "ToolWidgets" // SSearchableComboBox
				, "DataTableEditor", "DesktopPlatform", "EditorFramework", "ToolMenus" // Editor data table
				, "UMG", "Kismet" // Editor user widget
			}
		);
	}
}
