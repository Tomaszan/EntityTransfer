using System;
using System.IO;
using static BedrockRpLib.PackPaths;



namespace EntityTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var EntityRPFiles = Directory.GetFiles(rpEntityPath, "*", SearchOption.AllDirectories);

            foreach (var item in EntityRPFiles)
            {
                Console.WriteLine(item);
            }

        }
    }
}
