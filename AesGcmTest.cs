using System;
using System.Security.Cryptography;
using Xunit;

public class AesGcmTest
{
    [Fact]
    public void TryUsingAesGcm()
    {
        // Super bad crypto. Just here to demonstrate that it does not explode.
        var key = new byte[16];
        AesGcm gcm = new AesGcm(key);

        byte[] plaintext = new byte[1], ciphertext = new byte[1];
        byte[] nonce = new byte[12], tag = new byte[16];
        gcm.Encrypt(nonce, plaintext, ciphertext, tag);
    }
}
