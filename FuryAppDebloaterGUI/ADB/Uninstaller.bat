@echo off
title Fury App Debloater
mode con: cols=90 lines=13

cd "ADB"

adb devices
pause

adb shell
pause

taskkill /F /IM adb.exe