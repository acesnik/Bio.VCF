Bio.VCF
=======

[![codecov](https://codecov.io/gh/acesnik/Bio.VCF/branch/master/graph/badge.svg)](https://codecov.io/gh/acesnik/Bio.VCF)
[![Build status](https://ci.appveyor.com/api/projects/status/9dret7cagvaa5m40?svg=true)](https://ci.appveyor.com/project/acesnik/bio-vcf)

Made available on NuGet: https://www.nuget.org/packages/Bio.VCF.ajc/.

A CSharp Parser for VCF Files.  Can iterate over VCF files and provides typed access to all of the relavent information as well as data validation.

Simple Usage Example:

    string fname = @"MyFile.vcf";
    VCFParser vcp = new VCFParser(fname);
    var myData=vcp.Where(x=>x.NoCallCount <20 && x.Biallelic).ToList();
