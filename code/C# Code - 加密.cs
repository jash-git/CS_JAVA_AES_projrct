//C# Code - 加密
/// <summary>
/// 使用AES 256 加密
/// </summary>
/// <param name="source">本文</param>
/// <param name="key">因為是256 所以你密碼必須為32英文字=32*8=256</param>
/// <param name="iv">IV為128 所以為 16 * 8= 128</param>
/// <returns></returns>

public static string EncryptAES256(string source, string key, string iv)
{
    byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
    var aes = new RijndaelManaged();
    aes.Key = Encoding.UTF8.GetBytes(key);
    aes.IV = Encoding.UTF8.GetBytes(iv);
    aes.Mode = CipherMode.CBC;
    aes.Padding = PaddingMode.PKCS7;

    ICryptoTransform transform = aes.CreateEncryptor();

    return Convert.ToBase64String(transform.TransformFinalBlock(sourceBytes, 0, sourceBytes.Length));

}