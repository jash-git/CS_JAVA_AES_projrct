public static byte[] decryptAES (byte[] ivBytes, byte[] keyBytes,byte[] textBytes) {
    try {

        AlgorithmParameterSpec ivSpec = new IvParameterSpec(ivBytes);

        SecretKeySpec newKey = new SecretKeySpec(keyBytes, "AES");

        Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");

        cipher.init(Cipher.DECRYPT_MODE, newKey, ivSpec);

        return cipher.doFinal(textBytes);

    } catch (Exception ex) {

        return null;

    }

}