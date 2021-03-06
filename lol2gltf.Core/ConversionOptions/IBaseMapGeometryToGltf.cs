﻿using ImageMagick;
using System.Collections.Generic;

namespace lol2gltf.Core.ConversionOptions
{
    public interface IBaseMapGeometryToGltf
    {
        public string MapGeometryPath { get; set; }

        public Dictionary<string, MagickImage> MaterialTextures { get; set; }

        public Dictionary<string, MagickImage> BakedMaterialTextures { get; set; } 

        public string MaterialBINPath { get; set; }

        public string OutputPath { get; set; }
    }
}
