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
            // namespaceId: 3590eed8-4dbf-5b5c-b9a5-7cc144bb7282
            
            var name = GuidUtility.Create(namespaceId, "test");
            Console.WriteLine($"name: {name}");
            // name: 1c5b0d5a-c333-5e9a-9ec3-646da22795ca
        }
    }
}
