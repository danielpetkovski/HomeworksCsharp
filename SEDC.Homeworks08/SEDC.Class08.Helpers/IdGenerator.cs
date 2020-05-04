using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.Helpers
{
   public static class IdGenerator
    {
        private static int _id = 0;
        public static int GenerateId()
        {
            _id++;
            return _id;
        }
    }
}
