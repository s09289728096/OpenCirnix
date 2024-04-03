using System.Threading;

using Cirnix.Global;

using static Cirnix.Memory.Message;

namespace Cirnix.Worker
{
    internal static class AutoRG
    {
        private static readonly Timer Timer;
        private static readonly HangWatchdog Worker;
        private static int AutoRGCount = 0, LoopedCount = 0;
        internal static bool IsRunning { get; private set; } = false;
        static AutoRG()
        {
            Worker = new HangWatchdog(0, 0, 10);
            Worker.Condition = () => IsRunning;
            Worker.Actions += Actions;

            Timer = new Timer(state => Worker.Check());
        }

        internal static void RunWorkerAsync(int count)
        {
            if (IsRunning || count == 0) return;
            Timer.Change(0, 1000);
            IsRunning = true;
            AutoRGCount = count;
            Actions();
        }

        internal static void CancelAsync()
        {
            if (!IsRunning) return;
            Worker.Reset();
            Timer.Change(Timeout.Infinite, Timeout.Infinite);
            IsRunning = false;
            AutoRGCount = LoopedCount = 0;
        }

        private static void Actions()
        {
            SendMsg(false, "/rg");
            if (AutoRGCount > 0)
            {
                SendMsg(true, string.Format("自動 RG: {0}次", ++LoopedCount));
                if (LoopedCount >= AutoRGCount)
                {
                    CancelAsync();
                    SendMsg(true, "自動 RG 功能已停止");
                }
            }
        }
    }
}
