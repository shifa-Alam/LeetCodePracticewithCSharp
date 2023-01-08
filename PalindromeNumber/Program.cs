
bool CheckPalindrome(int x)
{
    if (x < 0)
    {
        return false;
    }
     string stringNum = x.ToString();

    string  reverseString = string.Empty;
    for (int i = stringNum.Length-1; i >= 0; i--)
    {
        reverseString = reverseString +stringNum[i].ToString();
    }
    if (reverseString.Equals(stringNum)) return true;

    return false;

}

Console.WriteLine(CheckPalindrome(121));