# WikimediaDumpToolbox
Tools for Wikimedia dump

## This project
* Provides page / article XML reader for Wikimedia exported files.
* Reduces memory consumption slightly comparing to XmlSerializer.
* Uses XML schema to get correct result.

## Getting Started
1. Get page / article XML dump from Wikimedia
2. Add reference to WikimediaDumpToolbox.dll in your application
3. Initialize PageReader and Read Read Read!

See also WikimediaDumpToolbox.SampleApp

## Example
```
string path = @"D:\Wikipedia\jawiki-latest-pages-articles.xml";
using (var reader = new PageReader(path))
{
	foreach (var item in reader.Read())
		{
			Console.WriteLine(item.title);
		}
	}
}
```

## Dev
### Developer Environment
Windows 10
Visual Studio 2015
.NET 4.6

### Language
C# 6.0
