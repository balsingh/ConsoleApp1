using System;
using k8s;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = KubernetesClientConfiguration.InClusterConfig();
            // Use the config object to create a client.
            
            IKubernetes client = new Kubernetes(config);
            Console.WriteLine("Starting Request!");

            // Thread.Sleep(1200000);

            
            var list = client.ListNamespacedPod("payments");
            Console.WriteLine("listname");
            foreach (var item in list.Items)
            {
                Console.WriteLine(item.Metadata.Name);
            }
            if (list.Items.Count == 0)
            {
                Console.WriteLine("Empty!");
            }

        }
    }
}
