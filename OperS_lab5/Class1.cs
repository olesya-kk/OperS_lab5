using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperS_lab5
{
    public class SecondThreadClass
    {
        public event EventHandler<string> UpdateUI;

        private bool stopThread;
        private Thread secondThread;

        public void StartThread()
        {
            Thread thread = new Thread(SecondThreadMethod);
            thread.Start();
        }

        private void SecondThreadMethod()
        {
            while (!stopThread)
            {
                Thread.Sleep(1000);
                OnUpdateUI("Дополнительный поток выполняет действие");
            }
        }

        protected virtual void OnUpdateUI(string message)
        {
            UpdateUI?.Invoke(this, message);
        }
        public void IncreasePriority()
        {
            if (secondThread != null &&
                secondThread.Priority < ThreadPriority.Highest)
            {
                secondThread.Priority++;
            }
        }

        public void DecreasePriority()
        {
            if (secondThread != null &&
                secondThread.Priority > ThreadPriority.Lowest)
            {
                secondThread.Priority--;
            }
        }
    }

}
