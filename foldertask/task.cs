string[] str1 = {"Hello", "2", "fork", "not", "also", "in", "I", ":-)", "world"};
string[] str2 = new string[str1.Length];
int i = 0;
int j = 0;
while (i < str1.Length)
{
    if (str1[i].Length<=3)
    {
        str2[j]=str1[i];
        j++;
    }
    i++;
}
foreach (string k in str2)
{
    Console.Write(k + " ");
}

