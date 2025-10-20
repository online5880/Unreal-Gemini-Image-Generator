using UnrealBuildTool;

public class GeminiImageGenerator : ModuleRules
{
	public GeminiImageGenerator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore"
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"UnrealEd",            
				"LevelEditor",         
				"ToolMenus",           
				"InputCore",           
				"Projects",            
				"EditorSubsystem",     
				"HTTP",                
				"Json",                
				"JsonUtilities",       
				"ImageWrapper",        
				"UMG",
				"UMGEditor",
				"Blutility",
				"DeveloperSettings",
				"RenderCore"
			}
		);
	}
}