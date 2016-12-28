using System.Collections.Generic;

namespace Movies.Comparers
{
    public class StringComparer : IEqualityComparer<string>
    {
        #region Implementation of IEqualityComparer<in string>

        public bool Equals(string lhs, string rhs)
        {
            if(lhs == null && rhs == null)
            {
                return true;
            }
            if(lhs == null | rhs == null)
            {
                return false;
            }
            return lhs.ToLower().Contains(rhs.ToLower());
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
}
