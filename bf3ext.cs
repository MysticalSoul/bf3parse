using Newtonsoft.Json;
using static bf3parse.BF3Util;

namespace bf3parse
{
    public class BF3Ext
    {
        public async Task<Root> LoadBF3Json(string json)
        {
            var items = await Task.Run(() => JsonConvert.DeserializeObject<Root>(json));
            return items;
        }

    }

    public class BF3Stats : IDisposable
    {
        public List<BF3Util> data { get; set; }

        bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    GC.Collect();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
