﻿
using System;
using System.Text;
using System.Runtime.Serialization;

namespace Kakaocert
{
    [DataContract]
    public class ResponseESignRequest
    {
        [DataMember]
        public String receiptId;
        [DataMember]
        public String tx_id;
    }
}
