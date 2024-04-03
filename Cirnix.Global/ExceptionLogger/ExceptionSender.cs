using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Cirnix.Global
{
    public static class ExceptionSender
    {
        public struct ExceptionSendState
        {
            public Exception ex;
            public bool IsSendSettingDump;

            public ExceptionSendState(Exception ex, bool IsSendSettingDump)
            {
                this.ex = ex;
                this.IsSendSettingDump = IsSendSettingDump;
            }
        }

        private static BackgroundWorker MailAsyncSender;

        internal static void Init()
        {
            MailAsyncSender = new BackgroundWorker();
            MailAsyncSender.DoWork += MailAsyncSender_DoWork;
        }

        private static void MailAsyncSender_DoWork(object sender, DoWorkEventArgs e)
        {
            // Global Exception Catcher
            Exception ex = ((ExceptionSendState)e.Argument).ex;
            if (ex is FileLoadException || ex is BadImageFormatException)
            {
                MetroDialog.OK("被防毒軟體阻擋", "無法讀取需要的檔案\n請將Cirnix加入至防毒軟體的例外名單");
                Application.Exit();
            }
            else if (ex is MissingMethodException)
            {
                MetroDialog.OK("未安裝必須的軟體", ".NET Framework 4.6.2 未安裝\nCirnix將會關閉並引導至下載頁面");
                Process.Start("https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462");
                Globals.ProgramShutDown.Invoke();
                Application.Exit();
            }
            else
            {
                File.AppendAllLines($"{Globals.ResourcePath}\\CirnixError.log", new string[] { ex.GetType().Name, ex.Message, ex.StackTrace });
            }
        }

        internal static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ExceptionSendAsync(e.Exception);
        }
        internal static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex) ExceptionSendAsync(ex);
        }
        public static void ExceptionSendAsync(Exception ex, bool IsSendSettingDump = false)
        {
            if (MailAsyncSender.IsBusy) return;
            MailAsyncSender.RunWorkerAsync(new ExceptionSendState(ex, IsSendSettingDump));
        }
    }
}
