@echo off
title Fury App Debloater Minimal Version v33.0.1-f
cd "ADB"

adb devices
pause

adb shell
pause

taskkill /F /IM adb.exe


