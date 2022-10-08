using System.Threading.Tasks;

namespace Fluid.Utils
{
    internal static class TaskExtensions
    {
        public static bool IsCompletedSuccessfully(this Task t)
        {
            return t.Status == TaskStatus.RanToCompletion && !t.IsFaulted && !t.IsCanceled;
        }
    }
}