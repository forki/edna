namespace Edna
open ExcelDna.Integration

/// Documentation for my library
///
/// ## Example
///
///     let h = BasicFunctions.simpleFunc 1
///     printfn "%d" h
///
module BasicFunctions = 
  
  /// Returns the integer that gets passed
  ///
  /// ## Parameters
  ///  - `num` - the number you want the cell to display
  [<ExcelFunction(Name="Edna.SimpleFunc")>]
  let simpleFunc num = num
