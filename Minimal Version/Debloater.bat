@echo off
title Fury App Debloater
cd "ADB"

adb devices
pause

adb shell
pause

taskkill /F /IM adb.exe


