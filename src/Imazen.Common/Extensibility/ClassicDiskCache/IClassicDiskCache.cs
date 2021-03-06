using System.Threading.Tasks;
using Imazen.Common.Extensibility.ClassicDiskCache;
using Imazen.Common.Issues;
using Microsoft.Extensions.Hosting;

namespace Imazen.Common.Extensibility.ClassicDiskCache
{
    public interface IClassicDiskCache: IIssueProvider, IHostedService
    {
        Task<ICacheResult> GetOrCreate(string key, string fileExtension, AsyncWriteResult writeCallback);
    }
}