using System.Collections.Generic;

namespace Net.Chdk.Meta.Model.CameraModel
{
    public sealed class TreePlatformData
    {
        public IDictionary<string, TreeRevisionData> Revisions { get; set; }
    }
}
