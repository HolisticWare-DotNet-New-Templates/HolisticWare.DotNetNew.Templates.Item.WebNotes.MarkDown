/*
run this

	dotnet cake --settings_skipverification=true

	export CAKE_SETTINGS_SKIPVERIFICATION=true
	dotnet cake
*/

#addin nuget:?package=Cake.FileHelpers
// #addin "MagicChunks"

DeleteDirectory
			(
				"./output/",
				new DeleteDirectorySettings
				{
					Recursive = true,
					Force = true
				}
			);
			
string project = "source/HolisticWare.DotNetNew.Templates.Item.WebNotes.MarkDown/HolisticWare.DotNetNew.Templates.Item.WebNotes.MarkDown.csproj";
DotNetBuild( project);
