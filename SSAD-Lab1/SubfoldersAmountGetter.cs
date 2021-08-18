using System.IO;

namespace SSAD_Lab1
{
    public static class SubfoldersAmountGetter
    {
        public static bool TryGetFilesAmount(string path, out int amount)
        {
            amount = -1;
            if (!Directory.Exists(path)) return false;
            var fileCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
            amount = fileCount;
            return true;
        }
    }
}