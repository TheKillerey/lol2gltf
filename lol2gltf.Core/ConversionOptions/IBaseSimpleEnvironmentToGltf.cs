using ImageMagick;
using System.Collections.Generic;

namespace lol2gltf.Core.ConversionOptions
{
    public interface IBaseSimpleEnvironmentToGltf
    {
        public string SimpleEnvironmentPath { get; set; }

        public Dictionary<string, MagickImage> MaterialTextures { get; set; }

        public string PointLightPath { get; set; } 

        public string OutputPath { get; set; }
    }
}
