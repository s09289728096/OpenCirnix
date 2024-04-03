using System.Threading;

using Cirnix.Global;
using Cirnix.Global.Properties;

using static Cirnix.Global.NativeMethods;
using static Cirnix.Global.SoundManager;
using static Cirnix.Memory.Component;
using static Cirnix.Memory.Message;
using static Cirnix.Memory.States;

namespace Cirnix.Worker
{
    internal static class AutoStarter
    {
        private static readonly Timer Timer;
        private static readonly HangWatchdog Worker;
        private static int RequireCount;
        internal static bool IsRunning { get; private set; } = false;
        static AutoStarter()
        {
            Worker = new HangWatchdog(0, 0, 0);
            Worker.Condition = () => IsRunning && RequireCount <= PlayerCount;
            Worker.Actions += Actions;

            Timer = new Timer(state => Worker.Check());
        }

        internal static void RunWorkerAsync(int count)
        {
            if (IsRunning) return;
            Timer.Change(0, 500);
            IsRunning = true;
            RequireCount = count;
            Worker.Check();
        }

        internal static void CancelAsync()
        {
            if (!IsRunning) return;
            Worker.Reset();
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            IsRunning = false;
            RequireCount = 0;
        }

        private static void Actions()
        {
            try
            {
                CancelAsync();
                Play(Resources.max);
                for (int i = 10; i > 0; i--)
                {
                    if (RequireCount > PlayerCount)
                    {
                        SendMsg(true, "人數低於設定值，取消開始");
                        return;
                    }
                    SendMsg(true, $"{i} 秒後遊戲將自動開始");
                    Thread.Sleep(1000);
                }
                PostMessage(Warcraft3Info.MainWindowHandle, 0x100, 18, 0);
                PostMessage(Warcraft3Info.MainWindowHandle, 0x100, 83, 0);
                PostMessage(Warcraft3Info.MainWindowHandle, 0x101, 18, 0);
                PostMessage(Warcraft3Info.MainWindowHandle, 0x101, 83, 0);
            }
            catch
            {
                SendMsg(true, "執行時出現例外狀況");
            }
        }
    }
}

