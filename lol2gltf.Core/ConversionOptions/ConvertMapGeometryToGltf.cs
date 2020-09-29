
using ImageMagick;
using System.Collections.Generic;

namespace lol2gltf.Core.ConversionOptions
{
    public class ConvertMapGeometryToGltf : IBaseMapGeometryToGltf
    {
        public string MapGeometryPath { get; set; }

        public Dictionary<string, MagickImage> MaterialTextures { get; set; } // *\assets\maps\kitpieces\*

        public Dictionary<string, MagickImage> BakedMaterialTextures { get; set; } // *\assets\maps\lightmaps\maps\mapgeometry\map*\

        public string MaterialBINPath { get; set; }

        public string OutputPath { get; set; }
    }
}
