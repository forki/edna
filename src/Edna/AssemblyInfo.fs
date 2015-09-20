namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Edna")>]
[<assembly: AssemblyProductAttribute("Edna")>]
[<assembly: AssemblyDescriptionAttribute("Project shows how to test ExcelDNA addin with ApprovalTest.")>]
[<assembly: AssemblyVersionAttribute("0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1"
