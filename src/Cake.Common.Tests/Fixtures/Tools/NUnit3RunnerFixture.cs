﻿using System.Collections.Generic;
using Cake.Common.Tools.NUnit;
using Cake.Core.IO;
using Cake.Testing.Fixtures;

namespace Cake.Common.Tests.Fixtures.Tools
{
    internal sealed class NUnit3RunnerFixture : ToolFixture<NUnit3Settings>
    {
        public List<FilePath> Assemblies { get; set; }

        public NUnit3RunnerFixture()
            : base("nunit3-console.exe")
        {
            Assemblies = new List<FilePath>();
            Assemblies.Add(new FilePath("./Test1.dll"));
        }

        protected override void RunTool()
        {
            var tool = new NUnit3Runner(FileSystem, Environment, Globber, ProcessRunner);
            tool.Run(Assemblies, Settings);
        }
    }
}