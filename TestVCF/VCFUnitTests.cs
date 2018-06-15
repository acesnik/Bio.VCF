using Bio.VCF;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestVCF
{
    [TestFixture]
    public class VCFUnitTests
    {
        [Test]
        public void Test()
        {
            VCFParser parser = new VCFParser(Path.Combine(TestContext.CurrentContext.TestDirectory, @"testData", @"NA12878.knowledgebase.snapshot.20131119.b37.vcf.gz"));
            List<VariantContext> context = parser.Select(x => x).ToList();
        }
    }
}