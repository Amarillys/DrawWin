using System;
using System.Linq;
using System.Diagnostics;

namespace drawwin
{
    class WindowMgr
    {
        public static IntPtr GetWindow(string windowName)
        {
            var target = (IntPtr)WinApi.FindWindow(null, windowName);
            return target;
        }

        public static void SetPenetrate(IntPtr hwnd, bool status)
        {
            if (hwnd == null)
            {
                return;
            }
            else
            {
                int style = WinApi.GetWindowLong(hwnd, WinApi.GWL_EXSTYLE);
                if (status)
                {
                    style = style | WinApi.WS_EX_TRANSPARENT | WinApi.WS_EX_LAYERED;
                }
                else
                {
                    style ^= WinApi.WS_EX_TRANSPARENT;
                    if (WindowMgr.GetTransparent(hwnd) == 255)
                    {
                        style = style ^ WinApi.WS_EX_LAYERED;
                    }
                }
                WinApi.SetWindowLong(hwnd, WinApi.GWL_EXSTYLE, style);
            }
        }

        public static byte GetTransparent(IntPtr hwnd)
        {
            if (hwnd != null)
            {
                WinApi.GetLayeredWindowAttributes(hwnd, out uint crykey, out byte alpha, out uint flags);
                if (flags == 0)
                {
                    return 255;
                }
                return alpha;
            }
            return 255;
        }

        public static void SetTransparent(IntPtr hwnd, byte dstAlpha)
        {
            if (hwnd != null)
            {
                SetLayered(hwnd, dstAlpha);
                WinApi.GetLayeredWindowAttributes(hwnd, out uint crykey, out byte alpha, out uint flags);
                WinApi.SetLayeredWindowAttributes(hwnd, crykey, dstAlpha, WinApi.LWA_ALPHA);
            }
        }
        
        public static bool IsPenetrated(IntPtr hwnd)
        {
            if (hwnd != null)
            {
                int style = WinApi.GetWindowLong(hwnd, WinApi.GWL_EXSTYLE);
                return (style & WinApi.WS_EX_TRANSPARENT) > 0 && (style & WinApi.WS_EX_LAYERED) > 0;
            }
            return false;
        }

        public static void SetLayered(IntPtr hwnd, byte dstAlpha)
        {
            if (hwnd == null)
            {
                return;
            }
            else
            {
                int style = WinApi.GetWindowLong(hwnd, WinApi.GWL_EXSTYLE);
                if (dstAlpha < 255)
                {
                    WinApi.SetWindowLong(hwnd, WinApi.GWL_EXSTYLE, style | WinApi.WS_EX_LAYERED);
                }
                else
                {
                    WinApi.SetWindowLong(hwnd, WinApi.GWL_EXSTYLE, style ^ WinApi.WS_EX_LAYERED);
                }
            }
        }

        public static bool GetOnTop(IntPtr hwnd)
        {
            if (hwnd != null)
            {
                return (WinApi.GetWindowLong(hwnd, WinApi.GWL_EXSTYLE) & WinApi.WS_EX_TOPMOST) > 0;
            }
            return false;
        }

        public static void SetOnTop(IntPtr hwnd, bool status)
        {
            if (hwnd != null)
            {
                var windowPosState = status ? WinApi.HWND.TopMost : WinApi.HWND.NoTopMost;
                int style = WinApi.GetWindowLong(hwnd, WinApi.GWL_EXSTYLE);
                WinApi.SetWindowLong(hwnd, WinApi.GWL_EXSTYLE,
                    status ? style | WinApi.WS_EX_TOPMOST : style & ~WinApi.WS_EX_TOPMOST);
                WinApi.SetWindowPos(hwnd, windowPosState, 0, 0, 0, 0, WinApi.SetWindowPosFlags.IgnoreMove | WinApi.SetWindowPosFlags.IgnoreResize);
            }
        }
    }
}
