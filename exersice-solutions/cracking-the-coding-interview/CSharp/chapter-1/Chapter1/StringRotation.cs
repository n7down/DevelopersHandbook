public static class StringRotation
{
    public static bool IsSubstring(string s, string ss)
    {
        if(s.Length != ss.Length)
        {
            return false;
        }

        if(s.Equals(ss))
        {
            return true;
        }

        int length = s.Length;
        for(int i = 0; i < length; i++)
        {
            string r = s.Remove(0, 1);
            string sub = s.Substring(0, 1);
            s = r + sub;
            if(s.Equals(ss))
            {
                return true;
            }
        }
        return false;
    }
}