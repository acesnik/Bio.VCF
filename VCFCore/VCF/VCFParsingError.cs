using System;

namespace Bio.VCF
{
    [Serializable]
    public class VCFParsingError : Exception
    {
        public VCFParsingError(string message, Exception innerException = null) : base("Error parsing VCF file.\n" + message, innerException)
        {

        }
    }
}
