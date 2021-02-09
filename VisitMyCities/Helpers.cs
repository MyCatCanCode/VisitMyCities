using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitMyCities
{
    public class Helpers
    {
        public static string GetTagClass(int category, int batiments)
        {
            var result = (category * 100) / batiments;
            if (result <= 1)
                return "tag1";
            if (result <= 4)
                return "tag2";
            if (result <= 8)
                return "tag3";
            if (result <= 12)
                return "tag4";
            if (result <= 18)
                return "tag5";
            if (result <= 30)
                return "tag6";
            return result <= 50 ? "tag7" : "";
        }
    }
}
