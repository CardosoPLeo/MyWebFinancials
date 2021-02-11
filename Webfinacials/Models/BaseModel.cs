using System;
using System.Runtime.Serialization;

namespace Webfinacials.Models
{
    public class BaseModel
    {
        [DataContract]
        public class ModeloBase
        {
            [DataMember]
            public int Id { get; protected set; }
        }

        public BaseModel()
        {
        }
    }
}
