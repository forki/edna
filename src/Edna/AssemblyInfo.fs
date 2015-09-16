namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Edna")>]
[<assembly: AssemblyProductAttribute("Edna")>]
[<assembly: AssemblyDescriptionAttribute("Project for playing around with ExcelDNA in order to get back up to speed for an interview.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
