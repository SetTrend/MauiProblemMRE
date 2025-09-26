# MAUI Project Template Problem MRE

This project is the original MAUI project template, only amended by `implicitUsings` being removed from the project file.

It has been created as an MRE for .NET MAUI issue [#31794](https://github.com/dotnet/maui/issues/31794).

Trying to compile this project fails with the following series of error messages:

<details><summary>Click here to expand error log</summary>

```
Rebuild started at 16:37...
1>------ Rebuild All started: Project: FirstApp, Configuration: Debug Any CPU ------
Restored D:\Documents\Repos\~Test\Maui\FirstApp\FirstApp.csproj (in 898 ms).
1>C:\Users\Me\.nuget\packages\microsoft.windowsappsdk\1.7.250513003\buildTransitive\Microsoft.UI.Xaml.Markup.Compiler.interop.targets(509,9): Xaml Internal Error error WMC9999: Name cannot begin with the '<' character, hexadecimal value 0x3C. Line 7, position 1.
1>Done building project "FirstApp.csproj" -- FAILED.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018: The "XamlCTask" task failed unexpectedly.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018: System.Xml.XmlException: Name cannot begin with the '<' character, hexadecimal value 0x3C. Line 7, position 1.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.Throw(Exception e)
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseAttributes()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseElement()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseDocumentContent()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.CecilExtensions.IsXaml(EmbeddedResource resource, XamlCache cache, ModuleDefinition module, String& classname) in /_/src/Controls/src/Build.Tasks/XamlTask.cs:line 80
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.XamlCTask.Execute(IList`1& thrownExceptions) in /_/src/Controls/src/Build.Tasks/XamlCTask.cs:line 238
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.XamlTask.Execute() in /_/src/Controls/src/Build.Tasks/XamlTask.cs:line 38
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Build.BackEnd.TaskExecutionHost.Execute()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Build.BackEnd.TaskBuilder.<ExecuteInstantiatedTask>d__26.MoveNext()
1>Done building project "FirstApp.csproj" -- FAILED.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018: The "XamlCTask" task failed unexpectedly.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018: System.Xml.XmlException: Name cannot begin with the '<' character, hexadecimal value 0x3C. Line 7, position 1.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.Throw(Exception e)
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseAttributes()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseElement()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseDocumentContent()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.CecilExtensions.IsXaml(EmbeddedResource resource, XamlCache cache, ModuleDefinition module, String& classname) in /_/src/Controls/src/Build.Tasks/XamlTask.cs:line 80
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.XamlCTask.Execute(IList`1& thrownExceptions) in /_/src/Controls/src/Build.Tasks/XamlCTask.cs:line 238
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.XamlTask.Execute() in /_/src/Controls/src/Build.Tasks/XamlTask.cs:line 38
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Build.BackEnd.TaskExecutionHost.Execute()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Build.BackEnd.TaskBuilder.<ExecuteInstantiatedTask>d__26.MoveNext()
1>Done building project "FirstApp.csproj" -- FAILED.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018: The "XamlCTask" task failed unexpectedly.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018: System.Xml.XmlException: Name cannot begin with the '<' character, hexadecimal value 0x3C. Line 7, position 1.
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.Throw(Exception e)
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseAttributes()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseElement()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at System.Xml.XmlTextReaderImpl.ParseDocumentContent()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.CecilExtensions.IsXaml(EmbeddedResource resource, XamlCache cache, ModuleDefinition module, String& classname) in /_/src/Controls/src/Build.Tasks/XamlTask.cs:line 80
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.XamlCTask.Execute(IList`1& thrownExceptions) in /_/src/Controls/src/Build.Tasks/XamlCTask.cs:line 238
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Maui.Controls.Build.Tasks.XamlTask.Execute() in /_/src/Controls/src/Build.Tasks/XamlTask.cs:line 38
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Build.BackEnd.TaskExecutionHost.Execute()
1>C:\Users\Me\.nuget\packages\microsoft.maui.controls.build.tasks\9.0.82\buildTransitive\netstandard2.0\Microsoft.Maui.Controls.targets(172,3): error MSB4018:    at Microsoft.Build.BackEnd.TaskBuilder.<ExecuteInstantiatedTask>d__26.MoveNext()
1>Done building project "FirstApp.csproj" -- FAILED.
========== Rebuild All: 0 succeeded, 1 failed, 0 skipped ==========
========== Rebuild completed at 16:38 and took 49,617 seconds ==========
```

</details>

---

What's causing this error?