using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ProjectOxford.Vision.Contract;

namespace XamarinMVVM.Infrastructure.CognitiveServices
{
    public interface ICognitiveClient
    {
        Task < AnalysisResult > GetImageDescription(Stream stream);
    }
}
