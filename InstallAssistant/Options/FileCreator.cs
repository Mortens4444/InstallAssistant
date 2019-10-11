using System.IO;

namespace InstallAssistant.Options
{
	class FileCreator
    {
        public void CreateNewFile(string filename, string data)
        {
            using (var sw = File.CreateText(filename))
            {
                sw.Write(data);
                sw.Close();
            }
        }
    }
}
