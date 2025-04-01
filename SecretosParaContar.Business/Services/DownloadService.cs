using System.Collections.Concurrent;

namespace SecretosParaContar.Business.Services
{
    public class DownloadService
    {
        private static ConcurrentDictionary<string, int> _clickCounts = new();

        public void RegisterClick(string userId)
        {
            _clickCounts.AddOrUpdate(userId, 1, (_, count) => count + 1);
        }

        public int GetClickCount(string userId)
        {
            return _clickCounts.TryGetValue(userId, out var count) ? count : 0;
        }
    }
}
