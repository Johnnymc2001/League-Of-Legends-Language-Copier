using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolCopyGUI
{
    internal class LolCopyLib
    {
        public static List<String> ParseLanguagesFile(string rootGamePath)
        {
            List<string> search = new List<string>();
            var dirPath = rootGamePath + @"\Game\DATA\FINAL\Localized";
            Directory.GetFiles(dirPath).ToList().ForEach(file =>
            {
                search.Add(file.Split("\\").Last().Replace("Global.", "").Replace(".wad.client", ""));
            });


            return search;
        }

        public static void CreatePath(string pathName)
        {
            var pathSplit = pathName.Split("\\").ToList();
            pathSplit.RemoveAt(pathSplit.Count() - 1);
            var fullPath = String.Join(@"\", pathSplit);
            try
            {
                Directory.CreateDirectory(fullPath);
            }
            catch { }
        }

        public static void CopyFile(List<String> files, string language)
        {
            var curFolder = Directory.GetCurrentDirectory();
            if (Directory.Exists(curFolder + @"\Result\" + language))
            {
                Directory.CreateDirectory(curFolder + @"\Result\" + language);
            }

            foreach (String file in files)
            {
                var srcShortPath = file.Split(@"League of Legends")[1];
                var srcFileName = file.Split("\\").Last();

                var resultFolder = $@"{curFolder}\Result\{language}\{srcShortPath}";

                Console.WriteLine($@"{srcShortPath} =>  {resultFolder}");

                CreatePath(resultFolder);
                File.Copy(file, resultFolder, true);
            }
        }
    }
}
