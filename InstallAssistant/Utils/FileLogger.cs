using System;
using System.IO;
using System.Text;
using SourceInfo;

namespace InstallAssistant.Utils
{
	public class FileLogger
	{
		private readonly string filePath;
		private readonly bool showdate;

		public FileLogger(string filePath, bool showdate = false)
		{
			CreateFolderIfNotExists(Path.GetDirectoryName(filePath));
		    this.filePath = filePath;
			this.showdate = showdate;
		}

	    public void Log(Exception exception)
	    {
            Log(exception.GetDetails());
	    }

		public void Log(params string[] loginfos)
		{
			var logData = new StringBuilder();
			if (showdate)
			{
				var now = DateTime.UtcNow;
				logData.AppendLine("______________________________________________________________________________________________________________________");
				logData.AppendLine($"\t\t\t\t\tDate: {now.ToShortDateString()} {now.ToLongTimeString()}");
				logData.AppendLine("______________________________________________________________________________________________________________________");
			}
			foreach (var loginfo in loginfos)
			{
				logData.AppendLine(loginfo);
			}

			WriteToTextFile(logData.ToString());
		}

		private static void CreateFolderIfNotExists(string directory)
		{
			if (!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}
		}

		private void WriteToTextFile(string data)
		{
			using (var sw = File.AppendText(filePath))
			{
				sw.WriteLine(data);
				sw.Close();
			}
		}
	}
}
