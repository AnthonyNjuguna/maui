using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Controls.Sample
{
	public static class GarbageCollectionHelper
	{
		public static void Collect()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();

			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		public static async Task WaitForGC(params WeakReference[] references)
		{
			bool referencesCollected()
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();

				foreach (var reference in references)
				{
					if (reference.IsAlive)
					{
						return false;
					}
				}

				return true;
			}

			await AssertEventually(referencesCollected, timeout: 5000);
		}

		public static async Task AssertEventually(this Func<bool> assertion, int timeout = 1000, int interval = 100, string message = "Assertion timed out")
		{
			do
			{
				if (assertion())
				{
					return;
				}

				await Task.Delay(interval);
				timeout -= interval;

			}
			while (timeout >= 0);

			if (!assertion())
			{
				throw new Exception(message);
			}
		}
	}
}
