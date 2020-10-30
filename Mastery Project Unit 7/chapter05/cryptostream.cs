using System;
using System.IO;
using System.Security.Cryptography;
// CryptoStream example
public class MyApp
{		 
    static void Main() 	 
    {
		 // Open file to which encrypted string is written
		 string toEncrypt= "Selected site is in Italy.";
		FileStream fs=null;
		try
		{
		 fs = new FileStream(@"\corecsharp\data\testcrypt.txt", FileMode.Create, 
		 FileAccess.Write);	
		 MyApp.WriteEncrypt(fs, toEncrypt);
		 fs= new FileStream(@"\corecsharp\data\testcrypt.txt",FileMode.Open, 
			   FileAccess.Read);
		 string msg = MyApp.ReadEncrypt(fs);
		 Console.WriteLine(msg);	
                                 } catch (Exception ex)
                                 {Console.WriteLine(ex.Message);}
		 fs.Close(); 
                                 Console.Read();
    } 
   
	// Encrypt FileStream
	private static void WriteEncrypt(FileStream fs, string msg) 
	{
		// (1) Create Data Encryption Standard (DES) object.
		DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
		// (2) Create a key and Initialization Vector - requires 8 bytes
		crypt.Key = new byte[] {71,72,83,84,85,96,97,78};
		crypt.IV  = new byte[] {71,72,83,84,85,96,97,78};
		// (3) Create CryptoStream stream object
		CryptoStream cs = new CryptoStream(fs,
		   crypt.CreateEncryptor(),CryptoStreamMode.Write);
		// (4) Create StreamWriter using CryptoStream
		StreamWriter sw = new StreamWriter(cs);
		sw.Write(msg);
		sw.Close();
		cs.Close();
	}
	
	// Read and Decrypt a file stream.
	private static string ReadEncrypt(FileStream fs) 
	{
		// (1) Create Data Encryption Standard (DES) object.
		DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
		// (2) Create a key and Initialization Vector
		crypt.Key = new byte[] {71,72,83,84,85,96,97,78};
		crypt.IV  = new byte[] {71,72,83,84,85,96,97,78};
		// (3) Create CryptoStream stream object
		CryptoStream cs = new CryptoStream(fs,
			 crypt.CreateDecryptor(),CryptoStreamMode.Read);
		// (4) Create StreamReader using CryptoStream
		StreamReader sr = new StreamReader(cs);
		string msg = sr.ReadToEnd();
		sr.Close();
		cs.Close();
		return msg;
	}   
}