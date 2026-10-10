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
                int position = char.ToUpper(letter) -'A';
                int shifted = (position + _shift) % 26;
                encrypted += (char)(shifted + 'A');
            }
            
        }
        return encrypted;
    }

    public string Decrypt(string text)
    {
        //decryption logic..... hope it works. lol!
    }
}