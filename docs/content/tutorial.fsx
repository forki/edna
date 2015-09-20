(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
Edna shows the use of ApprovalTest with an Excel-Dna project.
========================

I was asked in an interview about the approach I would take to testing this type of project.  A neighbour mentioned ApprovalTest
so this implementation is a proof of concept.  What I want to try also, although I can already see the limitations, is taking a picture
of a range showing the result of the function delivered to the spreadsheet and pass that image through an OCR process to see the
impact of any formats or column shortening set in the sheet.  Later though.

*)
#r "Edna.dll"
open Edna

BasicFunctions.simpleFunc 0
(**
The function just echos the value passed back in to the calling cell.  It's just something basic to test.
*)
