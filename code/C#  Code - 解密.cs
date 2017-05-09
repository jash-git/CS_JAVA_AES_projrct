//C#  Code - 解密 :
/// <summary>
/// 使用AES 256 解密
/// </summary>
/// <param name="encryptData">Base64的加密後的字串</param>
/// <param name="key">因為是256 所以你密碼必須為32英文字=32*8=256</param>
/// <param name="iv">IV為128 所以為 16 * 8= 128</param>
/// <returns></returns>
public static string DecryptAES256(string encryptData, string key, string iv)
{
    var encryptBytes = Convert.FromBase64String(encryptData);
    var aes = new RijndaelManaged();
    aes.Key = Encoding.UTF8.GetBytes(key);
    aes.IV = Encoding.UTF8.GetBytes(iv);
    aes.Mode = CipherMode.CBC;
    aes.Padding = PaddingMode.PKCS7;
    ICryptoTransform transform = aes.CreateDecryptor();

    return Encoding.UTF8.GetString(transform.TransformFinalBlock(encryptBytes, 0, encryptBytes.Length));

}
