int LengthOfLastWord(string s)
{
    string[] words = s.Trim().Split(' ');
    int length= words[words.Length-1].Length;
    return length;
}
string s = "   fly me   to   the moon  ";
LengthOfLastWord(s);