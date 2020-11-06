using System;
using System.IO;
// Buffered Streams example
public class MyApp
{		 
   static void Main() 	 
   {
       BuffStream bs = new BuffStream();
       bs.SaveStream();	 
        Console.WriteLine("Buffered data written.");
       Console.Read();
   } 
}
public class BuffStream
{
	public void SaveStream() 
	{
		Stream fsOut1 = new FileStream(@"captured.txt", 
		   FileMode.OpenOrCreate, FileAccess.Write);
		BufferedStream fileBuffer = new BufferedStream(fsOut1);
		byte[] buff;			// array to hold bytes written to buffer
		bool readMore=true;
		while(readMore) 
		{
			buff = FillBytes();			// Get array of bytes
         Console.WriteLine(buff[16]);
			for (int j = 0;j<buff[16];j++)
			{
				 fileBuffer.WriteByte(buff[j]);	// store bytes in buffer
                                                                   
			}
			if(buff[16]< 16) readMore=false;   // indicates no more data
		}
		fileBuffer.Close();  // flushes all remaining buffer content
		fsOut1.Close();      // Must close after bufferedstream
	  }
	    
	// method to simulate I/O device receiving data
	private static byte[] FillBytes() 
	{
		 Random rand = new Random();
		 byte[] r = new Byte[17];
		 // store random numbers to  return in array
		 for (int j=0;j<16;j++) 
		 {
                                              
			 r[j]= (byte) rand.Next();  
			 if(r[j]==171)		   // Arbitrary end of stream value
			 {
				 r[16]=(byte)(j);	   // Number of bytes in array
				 return r;
			  } 
		  }
                                  r[16] = (byte)16;           // entire buffer was filled
		  System.Threading.Thread.Sleep(200); // Delay 500ms 
		  return r;
	  }
}