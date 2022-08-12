using NoFences.DataModel;
using NoFences.DataModel.Legacy;

namespace NoFences.Services
{
    internal class FenceMigrator
    {
        public static FenceInfo Migrate(LegacyFenceInfo legacy)
        {
            return new FenceInfo
            {
                Id = legacy.Id,
                Location = new Point(legacy.PosX, legacy.PosY),
                Size = new Size(legacy.Width, legacy.Height),
                Mode = FenceMode.ShortcutBased,
                Options = new FenceOptions
                {
                    Title = legacy.Name,
                    Minify = legacy.CanMinify,
                    Locked = legacy.Locked,
                    TitleHeight = legacy.TitleHeight,
                },
                Paths = legacy.Files
            };
        }
    }
}
