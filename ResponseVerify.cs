
using System;
using System.Text;
using System.Runtime.Serialization;

namespace Kakaocert
{
    [DataContract]
    public class ResponseVerify
    {
        [DataMember]
        public String receiptId;
        [DataMember]
        public String signedData;
    }
}
