
public class Cipher
{
    private int _shift = 3;

    public string Encrypt(string text)
    {
        //encryption logic..... >:)
        string encrypted = "";

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            {
                bool isletter;
                isletter = Char.IsLetter(letter);

                if (isletter == false)
                {
                    encrypted += letter;
                }
                else
                {
                    int position = char.ToUpper(letter) - 'A';
                    int shifted = (position + _shift) % 26;
                    encrypted += (char)(shifted + 'A');
                }
            }
        }

        return encrypted;
    }

    public string Decrypt(string text)
    {

        string decrypted = "";

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            {
                bool isletter;
                isletter = Char.IsLetter(letter);

                if (isletter == false)
                {
                    decrypted += letter;
                }
                else
                {
                    int position = char.ToUpper(letter) - 'A';
                    int shifted = (position - _shift +26) % 26;
                    decrypted += (char)(shifted + 'A');
                }
            }
        }

        return decrypted;
    }
}