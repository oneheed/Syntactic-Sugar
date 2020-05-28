using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncStreamSample004
{
    class EnumerableText : IAsyncEnumerable<string>, IAsyncEnumerator <string>
    {
        private readonly StreamReader _reader;

        private bool _disposed;

        public EnumerableText(string path)
        {
            _reader = File.OpenText(path);
            _disposed = false;
        }

        public string Current { get; private set; }

        async public ValueTask<bool> MoveNextAsync()
        {
            var result = await _reader.ReadLineAsync();
            await Task.Delay(100);
            Current = result;
            return Current != null;
        }

        async public ValueTask DisposeAsync()
        {
            await Task.Run(() => Dispose());
        }

        public IAsyncEnumerator<string> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return this;
        }

      

        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_reader != null)
                {
                    _reader.Dispose();
                }
                _disposed = true;
            }
        }
    }

   
}
