﻿#r "ConfigRTest.exe"
using ConfigRTest;

using ConfigRTest;

Add("Name", "ChristosMatskas");
Add("Age", 18);
Add("IsThisYourAge", false);
Add("MyRealAge", 35);
Add("CheckTheSourceCode", new Uri("https://github.com/config-r/config-r"));
Add("Foo", new Foo {Bar="I am a Bar", BarDateTime = DateTime.Now});