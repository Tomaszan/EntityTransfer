using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static BedrockRpLib.PackPaths;

namespace EntityTransfer.RP
{
    public class ResourcePack
    {
        public void TransferRP()
        { 
            var EntityRPFiles = Directory.GetFiles(rpEntityPath, "*", SearchOption.AllDirectories);

            foreach (var item in EntityRPFiles)
            {
                var line = File.ReadAllLines(item);

            }


            // Create classes and functions for all RP parts, e.g. execution of RenderControllers function will copy over all associated render controllers
            // Create function FindDotToQuote and FindQuoteToQuote to find needed strings, e.g. geometry
        }
    }
}
