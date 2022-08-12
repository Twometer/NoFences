using System.Runtime.InteropServices;
using static NoFences.Win32.Native;

namespace NoFences.Win32
{
    internal class StockIcons
    {
        private static Icon? folderLarge = null;

        public static Icon FolderLarge => folderLarge ??= GetStockIcon(SHSIID_FOLDER, SHGSI_LARGEICON);

        private static Icon GetStockIcon(uint type, uint size)
        {
            var info = new SHSTOCKICONINFO();
            info.cbSize = (uint)Marshal.SizeOf(info);

            SHGetStockIconInfo(type, SHGSI_ICON | size, ref info);

            var icon = (Icon)Icon.FromHandle(info.hIcon).Clone();
            DestroyIcon(info.hIcon); 
            return icon;
        }
    }
}
