@echo off
title Fury App Debloater Minimal Version v1.2
cd "ADB"

adb devices
pause

adb shell
pause

taskkill /F /IM adb.exe


