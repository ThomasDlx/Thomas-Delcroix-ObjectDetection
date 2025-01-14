using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Thomas.Delcroix.ObjectDetection.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var objectDetection = new ObjectDetection();
            var imagesSceneData = new List<byte[]>();
            imagesSceneData.Add(await File.ReadAllBytesAsync("image1.jpg"));
            imagesSceneData.Add(await File.ReadAllBytesAsync("image2.jpg"));

            var results = await objectDetection.DetectObjectInScenesAsync(imagesSceneData);

            foreach (var result in results)
            {
                Console.WriteLine($"ImageData : {result.ImageData.Length} bytes");
                Console.WriteLine($"Box : {result.Box.Count} rectangles");
                foreach (var box in result.Box)
                {
                    Console.WriteLine($"  X : {box.X}, Y : {box.Y}, Width : {box.Width}, Height : {box.Height}");
                }
            }
        }
    }
}