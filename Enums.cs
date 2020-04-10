using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsIncluded
{
    public enum ImageType
    {
        Preview, // display on assets page as preview
        Main, // multiple images on asset detail page
        Secondary, // multiple images on bottom of detail page
        NonAsset // image not associated with any asset (logos etc)
    }
}
