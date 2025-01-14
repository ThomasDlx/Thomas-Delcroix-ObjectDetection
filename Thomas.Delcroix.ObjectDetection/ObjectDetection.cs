using ObjectDetection;

namespace Thomas.Delcroix.ObjectDetection;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Drawing;
using System.Drawing.Imaging;
public class ObjectDetection
{
    public async Task<IList<ObjectDetectionResult>> DetectObjectInScenesAsync(IList<byte[]>
        imagesSceneData)
    {
        IList<ObjectDetectionResult> results = new List<ObjectDetectionResult>();
        results.Add(new ObjectDetectionResult
        { ImageData = [0],
            Box = new List<BoundingBox>()
            {
                new() {Confidence=0.5f,Label="Car", Dimensions = new
                    BoundingBoxDimensions() { Height = 2, Width = 2, Y = 0, X= 0} },
            }} );
        results.Add(new ObjectDetectionResult
        { ImageData = [0],
            Box = new List<BoundingBox>()
            {
                new() {Confidence=0.9f,Label="Flower", Dimensions = new
                    BoundingBoxDimensions() { Height = 1, Width = 1, Y = 1, X= 1} },
            }} );
        await Task.Delay(1000);
        return results;
    }


}