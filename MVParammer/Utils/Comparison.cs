using System;

namespace MVParammer.Utils
{
    public static class Comparison
    {
        /// <summary>
        /// Checks whether a and b are equal when both objects are casted to a's type
        /// </summary>
        public static bool AreEqual(object a, object b)
        {
            return a.Equals(Convert.ChangeType(b, a.GetType()));
        }
    }
}
