using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosBusiness
{
    [Serializable]
    public class Finger : EntityBase
    {
        public int Id { get; set; }

        public int FingerMask { get; set; }

        public byte[] Data { get; set; }

        public Boolean IsValid { get; set; }

        public bool ContainsFingers { get; set; }

        public Finger()
        {

        }

        public bool Save(string UserName, List<Finger> Fingers)
        {
            return true;
            //return new SqLite().SetFingers(UserName, Fingers[0].Data, Fingers[1].Data, Fingers[2].Data, Fingers[3].Data);
        }
    }
}
