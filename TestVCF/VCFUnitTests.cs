using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using Bio.VCF;

namespace VCFComparison
{
    [TestFixture]
    public class VCFUnitTests
    {
        [Test]
        public void test()
        {
            VCFParser parser = new VCFParser(Path.Combine(TestContext.CurrentContext.TestDirectory, @"testData", @"NA12878.knowledgebase.snapshot.20131119.b37.vcf.gz"));
        }
    }
}
