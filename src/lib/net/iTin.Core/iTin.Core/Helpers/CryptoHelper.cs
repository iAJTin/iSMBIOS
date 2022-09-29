
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using iTin.Logging;

namespace iTin.Core.Helpers
{
    /// <summary>
    /// Static class which contains methods for works with encrypt/decrypt.
    /// </summary>
    public static class CryptoHelper
    {
        /// <summary>
        /// Encrypts specified plaintext using Rijndael symmetric key algorithm
        /// and returns a base64-encoded result.
        /// </summary>
        /// <param name="plainText">Plaintext value to be encrypted.</param>
        /// <param name="passPhrase">
        /// Passphrase from which a pseudo-random password will be derived. The derived password will be used to generate the encryption key.
        /// Passphrase can be any string. In this example we assume that this passphrase is an ASCII string.
        /// </param>
        /// <param name="saltValue">Salt value used along with passphrase to generate password. Salt can be any string. In this example we assume that salt is an ASCII string.</param>
        /// <param name="hashAlgorithm">Hash algorithm used to generate password. Allowed values are: "MD5" and "SHA1". SHA1 hashes are a bit slower, but more secure than MD5 hashes.</param>
        /// <param name="passwordIterations">Number of iterations used to generate password. One or two iterations should be enough.</param>
        /// <param name="initVector">Initialization vector (or IV). This value is required to encrypt the first block of plaintext data. For RijndaelManaged class IV must be exactly 16 ASCII characters long.</param>
        /// <param name="keySize">Size of encryption key in bits. Allowed values are: 128, 192, and 256. Longer keys are more secure than shorter keys.</param>
        /// <returns>
        /// Encrypted value formatted as a base64-encoded string.
        /// </returns>
        public static string Encrypt(string plainText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: CryptoHelper");
            Logger.Instance.Debug(@" Encrypts specified plaintext using Rijndael symmetric key algorithm and returns a base64-encoded result");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Encrypt({typeof(string)}, {typeof(string)}, {typeof(string)}, {typeof(string)}, {typeof(int)}, {typeof(string)}, {typeof(int)}");
            Logger.Instance.Debug($"   > plainText: {plainText}");
            Logger.Instance.Debug($"   > passPhrase: {passPhrase}");
            Logger.Instance.Debug($"   > saltValue: {saltValue}");
            Logger.Instance.Debug($"   > hashAlgorithm: {hashAlgorithm}");
            Logger.Instance.Debug($"   > passwordIterations: {passwordIterations}");
            Logger.Instance.Debug($"   > initVector: {initVector}");
            Logger.Instance.Debug($"   > keySize: {keySize}");

            // Convert strings into byte arrays.
            // Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8 encoding.
            var initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            var saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            // Convert our plaintext into a byte array.
            // Let us assume that plaintext contains UTF8-encoded characters.
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            // First, we must create a password, from which the key will be derived.
            // This password will be generated from the specified passphrase and salt value.
            // The password will be created using the specified hash algorithm. Password creation can be done in several iterations.
            byte[] keyBytes;
            using (var password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations))
            {
                // Use the password to generate pseudo-random bytes for the encryption key.
                // Specify the size of the key in bytes (instead of bits).
                keyBytes = password.GetBytes(keySize / 8);
            }

            // Create uninitialized Rijndael encryption object.
            // It is reasonable to set encryption mode to Cipher Block Chaining
            // (CBC). Use default options for other symmetric key parameters.
            ICryptoTransform encryptor;
            using (var symmetricKey = new RijndaelManaged {Mode = CipherMode.CBC})
            {
                // Generate encryptor from the existing key bytes and initialization vector. Key size will be defined based on the number of the key bytes.
                encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            }

            // Define memory stream which will be used to hold encrypted data.
            string cipherText;
            using (var memoryStream = new MemoryStream())
            {
                // Define cryptographic stream (always use Write mode for encryption).
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    // Start encrypting.
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                    // Finish encrypting.
                    cryptoStream.FlushFinalBlock();
                }

                // Convert our encrypted data from a memory stream into a byte array.
                var cipherTextBytes = memoryStream.ToArray();

                // Convert encrypted data into a base64-encoded string.
                cipherText = Convert.ToBase64String(cipherTextBytes);
            }

            Logger.Instance.Debug($"  > Output: {cipherText}");

            // Return encrypted string.
            return cipherText;
        }

        /// <summary>
        /// Decrypts specified ciphertext using Rijndael symmetric key algorithm.
        /// </summary>
        /// <param name="cipherText">
        /// Base64-formatted ciphertext value.
        /// </param>
        /// <param name="passPhrase">
        /// Passphrase from which a pseudo-random password will be derived. The derived password will be used to generate the encryption key.
        /// Passphrase can be any string. In this example we assume that this passphrase is an ASCII string.
        /// </param>
        /// <param name="saltValue">Salt value used along with passphrase to generate password. Salt can be any string. In this example we assume that salt is an ASCII string.</param>
        /// <param name="hashAlgorithm">Hash algorithm used to generate password. Allowed values are: "MD5" and "SHA1". SHA1 hashes are a bit slower, but more secure than MD5 hashes.</param>
        /// <param name="passwordIterations">Number of iterations used to generate password. One or two iterations should be enough.</param>
        /// <param name="initVector">Initialization vector (or IV). This value is required to encrypt the first block of plaintext data. For RijndaelManaged class IV must be exactly 16 ASCII characters long.</param>
        /// <param name="keySize">
        /// Size of encryption key in bits. Allowed values are: 128, 192, and 256. Longer keys are more secure than shorter keys.
        /// </param>
        /// <returns>
        /// Decrypted string value.
        /// </returns>
        /// <remarks>
        /// Most of the logic in this function is similar to the Encrypt logic. In order for decryption to work, all parameters of this function
        /// - except cipherText value - must match the corresponding parameters of the Encrypt function which was called to generate the ciphertext.
        /// </remarks>
        public static string Decrypt(string cipherText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: CryptoHelper");
            Logger.Instance.Debug(@" Decrypts specified ciphertext using Rijndael symmetric key algorithm");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Decrypt({typeof(string)}, {typeof(string)}, {typeof(string)}, {typeof(string)}, {typeof(int)}, {typeof(string)}, {typeof(int)}");
            Logger.Instance.Debug($"   > cipherText: {cipherText}");
            Logger.Instance.Debug($"   > passPhrase: {passPhrase}");
            Logger.Instance.Debug($"   > saltValue: {saltValue}");
            Logger.Instance.Debug($"   > hashAlgorithm: {hashAlgorithm}");
            Logger.Instance.Debug($"   > passwordIterations: {passwordIterations}");
            Logger.Instance.Debug($"   > initVector: {initVector}");
            Logger.Instance.Debug($"   > keySize: {keySize}");

            // Convert strings defining encryption key characteristics into byte
            // arrays. Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.
            var initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            var saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            // Convert our ciphertext into a byte array.
            var cipherTextBytes = Convert.FromBase64String(cipherText);

            // First, we must create a password, from which the key will be 
            // derived. This password will be generated from the specified 
            // passphrase and salt value. The password will be created using
            // the specified hash algorithm. Password creation can be done in
            // several iterations.
            byte[] keyBytes;
            using (var password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations))
            {
                // Use the password to generate pseudo-random bytes for the encryption key.
                // Specify the size of the key in bytes (instead of bits).
                keyBytes = password.GetBytes(keySize / 8);
            }

            // Create uninitialized Rijndael encryption object.
            // It is reasonable to set encryption mode to Cipher Block Chaining
            // (CBC). Use default options for other symmetric key parameters.
            ICryptoTransform decryptor;
            using (var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC })
            {
                // Generate decryptor from the existing key bytes and initialization vector.
                // Key size will be defined based on the number of the key bytes.
                decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            }

            // Define memory stream which will be used to hold encrypted data.
            string plainText;
            using (var memoryStream = new MemoryStream(cipherTextBytes))
            {
                // Define cryptographic stream(always use Read mode for encryption).
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    // Since at this point we don't know what the size of decrypted data will be, allocate the buffer long enough to hold ciphertext, plaintext is never longer than ciphertext.
                    var plainTextBytes = new byte[cipherTextBytes.Length];

                    // Start decrypting.
                    var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                    // Convert decrypted data into a string. 
                    // Let us assume that the original plaintext string was UTF8-encoded.
                    plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                }
            }

            Logger.Instance.Debug($"  > Output: {plainText}");

            // Return decrypted string.   
            return plainText;
        }
    }
}
