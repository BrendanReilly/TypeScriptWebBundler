using System;
using System.Resources;
using Microsoft.Build.Utilities;

namespace BReilly
{
    public class BundleTask : Task
    {


        public override bool Execute()
        {
            Console.WriteLine("Task executed");
            throw new NotImplementedException();
        }
    }
}
