# GUID Generator

Page Format Mercilessly Stolen from https://guidgenerator.com/

*Work in Progress*

TODO:  
Add RFC 7515  encoding  
Add URL Encoding

Copy to Clipboard doesn't work - working on it!

Layout and text stolen from https://guidgenerator.com/

TODO:  
Encodings: RFC 7515 https://tools.ietf.org/html/rfc7515#appendix-C  
Encodings: URL Encode https://www.w3schools.com/tags/ref_urlencode.asp

Extra (maybe): Add a random fact/fortune/lucky number/etc...

More info:  
https://en.wikipedia.org/wiki/Globally_Unique_Identifier  
https://docs.microsoft.com/en-us/dotnet/api/system.guid  
http://www.ietf.org/rfc/rfc4122.txt

What is a GUID?  
GUID(aka UUID) is an acronym for 'Globally Unique Identifier' (or 'Universally Unique Identifier').
It is a 128-bit integer number used to identify resources.The term GUID is generally used by developers
working with Microsoft technologies, while UUID is used commonly used elsewhere.

How are GUIDs used?  
GUIDs are used by enterprise software developers, progammers, engineers, database administrators,
and testers in systems and application development and testing. They are used in Java, C#, Python, C++ ,
SQL databases, and non-relational Cloud databases as primary keys, versions, component identifiers,
or just about anywhere else a truly unique identifier is required. 

How unique is a GUID?  
128-bits is big enough and the generation algorithm is unique enough that if 1,000,000,000 GUIDs per second
were generated for 1 year the probability of a duplicate would be only 50%. Or if every human on Earth
generated 600,000,000 GUIDs there would only be a 50% 