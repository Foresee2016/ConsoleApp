using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Basic {
	class LearnThread {
		static void Main(string[] args) {
			Thread thread = Thread.CurrentThread;
			thread.Name = "Main";
			Console.WriteLine("Thread Name: {0}", thread.Name);

			ThreadStart childRef = new ThreadStart(CallChildThread);
			Thread childThread = new Thread(childRef);
			childThread.Start();

			Console.ReadKey();
			childThread.Abort();
			Console.ReadKey();
		}
		public static void CallChildThread() {
			try {
				Console.WriteLine("Child thread starts");
				Thread.Sleep(3000);
				Console.WriteLine("Child resumes");
			} catch (ThreadAbortException e) {
				Console.WriteLine("Child Thread Abort Exception");
				Console.WriteLine(e);
			} finally {
				Console.WriteLine("Child thread finally");
			}
		}
	}
}
