using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ProjectOxford.Vision;
using Microsoft.ProjectOxford.Vision.Contract;

using XamarinMVVM.Utils;

namespace XamarinMVVM.Infrastructure.CognitiveServices
{
    public class CognitiveClient:ICognitiveClient
    {
        public async Task < AnalysisResult > GetImageDescription ( Stream stream )
        {
            VisionServiceClient visionClient = new VisionServiceClient(Config.CognitiveClientApiKey, Config.CognitiveClientApiRoot);
            VisualFeature[] features = { VisualFeature.Tags, VisualFeature.Categories, VisualFeature.Description };
            return await visionClient.AnalyzeImageAsync(stream, features.ToList(), null);
        }
    }
}
