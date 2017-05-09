// 32 個英文或數字
string key = "1234567890" +
             "1234567890" +
             "1234567890" +
             "12";

// 16 個英文或數字
string iv = "1234567890" +
            "abcdef";

var encryptResult = EncryptAES256("許當麻", key, iv);
Response.Write("加密後:" + encryptResult + "<br />");
var descryptResult = DecryptAES256(encryptResult, key, iv);
Response.Write("解密後:" + descryptResult + "<br />");