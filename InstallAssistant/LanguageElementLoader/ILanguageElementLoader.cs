using System.Collections.Generic;
using InstallAssistant.Utils;

namespace InstallAssistant.LanguageElementLoader
{
	interface ILanguageElementLoader
	{
		Dictionary<(Language Language, string ElementIdentifier), List<string>> LoadElements();
	}
}
