using Faithlife.Utility;
using System;

namespace Guid5
{
    class Program
    {
        static void Main(string[] args)
        {
            var namespaceId = GuidUtility.Create(GuidUtility.DnsNamespace, "alanmervitz.com");
            Console.WriteLine($"namespaceId: {namespaceId}");

            var name = GuidUtility.Create(namespaceId, "test");
            Console.WriteLine($"name: {name}");
        }
    }
}
