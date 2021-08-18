# Headline
This project will help to track amount of files and subfolders in chosen directory.
# Dependencies
* C# .Net Ver 5+
* Any C# Editor and compiler (Example [Rider](https://www.jetbrains.com/rider/))
# Installation
Download project as Zip. Import code files in your project and use it.
Check example code if needed;
# Description
Following Tool provide you an opportunity to quickly check amount of files and subfolders in certain directory chosen by user.
# How to use
Call function `TryGetFilesAmount(string path, out int filesAmoint)` to get amount of files in Directory. If Directory is invalid function will return `False` and files amount -1.
# Code example
```Console.WriteLine("Input some Directory path!");
            bool isPathValid;
            int filesAmount;
            do
            {
                var path = @""+Console.ReadLine();
                isPathValid = SubfoldersAmountGetter.TryGetFilesAmount(path, out var amount);
                filesAmount = amount;
            } while (!isPathValid);
            Console.Write(filesAmount + " - files in this folder");
```
