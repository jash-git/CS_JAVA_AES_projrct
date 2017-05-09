
try{

String key="12345678901234567890123456789012";
String iv="1234567890abcdef";
String encryptString="wifhXJU46ETengY/nA+sGQ==";

byte[] descryptBytes=decryptAES(iv.getBytes("UTF-8"),key.getBytes("UTF-8"),Base64.decode(encryptString, Base64.DEFAULT));

Toast.makeText(this,new String(descryptBytes), Toast.LENGTH_LONG).show();

}catch(Exception ex){}   