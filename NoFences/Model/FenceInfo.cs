using System;
using System.Collections.Generic;

namespace NoFences.Model
{
    public class FenceInfo
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public List<string> Files { get; } = new List<string>();

        public FenceInfo()
        {

        }

        public FenceInfo(Guid id)
        {
            Id = id;
        }
    }
}
