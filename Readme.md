# Fnorder

## Description
An implementation of Steve Jackson Games' Fnorder. Fnorder generates messages from the Illuminati to use in your application. This project produces a .DLL to be used by other applications.

Some more information about Fnorder as well as a compiled copy of the complete WinFnord application (as well as solutions in other languages and runtimes) can be found at the [Legacy Fnorders](http://www.sjgames.com/misc/fnord.html) page of the Steve Jackson Games website.

## Requirements
This was originally written in July 2007 with VisualStudio 2005 and .NET 2.0. I _assume_ that it will compile under recent versions of VS and the .NET runtime. I have not tested this.

This project is just the Fnorder library itself. You could grab a copy of [WinFnord project](https://github.com/Williams-Christopher/WinFnord) as an example of a WinForms application that uses this Fnorder library.

## Use
Compile Fnorder to a .dll and reference it in your project.

Fnorder exposes a single public function `getMessage()` that returns a string created from lists of different parts of speech according to various rules and calls to Random.

## Legalish stuff
I do not hold or claim any copyrights to the Fnorder produced by Steve Jackson Games. I do not work for them or contract with them. Do with this particular project what you like knowing that I offer you no warranties or gurantees of any kind.