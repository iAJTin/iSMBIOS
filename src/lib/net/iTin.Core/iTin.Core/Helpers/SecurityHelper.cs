﻿
using System;
using System.Security.Cryptography;
using System.Text;

namespace iTin.Core.Helpers;

/// <summary>
/// Static class <b>SecurityHelper</b> provides static methods for encrypt.
/// </summary>
public static class SecurityHelper
{
    /// <summary>
    /// Function that given a string returns another string with the encrypted value of the input string. Uses the SHA1 algorithm.
    /// </summary>
    /// <param name="input">Value to encrypt.</param>
    /// <returns>
    /// Returns a new <see cref="T:System.String" /> with the encrypted value in <b>SHA1</b>.
    /// </returns>
    public static string EncryptSha1(string input)
    {
        using var sha1 = SHA1.Create();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha1.ComputeHash(inputBytes);

        return Convert.ToBase64String(hash);
    }

    /// <summary>
    /// Generate random passwords. The minimum length is 8 characters.
    /// </summary>
    /// <param name="length">Password length.</param>
    /// <returns>
    /// Returns a new <see cref="T:System.String" /> with a random password.
    /// </returns>
    public static string GenerateRandomPassword(int length = 8)
    {
        // Get the GUID
        string guidResult = Guid.NewGuid().ToString();

        // Remove the hyphens
        guidResult = guidResult.Replace("-", string.Empty);

        // Make sure length is valid
        if (length <= 0 || length > guidResult.Length)
        {
            return guidResult;
        }

        // Return the first length bytes
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        return guidResult[..length];

#else

        return guidResult.Substring(0, length);

#endif
    }
}
