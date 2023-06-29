using System;

//ref link:https://www.youtube.com/watch?v=ICsdjlrpcco&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=17
//

/*      CMD
 * 
 * C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns

29/06/2023  09:22 pm    <DIR>          .
29/06/2023  09:22 pm    <DIR>          ..
29/06/2023  08:58 pm    <DIR>          bin
28/06/2023  11:44 pm             4,608 ChessInterface.dll
29/06/2023  08:57 pm               299 DOTNET AddIns.csproj
29/06/2023  08:59 pm    <DIR>          obj
29/06/2023  09:19 pm               414 Program.cs
               3 File(s)          5,321 bytes
               4 Dir(s)  492,655,435,776 bytes free

C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns>csc /t:library /r:ChessInterface.dll /out:MyChessAlgorithm.dll MainClass.cs
Microsoft (R) Visual C# Compiler version 4.6.0-3.23259.8 (c3cc1d0c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns

29/06/2023  09:40 pm    <DIR>          .
29/06/2023  09:40 pm    <DIR>          ..
29/06/2023  08:58 pm    <DIR>          bin
28/06/2023  11:44 pm             4,608 ChessInterface.dll
29/06/2023  08:57 pm               299 DOTNET AddIns.csproj
29/06/2023  09:40 pm             1,322 MainClass.cs
29/06/2023  09:40 pm             3,584 MyChessAlgorithm.dll
29/06/2023  08:59 pm    <DIR>          obj
               4 File(s)          9,813 bytes
               4 Dir(s)  492,648,366,080 bytes free

C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns>csc /t:library /r:ChessInterface.dll /out:YourChessAlgorithm.dll MainClass.cs
Microsoft (R) Visual C# Compiler version 4.6.0-3.23259.8 (c3cc1d0c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DOTNET AddIns\DOTNET AddIns

29/06/2023  09:44 pm    <DIR>          .
29/06/2023  09:44 pm    <DIR>          ..
29/06/2023  08:58 pm    <DIR>          bin
28/06/2023  11:44 pm             4,608 ChessInterface.dll
29/06/2023  08:57 pm               299 DOTNET AddIns.csproj
29/06/2023  09:43 pm             2,179 MainClass.cs
29/06/2023  09:40 pm             3,584 MyChessAlgorithm.dll
29/06/2023  08:59 pm    <DIR>          obj
29/06/2023  09:44 pm             3,584 YourChessAlgorithm.dll
               5 File(s)         14,254 bytes
               4 Dir(s)  492,647,358,464 bytes free
 */
namespace DOTNET_AddIns
{
    class MainClass
    {
        /*public class YourChessAlgorithm : IChessGame
        {
            public ChessMove MakeMove(ChessPiece[,] board);
        {
        return new ChessMove
        {
            StartRow = 100,   
            EndRow = 200,      
            StartColumn = 300,    
            EndColumn = 400
        };*/
    }
}

