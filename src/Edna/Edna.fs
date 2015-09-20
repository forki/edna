namespace Edna

open System
open System.Threading
open System.Net
open ExcelDna.Integration

/// Documentation for my library
///
/// ## Example
///
///     let h = BasicFunctions.simpleFunc 1
///     printfn "%d" h
///

//    type FsAsyncAddIn() = 
//        interface IExcelAddIn with
//            member this.AutoOpen () = 
//                ExcelAsyncUtil.Initialize ()
//            member this.AutoClose () = ExcelAsyncUtil.Uninitialize ()

    module BasicFunctions = 
        /// Returns the integer that gets passed
        ///
        /// ## Parameters
        ///  - `num` - the number you want the cell to display
        [<ExcelFunction(Name="Edna.AFunc")>]
        //static member aFunc (num : double) = num
        let public aFunc (num : double) = num