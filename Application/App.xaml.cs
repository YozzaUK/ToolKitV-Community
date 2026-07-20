using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace ToolKitV
{
    public partial class App : Application
    {
        protected Mutex Mutex;
        protected override void OnStartup(StartupEventArgs e)
        {
            Mutex = new Mutex(true, ResourceAssembly.GetName().Name);

            if (!Mutex.WaitOne(0, false))
            {
                Current.Shutdown();
                return;
            }
            else
            {
                ShutdownMode = ShutdownMode.OnLastWindowClose;
            }
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            //if (Mutex != null)
            //{
            //    Mutex.ReleaseMutex();
            //}

            base.OnExit(e);
        }

        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error message:\n" + e.Exception.Message + "\n\nIf you need help, write to our discord.\nOur site: umbrella.re", "ToolKitV Crash", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
