using System.IO;
using System;
using static BedrockRpLib.PackPaths;
using static EntityTransfer.JsonData;

namespace EntityTransfer
{
    // This class takes care of copying over geometries with given identifier
    public class Geometry
    {
        public void TransferGeometry(string geometry)
        {
            
            var geometryPaths = Directory.GetFiles(rpGeometry, "*", SearchOption.AllDirectories);

            foreach (var geometryFile in geometryPaths)
            {
                foreach (var line in File.ReadAllLines(geometryFile))
                {
                    if (line.Contains(geometry))
                    {
                        if (File.Exists(geometryFile))
                        {
                            // If file exists, it's displayed and the file isn't copied
                            Console.WriteLine($"File {Path.GetFileNameWithoutExtension(geometryFile)} already exists");

                        }
                        else
                        {
                            // If the line is found, the file is copied.
                            Directory.CreateDirectory(geometryFile);
                            File.Copy(geometryFile, geometryFile.Replace(currentRepoName, targetRepoName));

                        }


                    }
                }

            }


        }
    }
}
