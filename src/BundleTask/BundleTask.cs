using System;
using System.Resources;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace BReilly
{
    public class BundleTask : Task
    {


        public override bool Execute()
        {
            Console.WriteLine("Hello");
            Log.LogMessage(MessageImportance.High, "BundleTask finished successfully.");
            return true;
        }
    }
}
