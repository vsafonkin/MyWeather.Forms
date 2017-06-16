#!/bin/sh

echo "-== Started ios prebuild script ==-"

app_name="Slate Pages Beta"
bundle_id="com.piratespaceship.myweather"
plist_path="../../../Info.plist"

# exit if a command fails
set -e || exit 1

# verbose / debug print commands
set -v || exit 1

# ---- Set Bundle ID:
/usr/libexec/PlistBuddy -c "Set :CFBundleIdentifier ${bundle_id}" "${plist_path}" || exit 1

# ---- Set App Name:
/usr/libexec/PlistBuddy -c "Set :CFBundleName ${app_name}" "${plist_path}" || exit 1

echo "-== Finished ios prebuild script ==-"