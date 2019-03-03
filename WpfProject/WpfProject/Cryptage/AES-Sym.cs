using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WpfProject.Cryptage
{
   public class AES_Sym
    {
        public AES_Sym() { 
        // À la création de l'instance de chiffrage, la clé et le IV sont également créés
        TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

        byte[] iv = TDES.IV;
        byte[] key = TDES.Key;

        string text = "texte en clair";

        Console.WriteLine("Mon texte en clair : {0}", text);

    // La même clé et le même IV sont utilisés pour le chiffrage et le déchiffrage
    byte[] cryptedTextAsByte = Crypt(text, key, iv);

        Console.WriteLine("Mon texte chiffré : {0}", Convert.ToBase64String(cryptedTextAsByte));

    String decryptedText = Decryp(cryptedTextAsByte, key, iv);

        Console.WriteLine("Mon texte déchiffré : {0}", decryptedText);
}

    static byte[] Crypt(string text, byte[] key, byte[] iv)
    {
        byte[] textAsByte = Encoding.Default.GetBytes(text);

        TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

        // Cet objet est utilisé pour chiffrer les données.
        // Il reçoit en entrée les données en clair sous la forme d'un tableau de bytes.
        // Les données chiffrées sont également retournées sous la forme d'un tableau de bytes
        var encryptor = TDES.CreateEncryptor(key, iv);

        byte[] cryptedTextAsByte = encryptor.TransformFinalBlock(textAsByte, 0, textAsByte.Length);

        return cryptedTextAsByte;
    }

    static string Decryp(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
    {
        TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

        // Cet objet est utilisé pour déchiffrer les données.
        // Il reçoit les données chiffrées sous la forme d'un tableau de bytes.
        // Les données déchiffrées sont également retournées sous la forme d'un tableau de bytes
        var decryptor = TDES.CreateDecryptor(key, iv);

        byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

        return Encoding.Default.GetString(decryptedTextAsByte);
    }
  }
}
