#!/bin/sh

app_name="Slate Pages Beta"
bundle_id="com.piratespaceship.myweather"
plist_path="Info.plist"

# exit if a command fails
set -e

# verbose / debug print commands
set -v

# ---- Set Bundle ID:
/usr/libexec/PlistBuddy -c "Set :CFBundleIdentifier ${bundle_id}" "${plist_path}"

# ---- Set App Name:
/usr/libexec/PlistBuddy -c "Set :CFBundleName ${app_name}" "${plist_path}"
