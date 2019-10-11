using System;
using System.Reflection;
using InstallAssistant.Utils;

namespace InstallAssistant.LanguageElementLoader.Csv
{
	public static class CsvFile
	{
		public static string FileName = "AllLanguages.csv";

		public static string GetContent()
		{
			var embeddedResourceReader = new EmbeddedResourceReader();
			return embeddedResourceReader.GetContent(Assembly.GetExecutingAssembly(), $"InstallAssistant.Languages.{FileName}");
		}

		public static string[] SplitContent(string languageFileContent)
		{
			return languageFileContent.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		}
	}
}
