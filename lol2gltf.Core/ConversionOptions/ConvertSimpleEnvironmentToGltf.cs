using ImageMagick;
using System.Collections.Generic;

namespace lol2gltf.Core.ConversionOptions
{
    public class ConvertSimpleEnvironmentToGltf : IBaseSimpleEnvironmentToGltf
    {
        public string SimpleEnvironmentPath { get; set; }

        public Dictionary<string, MagickImage> MaterialTextures { get; set; } // *\levels\scene\textures\*

        public string PointLightPath { get; set; } //Adding Old League Lights [.dat]

        public string OutputPath { get; set; }
    }
}