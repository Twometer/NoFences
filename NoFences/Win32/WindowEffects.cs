using System.Runtime.InteropServices;
using static NoFences.Win32.Native;

namespace NoFences.Win32
{
    internal class WindowEffects
    {
        public static void EnableBlur(IntPtr hwnd)
        {
            var accent = new AccentPolicy
            {
                AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND
            };

            var accentStructSize = Marshal.SizeOf(accent);

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData
            {
                Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                SizeOfData = accentStructSize,
                Data = accentPtr
            };

            SetWindowCompositionAttribute(hwnd, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        public static void EnableShadows(IntPtr hwnd)
        {
            var v = 2;
            DwmSetWindowAttribute(hwnd, 2, ref v, 4);

            MARGINS margins = new()
            {
                bottomHeight = 0,
                leftWidth = 0,
                rightWidth = 0,
                topHeight = 1
            };
            DwmExtendFrameIntoClientArea(hwnd, ref margins);
        }

        public static void GlueToDesktop(IntPtr hwnd)
        {
            var nWinHandle = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
            SetWindowLongPtr(hwnd, GWL_HWNDPARENT, nWinHandle.ToInt32());
        }

        public static void HideFromAltTab(IntPtr Handle)
        {
            SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
            int exStyle = (int)GetWindowLong(Handle, (int)GetWindowLongFields.GWL_EXSTYLE);
            exStyle |= (int)ExtendedWindowStyles.WS_EX_TOOLWINDOW;
            SetWindowLong(Handle, (int)GetWindowLongFields.GWL_EXSTYLE, (IntPtr)exStyle);
        }
    }
}
