#!/usr/bin/env bash
echo -e "Compile cSharp application to executable\n"
csc Program.cs Person.cs MyEnums.cs Utitlities.cs
mono Program.exe
